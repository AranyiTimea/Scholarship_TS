using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_flower_shop
{
    class Bouquet
    {
        private List<Flower> flowers;
        const int assemblyValue = 2;

        public string Name { get; set; }
        public int Price { get; }

        public Bouquet(string name, List<Flower> flowers)
        {
            this.Name = name;
            this.flowers = flowers;

            Price = assemblyValue;

            foreach(var flower in flowers)
            {
                Price += flower.Price; 
            }
        }
    }
}
