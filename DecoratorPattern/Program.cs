using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 装饰（Decorator）模式:装饰模式以对客户端透明的方式扩展对象的功能，是继承关系的一个替代方案。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            Console.Read();
        }
    }

   // new Decorator1(
   //  new Decorator2(
   //   new Decorator3(
   //      new ConcreteComponent()
   //      )
   //   )
   //)
    //装饰模式常常被称为包裹模式，就是因为每一个具体装饰类都将下一个具体装饰类或者具体构件类包裹起来。
}
