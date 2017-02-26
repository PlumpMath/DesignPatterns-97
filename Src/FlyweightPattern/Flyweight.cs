using System;
using System.Collections.Generic;
using System.Linq;

namespace FlyweightPattern
{
    public interface IFlyweight
    {
        void Print();
    }

    public class Flyweight : IFlyweight
    {
        public string Name { get; set; }

        public Flyweight(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine($"Flyweight.Print {Name}");
        }
    }

    public class FlyweightFactory
    {
        private List<Flyweight> _flyweights = new List<Flyweight>();

        public FlyweightFactory()
        {
            _flyweights.Add(new Flyweight("Samer"));
            _flyweights.Add(new Flyweight("Asmaa"));
            _flyweights.Add(new Flyweight("Jad"));
            _flyweights.Add(new Flyweight("Sanda"));
        }

        public Flyweight GetFlyweight(string name)
        {
            return _flyweights.FirstOrDefault(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}