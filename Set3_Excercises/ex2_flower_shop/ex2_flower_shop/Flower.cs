using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_flower_shop
{
    class Flower
    {
        public string Name { get; set; }
        public int Price { get; set;  }

        public Flower(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
