using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    internal class Order
    {
        private static int orderNumber = 1;
        private readonly List<Product> products;
        private readonly DateTime orderDate;

        public Order(List<Product> products)
        {
            this.products = products;
            orderDate = DateTime.Now;
            orderNumber++;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"Order number: {orderNumber}\nProducts in the order:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {products[i].Name}");
            }
            Console.WriteLine($"Order date: {orderDate}");
        }
    }
}
