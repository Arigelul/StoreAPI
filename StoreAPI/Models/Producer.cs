using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class Producer
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public List<Product> Products { set; get; }
    }
}
