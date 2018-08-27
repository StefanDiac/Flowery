using FlowerShop.Entities;
using FlowerShop.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class AddNewFlower : Form
    {
        private List<Flower> _flowers;
        private SQLiteConnection _dbConnection;

        public AddNewFlower()
        {
            InitializeComponent();
            populateSample();
            _dbConnection = new SQLiteConnection("Data Source=flowers.db");
            _flowers = new List<Flower>();
            try
            {
                deserializeMyFlowers();
            } catch (FileNotFoundException ex)
            {
                using (FileStream fileStream = File.Create("flowersArchive.bin"))
                {
                    _flowers = null;
                }
            }
           
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFlowerBtn_Click(object sender, EventArgs e)
        {
            Flower toAddFlower = new Flower(flowerNameTB.Text.Trim(), double.Parse(priceTB.Text.Trim()));
            try
            {
                if(_flowers != null)
                  toAddFlower.checkForCollision(_flowers);
                _flowers.Add(toAddFlower);
            } catch(FlowerCollisionException ex)
            {
                MessageBox.Show("There is already a flower with the name " + ex.FlowerName);
            }
            serializeFlowers();
        }

        private void flowerNameTB_Validating(object sender, CancelEventArgs e)
        {
            string flowerName = flowerNameTB.Text.Trim();

            if (string.IsNullOrWhiteSpace(flowerName))
            {
                e.Cancel = true;
                flowerNameEP.SetError(flowerNameTB, "Flower Name is Empty");
            }
        }

        private void priceTB_Validating(object sender, CancelEventArgs e)
        {
            string price = priceTB.Text.Trim();
            if (string.IsNullOrWhiteSpace(price))
            {
                e.Cancel = true;
                flowerPriceEP.SetError(priceTB, "Price is Empty");
            }
            else
            {
                double tempPrice;
                if (double.TryParse(price, out tempPrice) == false)
                {
                    e.Cancel = true;
                    flowerPriceEP.SetError(priceTB, "Price is not a number");
                }
            }

        }

        private void priceTB_Validated(object sender, EventArgs e)
        {
            flowerPriceEP.Clear();
        }

        private void flowerNameTB_Validated(object sender, EventArgs e)
        {
            flowerNameEP.Clear();
        }

        private void deserializeMyFlowers()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fileStream = File.OpenRead("flowersArchive.bin"))
                {
                    if (fileStream.Length != 0)
                        _flowers = (List<Flower>)formatter.Deserialize(fileStream);
                }
            }
            catch (FileNotFoundException exp)
            {
                using (FileStream fileStream = File.Create("flowersArchive.bin"))
                {
                    _flowers = null;
                }
                System.Console.WriteLine("File did not exist ! Created one. Exception :" + exp);
            }
        }

        private void AddNewFlower_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                string[] filenames = e.Data.GetData(DataFormats.FileDrop, true) as string[];
                foreach (string filename in filenames)
                {
                    if (System.IO.Path.GetExtension(filename).ToUpperInvariant() == ".TXT")
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void AddNewFlower_DragDrop(object sender, DragEventArgs e)
        {
            DataObject data = (DataObject)e.Data;
            if (data.ContainsFileDropList())
            {
                string[] flowersFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (flowersFiles != null)
                {
                    List<string> lines = new List<string>();
                    foreach (string flowers in flowersFiles)
                    {
                        lines.AddRange(File.ReadAllLines(flowers));
                        int counter = 0;
                        foreach (string flower in lines)
                        {
                            
                            try
                            {
                                string[] flowerComponents = flower.Split(',');
                                tryAdd(flowerComponents);
                                Flower flowerToAdd = new Flower(flowerComponents[0], double.Parse(flowerComponents[1]));
                                flowerToAdd.checkForCollision(_flowers);
                                _flowers.Add(flowerToAdd);
                            }
                            catch (InvalidFlowerException ex)
                            {
                                Console.WriteLine(ex.StackTrace);
                            }
                            catch (FlowerCollisionException ex)
                            {
                                counter++;
                            }
                        }
                        if (counter > 0)
                        {
                            MessageBox.Show(counter + " collisions were found while importing");
                        }
                        serializeFlowers();
                    }
                }
            }
        }

        private void tryAdd(string[] flowerComponents)
        {
            if(string.IsNullOrWhiteSpace(flowerComponents[0]))
            {
                throw new InvalidFlowerException();
            } else if (double.Parse(flowerComponents[1]) <= 0)
            {
                throw new InvalidFlowerException();
            }
        }

        private void serializeFlowers()
        {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fileStream = File.OpenWrite("flowersArchive.bin"))
                {
                    formatter.Serialize(fileStream, _flowers);
                }
        }

        private void populateSample()
        {
            Image imageToAdd = Image.FromFile(@"C:\Users\Eops-PC\Documents\Old College Projects\Old Projects\FlowerShop\FlowerShop\FlowerShop\Resources\rose.jpg");
            string nameLbl = "Rose";
            double priceLbl = 5.5;
            this.exampleUC.initializeComponents(imageToAdd, nameLbl, priceLbl);
        }

        private void AddNewFlower_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sqlDrop = "Drop Table Flowers";
            string sqlCreate = "CREATE TABLE 'Flowers'('Name' Text NOT NULL PRIMARY KEY, 'Price' Real)";
            string sqlInsert = "insert into Flowers(Name, Price) values (@Name, @Price)";
            try
            {
                _dbConnection.Open();
                SQLiteCommand sqlCommand = new SQLiteCommand(sqlDrop, _dbConnection);
                sqlCommand.ExecuteNonQuery();
                sqlCommand = new SQLiteCommand(sqlCreate, _dbConnection);
                sqlCommand.ExecuteNonQuery();
                foreach(Flower flower in _flowers)
                {
                    var dbCommnad = new SQLiteCommand(sqlInsert, _dbConnection);
                    dbCommnad.Transaction = _dbConnection.BeginTransaction();

                    var nameParameter = new SQLiteParameter("@Name");
                    nameParameter.Value = flower.Name;
                    var priceParameter = new SQLiteParameter("@Price");
                    priceParameter.Value = flower.Price;

                    dbCommnad.Parameters.Add(nameParameter);
                    dbCommnad.Parameters.Add(priceParameter);

                    dbCommnad.ExecuteNonQuery();

                    dbCommnad.Transaction.Commit();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (_dbConnection.State != ConnectionState.Closed)
                    _dbConnection.Close();
            }
        }
    }
}
