using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Exceptions
{
    class FlowerCollisionException: Exception
    {
        public string FlowerName { get; set; }

        public FlowerCollisionException(string flowerName)
        {
            FlowerName = flowerName;
        }
    }
}
