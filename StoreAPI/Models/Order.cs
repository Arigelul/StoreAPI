using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class Order
    {
        public int CustomerId { set; get; }
        public int ProductId { set; get; }
    }
}
