using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Price { set; get; }
        public int ProducerId { set; get; }
        public Producer Producer { set; get; }
        public List<Order> Orders { set; get; }
    }
}