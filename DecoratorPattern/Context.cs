using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 抽象构件（Component）角色：给出一个抽象接口，以规范准备接收附加责任的对象。
    /// </summary>
    public abstract class Component
    {

        public abstract void Operation();
    }
}
