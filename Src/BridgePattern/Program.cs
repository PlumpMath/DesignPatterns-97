namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstraction c = new Abstraction(new CustomerBridge("Kuwait Customer"));
            c.ShowAll();
            c = new Abstraction(new TasksBridge("ToDo"));
            c.ShowAll();

        }
    }
}
