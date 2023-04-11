using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsMarket
{
    class Order
    {
        public List<Product> Products { get; set; }
        public int CountItems { get; set; }
        public decimal TotalPrice { get; set; }
        public Order(List<Product> products, int countItems)
        {
            Products = products;
            CountItems = countItems;
            TotalPrice = 0; 
        }
        public void GetTotalPrice()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].IsAvailable(CountItems))
                {
                    TotalPrice += Products[i].Price * CountItems;
                }
                else
                {
                    Console.WriteLine($"{Products[i]} is out of stock");
                }
            }
            Console.WriteLine($"Total price - {TotalPrice}");
        }
        public bool IsAvailable()
        {
            for(int i = 0; i < Products.Count; i++)
            {
                if (!Products[i].IsAvailable(CountItems))
                {
                    return false;
                }
            }
            return true;
        }
        public void UpdateStock()
        {
            for(int i=0;i<Products.Count;i++)
            {
                Products[i].UpdateStock(CountItems);
            }
        }
    }
}
