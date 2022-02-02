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
            cart.PrintProducts();

            Order order = new Order(cart.Products);
            order.PrintOrder();


            Console.ReadKey();
        }
    }
}