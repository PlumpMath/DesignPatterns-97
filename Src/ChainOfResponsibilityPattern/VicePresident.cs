using System;

namespace ChainOfResponsibilityPattern
{
    public class VicePresident : Approve
    {
        public override void HandelRequest(Purchase purchase)
        {
            if (purchase.Amount > 1000 && purchase.Amount <= 10000)
            {
                Console.WriteLine($"Approve purchase number ${purchase.Number} By {nameof(VicePresident)}");
            }
            else
            {
                _successor.HandelRequest(purchase);
            }
        }
    }
}