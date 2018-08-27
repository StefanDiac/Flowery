using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Entities
{
    [Serializable]
    class Bouquet:Arrangement
    {
        public Flower Flower1 { get; set; }
        public Flower Flower2 { get; set; }
        public string Type { get; set; }
        public int NumberOfFlower1 { get; set; }
        public int NumberOfFlower2 { get; set; }
        
        public Bouquet(Flower flower1, Flower flower2, string type, int numberOfFlower1, int numberOfFlower2)
        {
            Flower1 = flower1;
            Flower2 = flower2;
            Type = type;
            NumberOfFlower1 = numberOfFlower1;
            NumberOfFlower2 = numberOfFlower2;
        }

        public double calculateCost()
        {
            double price = Flower1.Price * NumberOfFlower1;
            if (Flower2 != null)
            { 
                price += Flower2.Price * NumberOfFlower2;
            }
            return price;
        }

        public string getType()
        {
            return Type;
        }

        Flower[] Arrangement.getFlower()
        {
            Flower[] flowerSet = new Flower[2];
            flowerSet[0] = Flower1;
            flowerSet[1] = Flower2;
            return flowerSet;
        }

        public int[] getNbOfFlowers()
        {
            int[] nbOfFlowers = new int[2];
            nbOfFlowers[0] = NumberOfFlower1;
            nbOfFlowers[1] = NumberOfFlower2;
            return nbOfFlowers;
        }
    }
}
