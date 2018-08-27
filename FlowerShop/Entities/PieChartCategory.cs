using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Entities
{

    public class PieChartCategory
    {
        public string Description { get; set; }
        public float Percentage { get; set; }
        public Color Color { get; set; }

        public PieChartCategory(string description, float percent, Color color)
        {
            Description = description;
            Percentage = percent;
            Color = color;
        }
    }
}
