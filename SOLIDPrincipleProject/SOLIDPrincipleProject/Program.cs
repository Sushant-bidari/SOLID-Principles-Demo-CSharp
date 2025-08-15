using SOLIDPrincipleProject.Dependency_Inversion_Principle;
using SOLIDPrincipleProject.Interface_Segregation_Principle;
using SOLIDPrincipleProject.LiskovSubstitutionPrinciple;
using SOLIDPrincipleProject.OpenClosedPrinciple;
using SOLIDPrincipleProject.Single_Responsibility_Principle;
using System;
namespace OnlineOrderManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Applying Single Responsibility Principle
            Console.WriteLine("Single Responsibility Principle Example:");
            Product product = new Product("Laptop", 1200);
            product.DisplayProductInfo();
            Order order = new Order(product, 2);
            decimal totalPrice = order.CalculateTotalPrice();
            Console.WriteLine($"Order Item: {product.Name}, Total Price: {totalPrice}");

            // Applying Open/Closed Principle for discounts
            Console.WriteLine("\nOpen/Closed Principle Example:");
            FixedDiscount fixedDiscount = new FixedDiscount(100, totalPrice);
            decimal totalPriceAfterFixedDiscount = fixedDiscount.ApplyDiscount();
            Console.WriteLine($"Total Price after $100 discount: {fixedDiscount.ApplyDiscount()}");
            PercentageDiscount percentageDiscount = new PercentageDiscount(10, totalPriceAfterFixedDiscount);
            decimal totalPriceAfterPercentageDiscount = percentageDiscount.ApplyDiscount();
            Console.WriteLine($"Total Price after 10% discount: {totalPriceAfterPercentageDiscount}");

            // Applying Liskov Substitution Principle
            Console.WriteLine("\nLiskov Substitution Principle Example:");
            PaymentMethod paymentMethod = new MobileBanking();
            paymentMethod.ProcessPayment(totalPriceAfterFixedDiscount);
            paymentMethod = new EWallet();
            paymentMethod.ProcessPayment(totalPriceAfterPercentageDiscount);

            // Applying Interface Segregation Principle
            Console.WriteLine("\nInterface Segregation Principle Example:");
            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.ProcessOrder(order);
            orderProcessor.GenerateInvoice(order,percentageDiscount);

            //Applying Dependency Inversion Principle
            Console.WriteLine("\nDependency Inversion Principle Example:");
            IPayment payment = new MobileBankingPayment();
            PaymentProcessor paymentProcessor = new PaymentProcessor(payment);
            paymentProcessor.ProcessPayment(totalPriceAfterPercentageDiscount);

            IPayment Payment2 = new EWalletPayment();
            paymentProcessor = new PaymentProcessor(Payment2);
            paymentProcessor.ProcessPayment(totalPriceAfterFixedDiscount);
        }
    }
}