using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy<dynamic> proxy = new Proxy<dynamic>();
            Console.WriteLine(proxy.Add(10, 20));
            Console.WriteLine(proxy.Add(10.5, 20.6));
        }
    }
}
