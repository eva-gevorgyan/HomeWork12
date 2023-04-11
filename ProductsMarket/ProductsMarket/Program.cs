namespace ProductsMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product("Prod",1200,2),
                new Product("Prod2",5000,1),
                new Product("Prod3",1325,0)
            };
            Order order = new Order(products,1);
            order.GetTotalPrice();
            order.UpdateStock();
        }
    }
}