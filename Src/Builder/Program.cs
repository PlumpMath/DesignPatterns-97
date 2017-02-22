using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder audiBulder = new AudiBuilder();
            Builder bmwBuilder = new BmwBuilder();
            Director c = new Director(audiBulder);
            Console.WriteLine("Audi Builder :");
            Console.WriteLine(audiBulder.GetProduct().Print());
            c=new Director(bmwBuilder);
            Console.WriteLine("Bmw Builder :");
            Console.WriteLine(bmwBuilder.GetProduct().Print());

        }
    }
}
