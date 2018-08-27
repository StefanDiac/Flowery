using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Entities
{
    [Serializable]
    class Basket : Arrangement
    {
        public Flower Flower { get; set; }
        public string Type { get; set; }

        public Basket(Flower flower, string type)
        {
            Flower = flower;
            Type = type;
        }

        public double calculateCost()
        {
            double price = Flower.Price * 3 + 10;
            return price;
        }

        public Flower[] getFlower()
        {
            Flower[] flowers = new Flower[1];
            flowers[0] = Flower;
            return flowers;
        }

        public int[] getNbOfFlowers()
        {
            throw new NotImplementedException();
        }

        public string getType()
        {
            return Type;
        }
    }
}
