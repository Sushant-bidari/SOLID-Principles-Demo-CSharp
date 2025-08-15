using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleProject.Single_Responsibility_Principle
{
    public class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Order(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public decimal CalculateTotalPrice()
        {
            return Product.Price * Quantity;
        }
    }
}
