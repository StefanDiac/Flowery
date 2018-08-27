using FlowerShop.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FlowerShop.Entities
{

    [Serializable]

    class Flower:ICloneable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
        public Flower(string flowerName, double priceOfFlower)
        {
            Name = flowerName;
            Price = priceOfFlower;
        }

        public object Clone()
        {
            Flower toCopyFlower = new Flower(this.Name, this.Price);
            return toCopyFlower;
        }

        public void checkForCollision(List<Flower> currentFlowers)
        {
           foreach(Flower flower in currentFlowers)
            {
                if(flower.Name == this.Name)
                {
                    throw new FlowerCollisionException(this.Name);
                }
            }
        }
    }
}
