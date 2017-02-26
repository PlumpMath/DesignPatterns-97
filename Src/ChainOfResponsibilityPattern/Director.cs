using System;

namespace ChainOfResponsibilityPattern
{
    public class Director : Approve
    {
        public override void HandelRequest(Purchase purchase)
        {
            if (purchase.Amount <= 1000)
            {
                Console.WriteLine($"Approve purchase {purchase.Number} BY {nameof(Director)}");
            }
            else
            {
                _successor.HandelRequest(purchase);
            }
        }
    }
}