using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    internal class Cart
    {
        private List<Product>? products;

        public List<Product> Products
        {
            get => products ?? throw new ArgumentNullException("Products can't be null!");
        }

        public void AddProducts(List<Product> products)
        {
            this.products = products;
        }
    }
}
