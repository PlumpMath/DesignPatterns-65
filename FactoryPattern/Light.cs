using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 抽象产品（Product）角色：工厂方法模式所创建的对象的超类型，也就是产品对象的共同父类或共同拥有的接口。在上图中，这个角色是Light。
    /// </summary>
    public abstract class Light
    {
    
        public abstract void TurnOn();

        public abstract void TurnOff();
    }
}
