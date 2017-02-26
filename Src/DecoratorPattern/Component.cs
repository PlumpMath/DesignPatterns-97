using System;

namespace DecoratorPattern
{
    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ComponentConcrete : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ComponentConcrete.Operation");
        }
    }

    public abstract class Decorator : Component
    {
        private Component _component;

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component?.Operation();
        }
    }

    public class DecoratorConcreteA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("DecoratorConcreteA.Operation");
        }
    }

    public class DecoratorConcreteB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("DecoratorConcreteB.Operation");
        }
    }
}