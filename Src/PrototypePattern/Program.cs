using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorPrototype c = new ColorPrototype { Value = "#000000" };
            var copy = c.Clone() as ColorPrototype;
            c.Value = "#ffffff";
            Console.WriteLine($"Orginal : {c.Value}");
            Console.WriteLine($"Copy : {copy.Value}");



        }
    }
}
