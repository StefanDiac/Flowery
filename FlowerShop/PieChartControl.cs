using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowerShop.Entities;

namespace FlowerShop
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class PieChartControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private PieChartCategory[] _data;
        public PieChartCategory[] Data{
            get { return _data; }
            set
            {
                if (_data == value)
                    return;
                _data = value;
                Invalidate();
            }
        }

        public PieChartControl()
        {
            InitializeComponent();

            ResizeRedraw = true;

            Data = new[] { new PieChartCategory("Default", 50, Color.Blue),
                new PieChartCategory("Default2",50,Color.Red)
            };
        }

        private void PieChartControl_Paint_1(object sender, PaintEventArgs e)
        {
            int descriptionsWidth = 200;

            Graphics graphics = e.Graphics;
            Rectangle clipRectangle = e.ClipRectangle;

            float radius = Math.Min(clipRectangle.Height, clipRectangle.Width - descriptionsWidth) / (float)2;

            int oX = (clipRectangle.Width - descriptionsWidth) / 2;
            int oY = clipRectangle.Height / 2;
            float x = oX - radius;
            float y = oY - radius;

            float width = radius * 2;
            float height = radius * 2;
            float percent1 = 0;
            float percent2 = 0;
            for (int i = 0; i < Data.Length; i++)
            {
                if (i >= 1)
                    percent1 += Data[i - 1].Percentage;
                percent2 += Data[i].Percentage;

                float angle1 = percent1 / 100 * 360;
                float angle2 = percent2 / 100 * 360;

                Brush b = new SolidBrush(Data[i].Color);
                graphics.FillPie(b, x, y, width, height, angle1, angle2 - angle1);
                b.Dispose();
            }

            Pen pen = new Pen(Color.BurlyWood);
            graphics.DrawEllipse(pen, x, y, width, height);

            float xDesc = x + width + 40;
            float yDesc = y;
            for (int i = 0; i < Data.Length; i++)
            {
                Brush brush = new SolidBrush(Data[i].Color);

                graphics.FillRectangle(brush, xDesc, yDesc, 30, 30);
                graphics.DrawRectangle(pen, xDesc, yDesc, 30, 30);

                Brush secondBrush = new SolidBrush(Color.Black);

                graphics.DrawString(Data[i].Description + ": " + Data[i].Percentage + "%", this.Font, secondBrush, xDesc + 35, yDesc + 15);
                yDesc += 15;
                brush.Dispose();
                secondBrush.Dispose();
            }
        }
    } 
}
