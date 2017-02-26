namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Approve director = new Director();
            Approve vicePresident = new VicePresident();
            Approve president = new President();

            director.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            Purchase purchase1 = new Purchase
            {
                Amount = 500,
                Number = 1,
                Purpose = "test purchase"
            };
            Purchase purchase2 = new Purchase
            {
                Amount = 7000,
                Number = 2,
                Purpose = "test purchase"
            };
            Purchase purchase3 = new Purchase
            {
                Amount = 10000000,
                Number = 3,
                Purpose = "test purchase"
            };

            director.HandelRequest(purchase1);
            director.HandelRequest(purchase2);
            director.HandelRequest(purchase3);
        }
    }
}
