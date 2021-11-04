using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class Customer
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Mail { set; get; }
        public List<Order> Orders { set; get; }
    }
}
