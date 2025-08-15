using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleProject.OpenClosedPrinciple
{
    public interface IDiscount
    {
        public decimal ApplyDiscount();
    }
    public class PercentageDiscount : IDiscount
    {
        public decimal DiscountPercentage { get; set; }
        public decimal OriginalPrice { get; set; }
        public PercentageDiscount(decimal discountPercentage, decimal originalPrice)
        {
            DiscountPercentage = discountPercentage;
            OriginalPrice = originalPrice;
        }
        public decimal ApplyDiscount()
        {
            return OriginalPrice - (OriginalPrice * DiscountPercentage / 100);
        }
    }
    public class FixedDiscount : IDiscount
    {
        public decimal DiscountAmount { get; set; }
        public decimal OriginalPrice { get; set; }
        public FixedDiscount(decimal discountAmount, decimal originalPrice)
        {
            DiscountAmount = discountAmount;
            OriginalPrice = originalPrice;
        }
        public decimal ApplyDiscount()
        {
            return OriginalPrice - DiscountAmount;
        }
    }
}
