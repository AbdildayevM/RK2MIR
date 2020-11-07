using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RK2MIR.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int FoodID { get; set; }
        public DateTime Ordertime { get; set;}
    }
}
