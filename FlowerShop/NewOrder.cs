using FlowerShop.Entities;
using FlowerShop.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class NewOrder : Form
    {

        private List<Flower> _flowers;
        private List<OrderItem> _orderItems;
        private Form callerForm;
        private List<Order> _orders;

        

        public NewOrder(Form callerForm)
        {
            InitializeComponent();
            this.callerForm = callerForm;
            _flowers = new List<Flower>();
            _orderItems = new List<OrderItem>();
            _orders = new List<Order>();
            deserializeMyFlowers();
            deserializeOrders();
            hideBouquetElements();
            

            foreach (Flower flower in _flowers)
            {
                flowerTypesCmbBox.Items.Add(flower.Name);
                secondFlowerTypeCmb.Items.Add(flower.Name);
            }
        }

        private void hideBouquetElements()
        {
            nbFlowers1Lbl.Hide();
            nbFlowers2Lbl.Hide();
            nbOfFlowers1TB.Hide();
            nbOfFlowers2TB.Hide();
            secondFlowerTypeCmb.Hide();
            secondFlowerTypeLbl.Hide();
        }

        private void showBouquetElements()
        {
            nbFlowers1Lbl.Show();
            nbFlowers2Lbl.Show();
            nbOfFlowers1TB.Show();
            nbOfFlowers2TB.Show();
            secondFlowerTypeCmb.Show();
            secondFlowerTypeLbl.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            callerForm.Show();
            this.Close();
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
                    else
                        throw new NoFlowersException();
                }
            }
            catch (FileNotFoundException exp)
            {
                throw new NoFlowersException();
            }
        }

        private double getFlowerPrice()
        {
            double price = 0;
            foreach(Flower flower in _flowers)
            {
                if(flower.Name.Equals(flowerTypesCmbBox.Text.Trim()) == true)
                {
                    price = flower.Price;
                }
            }
            return price;
        }

        private OrderItem createOrderItem()
        {
            if(arrangementTypeCmbBox.Text.Trim().Equals("Bouquet") == true)
            {
                Flower flower1 = new Flower(flowerTypesCmbBox.Text.Trim(), getFlowerPrice());
                Flower flower2 = new Flower(secondFlowerTypeCmb.Text.Trim(), getFlowerPrice());
                Bouquet bouquet = new Bouquet(flower1, flower2, "Bouquet", int.Parse(nbOfFlowers1TB.Text.Trim()), int.Parse(nbOfFlowers2TB.Text.Trim()));
                OrderItem orderItem = new OrderItem(bouquet, addRibbonCheck.Checked);
                return orderItem;
            } else
            {
                Flower flower = new Flower(flowerTypesCmbBox.Text.Trim(), getFlowerPrice());
                Basket basket = new Basket(flower, "Basket");
                OrderItem orderItem = new OrderItem(basket, addRibbonCheck.Checked);
                return orderItem;
            }
        }

        private void addCurrentOrderItem()
        {
            OrderItem orderItemToAdd = createOrderItem();
            _orderItems.Add(orderItemToAdd);
        }

        private void displayCurrentOrder()
        {
            newOrderLV.Items.Clear();
            foreach (OrderItem orderItem in _orderItems)
            {
                var listVI = new ListViewItem(orderItem.Arrangement.getType());
                switch (orderItem.Arrangement.getType())
                {
                    case "Bouquet":
                        for (int i = 0; i < 2; i++)
                        {
                            listVI.SubItems.Add(orderItem.Arrangement.getFlower()[i].Name);
                            listVI.SubItems.Add(orderItem.Arrangement.getNbOfFlowers()[i].ToString());
                        }
                        break;
                    case "Basket":
                        listVI.SubItems.Add(orderItem.Arrangement.getFlower()[0].Name);
                        for (int i = 0; i < 3; i++)
                            listVI.SubItems.Add("N/A");
                        break;

                }
                bool hasARibbon = orderItem.SilkRibbon;
                double price = orderItem.Arrangement.calculateCost();
                listVI.SubItems.Add(hasARibbon.ToString());
                listVI.SubItems.Add(price.ToString());
                newOrderLV.Items.Add(listVI);
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(flowerTypesCmbBox.Text.Trim()))
            {
                isValid = false;
                flowerType1EP.SetError(flowerTypesCmbBox, "Flower Type must be chosen !");
            }

            if(string.IsNullOrWhiteSpace(arrangementTypeCmbBox.Text.Trim()))
            {
                isValid = false;
                arrangementTypeEP.SetError(arrangementTypeCmbBox, "Arrangement Type must be chosen !");
            }
            
            if(nbFlowers1Lbl.Visible)
            {
                if(string.IsNullOrWhiteSpace(nbOfFlowers1TB.Text.Trim()))
                {
                    isValid = false;
                    nbOfFlowers1EP.SetError(nbOfFlowers1TB, "Field is empty !");
                }
                if(string.IsNullOrWhiteSpace(secondFlowerTypeCmb.Text.Trim()))
                {
                    isValid = false;
                    secondTypeEP.SetError(secondFlowerTypeCmb, "Second flower Type must be chosen !");
                }
                if(string.IsNullOrWhiteSpace(nbOfFlowers2TB.Text.Trim())) {
                    isValid = false;
                    nbOfFlowers2EP.SetError(nbOfFlowers2TB, "Field is empty !");
                }
            }

            if (isValid)
            {
                addCurrentOrderItem();
                displayCurrentOrder();
            }
            
        }

        private void arrangementTypeCmbBox_TextChanged(object sender, EventArgs e)
        {
            if(arrangementTypeCmbBox.Text.Trim().Equals("Bouquet")) {
                showBouquetElements();
            } else
            {
                hideBouquetElements();
            }
        }

        private void flowerTypesCmbBox_Validated(object sender, EventArgs e)
        {
            flowerType1EP.Clear();
        }

        private void arrangementTypeCmbBox_Validated(object sender, EventArgs e)
        {
            arrangementTypeEP.Clear();
        }

        private void validateTextBox(TextBox textBox, CancelEventArgs e, ErrorProvider err)
        {
            if (textBox.Visible)
            {
                string numberOfFlowers = textBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(numberOfFlowers))
                {
                    e.Cancel = true;
                    err.SetError(textBox, "Field is empty !");
                }
                else
                {
                    int temp;
                    if (int.TryParse(numberOfFlowers, out temp) == false)
                    {
                        e.Cancel = true;
                        err.SetError(textBox, "This field requires a valid number");
                    }
                }
            }
        }

        private void nbOfFlowers1TB_Validating(object sender, CancelEventArgs e)
        {
            validateTextBox(nbOfFlowers1TB, e, nbOfFlowers1EP);
        }

        private void nbOfFlowers1TB_Validated(object sender, EventArgs e)
        {
            nbOfFlowers1EP.Clear();
        }

        private void secondFlowerTypeCmb_Validated(object sender, EventArgs e)
        {
            secondTypeEP.Clear();
        }

        private void nbOfFlowers2TB_Validated(object sender, EventArgs e)
        {
            nbOfFlowers2EP.Clear();
        }

        private void nbOfFlowers2TB_Validating(object sender, CancelEventArgs e)
        {
            validateTextBox(nbOfFlowers2TB, e, nbOfFlowers2EP);
        }

        private void deserializeOrders()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream filestream = File.OpenRead("ordersArchive.bin"))
                {
                    _orders = (List<Order>)formatter.Deserialize(filestream);
                }
            }
            catch(FileNotFoundException)
            {
            }
            catch (SerializationException)
            {
            }

        }

        private void finishOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                serializeOrders();
                if (callerForm.Enabled)
                {
                    this.Close();
                }
                else
                {
                    OrdersManager frm = new OrdersManager(callerForm);
                    frm.Show();
                    this.Close();
                }
            }
            catch (EmptyOrderException)
            {
                MessageBox.Show("Your Order Is Empty ! Please Add Some Items To It.");
            }
        }

        private void serializeOrders()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            if (_orderItems.Count != 0)
            {
                Order order = new Order(DateTime.Now, _orderItems);
                _orders.Add(order);
                using (FileStream fileStream = File.OpenWrite("ordersArchive.bin"))
                {
                        formatter.Serialize(fileStream, _orders);                    
                }
            }
            else
            {
                throw new EmptyOrderException();
            }
        }

        private void NewOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            callerForm.Show();
        }
    } 
}
