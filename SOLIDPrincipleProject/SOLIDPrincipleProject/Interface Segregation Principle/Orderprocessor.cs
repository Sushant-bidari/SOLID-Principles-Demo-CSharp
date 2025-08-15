using SOLIDPrincipleProject.OpenClosedPrinciple;
using SOLIDPrincipleProject.Single_Responsibility_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleProject.Interface_Segregation_Principle
{
    public interface IOrderProcessor
    {
        public void ProcessOrder(Order order);
    }
    public interface IInvoiceGenerator
    {
        public void GenerateInvoice(Order order, PercentageDiscount percentageDiscount);
    }
    public class OrderProcessor : IOrderProcessor, IInvoiceGenerator
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"Processing order for {order.Product.Name} with quantity {order.Quantity}");
        }
        public void GenerateInvoice(Order order, PercentageDiscount percentageDiscount)
        {
            Console.WriteLine($"Generating invoice for {order.Product.Name} with quantity {order.Quantity} at price {percentageDiscount.ApplyDiscount()}");
        }
    }
}