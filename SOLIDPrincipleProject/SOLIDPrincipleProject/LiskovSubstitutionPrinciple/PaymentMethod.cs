using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleProject.LiskovSubstitutionPrinciple
{
    public abstract class PaymentMethod
    {
        public abstract decimal ProcessPayment(decimal Amount);
    }
    public class MobileBanking : PaymentMethod
    {
        public override decimal ProcessPayment(decimal Amount)
        {
            Console.WriteLine($"Processing payment of {Amount} via Mobile Banking");
            return Amount;
        }
    }
    public class EWallet : PaymentMethod
    {
        public override decimal ProcessPayment(decimal Amount)
        {
            Console.WriteLine($"Processing payment of {Amount} via E-Wallet");
            return Amount;
        }
    }
}
