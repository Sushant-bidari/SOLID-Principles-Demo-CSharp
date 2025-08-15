using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleProject.Single_Responsibility_Principle
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; } 
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Name: {Name}, Price: {Price}");
        }
    }
}
