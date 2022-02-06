using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    internal class Order
    {
        private static int orderCounter = 1;
        private int orderNumber;
        private readonly List<Product> products;
        private readonly DateTime orderDate;

        public int OrderNumber
        {
            get => orderNumber;
        }

        public List<Product> Products
        {
            get => products;
        }

        public DateTime OrderDate
        {
            get => orderDate;
        }

        public Order(List<Product> products)
        {
            this.products = products;
            orderDate = DateTime.Now;
            orderNumber = orderCounter++;
        }
    }
}
