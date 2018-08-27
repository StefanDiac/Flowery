using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageExampleControl
{
    public partial class ExampleWithImageAndText : UserControl
    {

        public ExampleWithImageAndText()
        {
            InitializeComponent();
            
        }

        public void initializeComponents(Image imageExample, String nameExample, Double priceExample)
        {
            this.pictureBox1.Image = imageExample;
            this.nameLblExample.Text = nameExample;
            this.priceLblExample.Text = priceExample.ToString();
        }
    }
}
