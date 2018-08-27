using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Entities
{
    [Serializable]
    class Order
    {
        public DateTime CreatedOn { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public Order(DateTime createdOn, List<OrderItem> orderItems)
        {
            CreatedOn = createdOn;
            OrderItems = orderItems;
        }
    }
}
