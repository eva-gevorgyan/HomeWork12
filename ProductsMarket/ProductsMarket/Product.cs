using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsMarket
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CountInStock { get; set; }
        public List<Discount> Discounts { get; set; }
        public Product(string name, decimal price, int countInStock)
        {
            Name = name;
            Price= price;
            CountInStock = countInStock;
            Discounts=new List<Discount>();
        }
        public decimal GetDiscount()
        {
            decimal DiscountedPrice = Price;
            foreach(Discount dis in Discounts)
            {
                if(dis.Type==DiscountTypes.Fix) 
                {
                    DiscountedPrice -= dis.DiscountAmount;
                }
                else if(dis.Type==DiscountTypes.Procent)
                {
                    DiscountedPrice *= (1 - dis.DiscountAmount);
                }
            }
            return DiscountedPrice;
        }
        public bool IsAvailable(int count)
        {
            return CountInStock >= count;
        }
        public void UpdateStock(int count)
        {
            CountInStock -= count;
        }
    }
}
