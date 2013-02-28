using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 策略模式：策略模式的用意是针对一组算法，将每一个算法封装到具有共同接口的独立的类中，从而使得它们可以相互替换。策略模式使得算法可以在不影响到客户端的情况下发生变化。
    /// 策略模式是对算法的包装，是把使用算法的责任和算法本身分割开，委派给不同的对象管理。策略模式通常把一个系列的算法包装到一系列的策略类里面，作为一个抽象策略类的子类。用一句话来说，就是："准备一组算法，并将每一个算法封装起来，使得它们可以互换。"
    /// 例如：商城促销时，不同的优惠规则就是各种不同算法之间的转换。
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Context s = new Context(new ConcreteStrategyA());
            s.ContextInterface();

            s = new Context(new ConcreteStrategyB());
            s.ContextInterface();

            s = new Context(new ConcreteStrategyC());
            s.ContextInterface();

            Console.Read();
        }
    }
}
