using System;

namespace Module2HW2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            StoreService storeService = new StoreService();
            Product product1 = new Product("Молоко", 30.20m);
            Product product2 = new Product("Хлеб", 13.30m);
            Product product3 = new Product("Мороженное", 20.50m);
            storeService.AddProduct(product1);
            storeService.AddProduct(product2);
            storeService.AddProduct(product3);

            Cart cart = new Cart();
            cart.AddProducts(storeService.SelectProducts());

            Console.WriteLine("Products in the cart: ");
            for (int i = 0; i < cart.Products.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {cart.Products[i].Name}");
            }

            Order order = new Order(cart.Products);
            Order order1 = new Order(cart.Products);
            Console.WriteLine($"Order number: {order.OrderNumber}\nProducts in the order:");
            for (int i = 0; i < order.Products.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {order.Products[i].Name}");
            }
            Console.WriteLine($"Order date: {order.OrderDate}");

            Console.WriteLine($"Order number: {order1.OrderNumber}\nProducts in the order:");
            for (int i = 0; i < order1.Products.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {order1.Products[i].Name}");
            }
            Console.WriteLine($"Order date: {order1.OrderDate}");

            Console.ReadKey();
        }
    }
}