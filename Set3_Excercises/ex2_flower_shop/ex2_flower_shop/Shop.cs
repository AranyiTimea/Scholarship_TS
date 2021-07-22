using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_flower_shop
{
    class Shop
    {
        private Dictionary<Flower, int> flowersSold; //type, number sold
        private Dictionary<Bouquet, int> bouquetsSold; //type, number sold

        public Shop()
        {
            Utilities ut = new Utilities();
            flowersSold = ut.Flowers();
            bouquetsSold = ut.Bouquets();
        }

        private int TotalIncome()
        {
            int value = 0;
            
            foreach(var flower in flowersSold)
            {
                value += flower.Key.Price * flower.Value;
            }

            foreach (var bouquet in bouquetsSold)
            {
                value += bouquet.Key.Price * bouquet.Value;
            }

            return value;
        }

        public void ShowReport()
        {
            Console.WriteLine("\nSales report: \n");

            foreach (var flower in flowersSold)
            {
                Console.WriteLine("{0} \t {1} pieces x {2} ron", flower.Key.Name, flower.Value, flower.Key.Price);
            }

            Console.WriteLine("");

            foreach (var bouquet in bouquetsSold)
            {
                Console.WriteLine("{0} \t {1} pieces x {2} ron", bouquet.Key.Name, bouquet.Value, bouquet.Key.Price);
            }

            Console.WriteLine("\nThe total income is: {0} ron", TotalIncome());
        }
    }
}
