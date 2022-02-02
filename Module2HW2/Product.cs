using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    internal class Product
    {
        private Guid code;
        private string name;
        private decimal price;
        private string description;


        public Guid Code
        {
            get => code;
            private set => code = value;
        }
        public string Name
        {
            get => name;
            private set => name = value ?? throw new ArgumentNullException(nameof(value), 
                "Name can't be null");
        }

        public decimal Price
        {
            get => price;
            private set => price = value <= 0 
                ? throw new ArgumentException("Price can't be less than or equal to zero", nameof(value))
                : value;
        }
        public string Description 
        { 
            get => description;
            set => description = value ?? string.Empty;
        }
        public Product(string name, decimal price, string? description = default)
        {
            Code = Guid.NewGuid();
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
