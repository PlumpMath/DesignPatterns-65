using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 具体装饰（Concrete Decorator）角色：负责给构件对象"贴上"附加的责任。
    /// </summary>
    public class ConcreteDecoratorA : Decorator
    {
        private string addState;
        public override void Operation()
        {
            base.Operation();
            addState = "new state";
            Console.WriteLine("A");
        }
    }
}
