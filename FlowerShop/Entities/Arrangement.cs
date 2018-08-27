using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Entities
{
    interface Arrangement
    {
        double calculateCost();
        string getType();
        Flower[] getFlower();
        int[] getNbOfFlowers();
    }
}
