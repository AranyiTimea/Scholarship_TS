using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_flower_shop
{
    class Utilities
    {
        public Dictionary<Flower, int> Flowers()
        {
            return new Dictionary<Flower, int>() 
            {
                {new Flower("Rose", 10), 15 },
                {new Flower("Gladiola", 15), 10 },
                {new Flower("Hydrangea", 30), 25 }
            };
        }

        public Dictionary<Bouquet, int> Bouquets()
        {
            Flower rose = new Flower("Rose", 10);
            Flower gladiola = new Flower("Gladiola", 15);
            Flower hydrangea = new Flower("Hydrangea", 30);

            return new Dictionary<Bouquet, int>()
            {
                {new Bouquet("Big bouquet", new List<Flower>{ rose, rose, rose, rose, rose, rose, rose, rose, rose, gladiola, gladiola, gladiola, gladiola, gladiola, gladiola, gladiola, gladiola, gladiola, gladiola, hydrangea, hydrangea, hydrangea }), 13 },
                {new Bouquet("Medium bouquet", new List<Flower>{ rose, rose, rose, rose, rose, rose, gladiola, gladiola, gladiola, gladiola, gladiola }), 10 },
                {new Bouquet("Small bouquet", new List<Flower>{ rose, rose, rose, rose, rose }), 12 }
            };
        }
    }
}
