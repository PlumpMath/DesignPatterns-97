namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Target t1 = new Target();
            Target t2 = new Adapter();

            t1.Request();
            t2.Request();
        }
    }
}
