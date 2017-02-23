using System;

namespace AdapterPattern
{

    public class Target
    {
        public Target()
        {
            Name = "Target";
        }
        public string Name { get; set; }

        public virtual void Request()
        {
            Console.WriteLine($"Request inside target class {Name}");
        }
    }

    public class Adaptee
    {
        public string Title { get; set; }
        public string Reson { get; set; }

        public Adaptee()
        {
            Title = "Adaptee";
            Reson = "Test";
        }

        public void SpecailPrint()
        {
            Console.WriteLine($"Request inside Adaptee class {Title}, {Reson}");
        }
    }

    public class Adapter : Target
    {
        private readonly Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }
        public override void Request()
        {
            _adaptee.SpecailPrint();
        }
    }


}