using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsMarket
{
    class Store
    {
        private List<Product> products;
        private List<Order> orders;
        public Store()
        {
            products = new List<Product>();
            orders = new List<Order>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
        public void GetOrder(Order order)
        {
            if(order.IsAvailable())
            {
                orders.Add(order);
                order.UpdateStock();
                order.GetTotalPrice();
            }
            else
            {
                Console.WriteLine("Out of stock");
            }
        }
    }
}
