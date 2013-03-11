using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplatePattern
{
    /// <summary>
    /// 实现父类所定义的一个或多个抽象方法，它们是一个顶级逻辑的组成步骤。
    /// 每一个抽象模版角色都可以有任意多个具体模版角色与之对应，而每一个具体模版角色都可以给出这些抽象方法（也就是顶级逻辑的组成步骤）的不同实现，从而使得顶级逻辑的实现各不相同。
    /// </summary>
    public class ConcreteClass:AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("A1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("A2");
        }
    }
}
