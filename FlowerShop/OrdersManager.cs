using FlowerShop.Entities;
using FlowerShop.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing; 
using System.Drawing.Printing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class OrdersManager : Form
    {
        private Form callerForm;
        private List<Order> _orders;
        private List<Flower> _flowers;
        private PrintPreviewDialog printPreviewDialog;
        private PrintDocument printDocument;
        private string documentContents;
        private string stringToPrint;
        private string docFileName;
        List<PieChartCategory> pieCategories;
        private SQLiteConnection _dbConnection;
        private Color[] COLORS =
        {
            Color.Aqua,
            Color.Beige,
            Color.Crimson,
            Color.DarkSeaGreen,
            Color.DeepPink,
            Color.Gold,
            Color.Ivory,
            Color.Lavender,
            Color.Lime,
            Color.Honeydew,
            Color.Navy,
            Color.Sienna
        };
        private int colorCounter = 0;


        public OrdersManager(Form callerForm)
        {
            InitializeComponent();
            this.callerForm = callerForm;
            _orders = new List<Order>();
            _flowers = new List<Flower>();
            _dbConnection = new SQLiteConnection("Data Source=flowers.db");
            loadFlowers();
            deserializeOrders();
            showOrdersList();
            showFlowerList();
            printPreviewDialog = new PrintPreviewDialog();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_printPage);
            pieCategories = new List<PieChartCategory>();
            docFileName = "";
            
            //pieChartControl.Data = new List<PieChartCategory>();
        }

        private void showOrdersList()
        {
            ordersLV.Items.Clear();
            if(_orders.Count != 0)
            {
                int idCounter = 0;
                foreach(Order order in _orders)
                {
                    idCounter++;
                    var listVItem = new ListViewItem(idCounter.ToString());
                    listVItem.SubItems.Add(order.CreatedOn.ToShortDateString());
                    double total = 0;
                    foreach(OrderItem item in order.OrderItems)
                    {
                        total += item.Arrangement.calculateCost();
                    }
                    listVItem.SubItems.Add(total.ToString());
                    ordersLV.Items.Add(listVItem);
                }
                ordersLV.Show();
            }
        }

        private void showFlowerList()
        {
            flowersLV.Items.Clear();
            if(_flowers.Count != 0)
            {
                foreach(Flower flower in _flowers)
                {
                    ListViewItem listVItem = new ListViewItem(flower.Name);
                    listVItem.SubItems.Add(flower.Price.ToString());
                    flowersLV.Items.Add(listVItem);
                }
                flowersLV.Show();
            }
        }

        private void deserializeOrders()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream filestream = File.OpenRead("ordersArchive.bin"))
                {
                    if (filestream.Length != 0)
                    {
                        _orders = (List<Order>)formatter.Deserialize(filestream);
                    }

                    if (_orders.Count == 0 )
                    {
                        throw new NoOrdersException();
                    }
                }
            }catch(FileNotFoundException)
            {
            }
        }

        private void loadFlowers()
        {
            string sqlCommandString = "Select * from flowers";

            try
            {
                _dbConnection.Open();
                SQLiteCommand sqlCommand = new SQLiteCommand(sqlCommandString, _dbConnection);
                SQLiteDataReader sqlReader = sqlCommand.ExecuteReader();
                try
                {
                    while (sqlReader.Read())
                    {
                        _flowers.Add(new Flower((string)sqlReader["Name"], (double)sqlReader["Price"]));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                finally
                {
                    sqlReader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (_dbConnection.State != ConnectionState.Closed)
                    _dbConnection.Close();
            }

    }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            callerForm.Show();
        }

        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            NewOrder frm = new NewOrder(this);
            frm.Show();
        }

        private void addFlowerBtn_Click(object sender, EventArgs e)
        {
            AddNewFlower frm = new AddNewFlower();
            frm.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            deserializeOrders();
            loadFlowers();
            showOrdersList();
            showFlowerList();
        }

        private void generateReport(string filename)
        {
            if (!docFileName.Equals(""))
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.WriteLine("Here is data about your flower business:");
                    if (_flowers.Count != 0)
                    {
                        sw.WriteLine("\n\n-----Flowers:");
                        foreach (Flower flower in _flowers)
                        {
                            sw.WriteLine("{0}, {1}", flower.Name, flower.Price.ToString());
                        }
                        sw.WriteLine("\n\n-----Orders:");
                    }
                    else
                    {
                        sw.WriteLine("No data about flowers is present. Please add some\n\n");
                    }
                    if (_orders.Count != 0)
                    {
                        double profit = 0;
                        foreach (Order order in _orders)
                        {
                            double orderTotal = 0;
                            foreach (OrderItem item in order.OrderItems)
                            {
                                orderTotal += item.Arrangement.calculateCost();
                            }
                            sw.WriteLine("{0}, cost: {1}", order.CreatedOn.ToShortDateString(), orderTotal);
                            profit += orderTotal;
                        }
                        sw.WriteLine("\n\n Revenues - {0}$", profit);
                    }
                    else
                    {
                        sw.WriteLine("No data found about orders. Please create some\n\n Revenues - 0$");
                    }
                }
            } else
            {
                DialogResult result = MessageBox.Show("No report found in local folder. Would you want one to be generated ?", "No Report Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    SaveFileDialog saveReportDialog = new SaveFileDialog();
                    saveReportDialog.Filter = "Text File | *.txt";
                    saveReportDialog.Title = "Save as a text file";
                    if(saveReportDialog.ShowDialog() == DialogResult.OK)
                    {
                        docFileName = saveReportDialog.FileName;
                        generateReport(docFileName);
                    } else
                    {
                        throw new PrintingIntrerupted();
                    }
                    
                } else
                {
                    result = MessageBox.Show("Would you like to load an already existing report ?", "Load Report?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        OpenFileDialog openReportDialog = new OpenFileDialog();
                        openReportDialog.Filter = "Text File | *.txt";
                        openReportDialog.Title = "Load a report file";
                        if(openReportDialog.ShowDialog() == DialogResult.OK)
                        {
                            docFileName = openReportDialog.FileName;
                            generateReport(docFileName);
                        } else
                        {
                            throw new PrintingIntrerupted();
                        }
                    }
                }
            }
        }

        private void generateReportLbl_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveReportDialog = new SaveFileDialog();
            saveReportDialog.Filter = "Text File | *.txt";
            saveReportDialog.Title = "Save as a text file";
            if(saveReportDialog.ShowDialog() == DialogResult.OK)
            {
                docFileName = saveReportDialog.FileName;
                generateReport(saveReportDialog.FileName);
            }
        }

        private void readReport()
        {
            printDocument.DocumentName = docFileName;
            if (docFileName != "")
            {
                using (FileStream stream = new FileStream(docFileName, FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))
                {
                    documentContents = reader.ReadToEnd();
                }
                stringToPrint = documentContents;
            }
        }
        
       void printDocument_printPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            e.Graphics.MeasureString(stringToPrint, this.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
            stringToPrint = stringToPrint.Substring(charactersOnPage);
            e.HasMorePages = (stringToPrint.Length > 0);
            if (!e.HasMorePages)
                stringToPrint = documentContents;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            try
            {
                generateReport(docFileName);
                readReport();
                printPreviewDialog.Document = printDocument;
                if(printDocument.DocumentName != "")
                printPreviewDialog.ShowDialog();
                
            } catch (PrintingIntrerupted ex)
            {
                MessageBox.Show("Nothing to print.");
            }

        }

        private Color selectColor()
        {
            return COLORS[colorCounter++];
        }

        private int getTotalNumberOfFlowers(int[] quantitySold)
        {
            int total = 0;
            for(int i = 0; i<quantitySold.Length; i++)
            {
                total += quantitySold[i];
            }
            return total;
        }

        private void prepareChartDisplay()
        {
            int[] flowerSalesQuantity = getFlowerSalesQuantity();
            int totalFlowersSold = getTotalNumberOfFlowers(flowerSalesQuantity);
            int counter = 0;
            foreach(Flower flower in _flowers)
            {
                if(flowerSalesQuantity[counter]>0)
                {
                    pieCategories.Add(new PieChartCategory(flower.Name, ((flowerSalesQuantity[counter]*100) / (float)totalFlowersSold), selectColor()));
                }
                counter++;
            }
        }

        private int[] getFlowerSalesQuantity()
        {
            int[] flowerSalesQ = new int[_flowers.Count];
            foreach (Order order in _orders)
            {
                foreach (OrderItem orderI in order.OrderItems)
                {
                    if (orderI.Arrangement.getType() == "Bouquet")
                    {
                        Bouquet temp = (Bouquet)orderI.Arrangement;
                        int counter = 0;
                        foreach (Flower flower in _flowers)
                        {
                            if (flower.Name.Equals(temp.Flower1.Name))
                            {
                                flowerSalesQ[counter]++;
                            }
                            if (flower.Name.Equals(temp.Flower2.Name))
                            {
                                flowerSalesQ[counter]++;
                            }
                            counter++;
                        }
                    }
                    else if (orderI.Arrangement.getType() == "Basket")
                    {
                        Basket temp = (Basket)orderI.Arrangement;
                        int counter = 0;
                        foreach (Flower flower in _flowers)
                        {
                            if (flower.Name.Equals(temp.Flower.Name))
                            {
                                flowerSalesQ[counter]++;
                            }
                            counter++;
                        }
                }
            }
                
        }
            return flowerSalesQ;
        }

        private void salesChartBtn_Click(object sender, EventArgs e)
        {
            prepareChartDisplay();
            pieChartControl1.Data = pieCategories.ToArray();
        }

        private void OrdersManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            callerForm.Show();
        }
    }
}
