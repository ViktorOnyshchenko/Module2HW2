using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    internal class StoreService
    {
        private readonly List<Product> products;

        public List<Product> Products
        {
            get => products ?? throw new ArgumentNullException("Products can't be null!");
        }
        public StoreService()
        {
            products = new List<Product>();
            
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public List<Product> SelectProducts()
        {
            List<Product> selectedProducts = new List<Product>();
            bool isContinue = true;
            do
            {
                PrintProducts(products, "Products for buy:");
                PrintProducts(selectedProducts, "Selected products");
                int entryProduct = InputNumber();
                selectedProducts.Add(products[entryProduct]);
                Console.WriteLine("Press \"ESC\" for cancel selection or any button for continue!");
                if(Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    isContinue = false;
                }
                Console.Clear();
            } while (isContinue);
            return selectedProducts;
        }

        private void PrintProducts(List<Product> products, string message)
        {
            if (products.Any())
            {
                Console.WriteLine($"{message}");
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {products[i].Name}");
                }
                Console.WriteLine();
            }
        }

        private int InputNumber()
        {
            int entryProduct;
            bool isCorrect;
            do
            {
                isCorrect = true;
                Console.WriteLine("\nPlease select the product you want (write number product):");
                //isCorrect = int.TryParse(Console.ReadLine(), out entryProduct);
                if (!int.TryParse(Console.ReadLine(), out entryProduct) || !isExistProduct(ref entryProduct))
                {
                    isCorrect = false;
                    Console.WriteLine("Incorrect number of product!");
                }
            } while (!isCorrect);
            return entryProduct;
        }

        private bool isExistProduct(ref int number)
        {
            number--;
            if(number < 0 || number > products.Count)
            {
                return false;
            }
            return true;
        }
    }
}
