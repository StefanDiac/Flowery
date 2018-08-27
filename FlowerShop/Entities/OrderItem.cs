using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Entities
{
    [Serializable]
    class OrderItem
    {
        public Arrangement Arrangement { get; set; }
        public bool SilkRibbon { get; set; }

        public OrderItem(Arrangement arrangementType, bool hasSilkRibbon)
        {
            Arrangement = arrangementType;
            SilkRibbon = hasSilkRibbon;
        }
    }
}
