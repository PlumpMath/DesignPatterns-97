using System;

namespace ChainOfResponsibilityPattern
{
    public class President : Approve
    {
        public override void HandelRequest(Purchase purchase)
        {
            if (!string.IsNullOrEmpty(purchase.Purpose))
            {
                Console.WriteLine($"Approve purchase number ${purchase.Number} By {nameof(President)}");
            }
            else
            {
                Console.WriteLine($"Reject purchase number ${purchase.Number} By {nameof(President)}");
            }
        }
    }
}