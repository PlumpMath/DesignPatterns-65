using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 具体装饰（Concrete Decorator）角色：负责给构件对象"贴上"附加的责任。
    /// </summary>
    /// 何时使用：
    /// 1.需要扩展一个类的功能，或给一个类增加附加责任。
    /// 2.需要动态地给一个对象增加功能，这些功能可以再动态地撤销。
    /// 3.需要增加由一些基本功能的排列组合而产生的非常大量的功能，从而使继承关系变得不现实。
    /// 
    /// 使用装饰模式主要有以下的优点：
    ///装饰模式与继承关系的目的都是要扩展对象的功能，但是装饰模式可以提供比继承更多的灵活性。
    ///通过使用不同的具体装饰类以及这些装饰类的排列组合，设计师可以创造出很多不同行为的组合。
    ///这种比继承更加灵活机动的特性，也同时意味着装饰模式比继承更加易于出错。
    ///
    ///使用装饰模式主要有以下的缺点：
    ///由于使用装饰模式，可以比使用继承关系需要较少数目的类。使用较少的类，当然使设计比较易于进行。但是，在另一方面，使用装饰模式会产生比使用继承关系更多的对象。更多的对象会使得查错变得困难，特别是这些对象看上去都很相像。
    public class ConcreteDecoratorB : Decorator
    {
        override public void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("B");
        }

        void AddedBehavior()
        {
            Console.WriteLine("B");
        }
    }
}
