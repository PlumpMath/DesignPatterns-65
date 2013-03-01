using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 具体构件（Concrete Component）角色：定义一个将要接收附加责任的类。
    /// </summary>
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
