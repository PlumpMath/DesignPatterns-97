using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new ComponentConcrete();
            Decorator decoratorA = new DecoratorConcreteA();
            decoratorA.SetComponent(component);
            decoratorA.Operation();

            Decorator decoderB = new DecoratorConcreteB();
            decoderB.SetComponent(component);
            decoderB.Operation();

        }
    }
}
