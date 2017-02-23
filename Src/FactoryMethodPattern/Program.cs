using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PageFactory f1 = new WebsiteFactory();
            PageFactory f2 = new ResumeFactory();

            Console.WriteLine("Website Factory:");
            Console.WriteLine($"{f1.Print()}");
            Console.WriteLine("Resume Factory:");
            Console.WriteLine($"{f2.Print()}");

        }
    }
}
