using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleProject.Dependency_Inversion_Principle
{
    public interface IPayment
    {
        public void Pay(decimal amount);
    }
    public class MobileBankingPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment of {amount} made through Mobile Banking.");
        }
    }
    public class EWalletPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment of {amount} made through E-Wallet.");
        }
    }

    public class PaymentProcessor
    {
        private readonly IPayment _paymentMethod;
        public PaymentProcessor(IPayment paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }
        public void ProcessPayment(decimal amount)
        {
            _paymentMethod.Pay(amount);
            Console.WriteLine("Payment processed successfully.");
        }
    }
}
