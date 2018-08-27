using FlowerShop.Entities;
using FlowerShop.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop

{
    public partial class Flowery : Form
    {

        

        public Flowery()
        {
            InitializeComponent();
            
        }

        private void exitMenuItemTS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutMenuItemTS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Flowery is a flower shop manager application.\n Current Version: 1.0", "About");
        }

        private void goToNewOrderForm()
        {
            try
            {
                NewOrder frm = new NewOrder(this);
                frm.Show();
                this.Hide();
            }
            catch (NoFlowersException exp)
            {
                MessageBox.Show("There are no available flowers to sell, please add some before placing an order !");
            }
        }

        private void goToManageStoreForm()
        {
            try
            {
                OrdersManager frm = new OrdersManager(this);
                frm.Show();
                this.Hide();
            } catch (NoOrdersException exp)
            {
                MessageBox.Show("No orders have been placed. Please come back after an order has been registered");
            }
        }

        private void openAddFlowerForm()
        {
            AddNewFlower frm = new AddNewFlower();
            frm.Show();
        }

        private void placeAnOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goToNewOrderForm();
        }

        private void manageOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goToManageStoreForm();
        }

        private void addNewFlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAddFlowerForm();
        }

        private void placeNewOrderBtn_Click(object sender, EventArgs e)
        {
            goToNewOrderForm();
        }

        private void addNewFlowerBtn_Click(object sender, EventArgs e)
        {
            openAddFlowerForm();
        }

        private void manageShopBtn_Click(object sender, EventArgs e)
        {
            goToManageStoreForm();
        }
    }
}
