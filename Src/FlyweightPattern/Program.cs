namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new FlyweightFactory();
            factory.GetFlyweight("samer").Print();
            factory.GetFlyweight("jad").Print();
        }
    }
}
