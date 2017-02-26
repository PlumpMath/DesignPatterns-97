using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public abstract class Component
    {
        protected string _name;

        public Component(string name)
        {
            _name = name;
        }

        public abstract void Add(Component c);
        public abstract void Delete(Component c);
        public abstract void Display(int deep);
    }

    public class Composite : Component
    {
        public List<Component> _child = new List<Component>();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            _child.Add(c);
        }

        public override void Delete(Component c)
        {
            _child.Remove(c);
        }

        public override void Display(int deep)
        {
            Console.WriteLine(new String('-', deep) + _name);

            // Recursively display child nodes
            foreach (Component component in _child)
            {
                component.Display(deep + 2);
            }
        }
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine($"Cant add component to {_name}");
        }

        public override void Delete(Component c)
        {
            Console.WriteLine($"Cant remove component to {_name}");
        }

        public override void Display(int deep)
        {
            Console.WriteLine(new String('-', deep) + _name);
        }
    }
}