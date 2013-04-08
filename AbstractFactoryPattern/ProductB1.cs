using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    /// <remarks>抽象工厂模式所创建的任何产品对象都是某一个具体产品类的实例。这是客户端最终需要的东西，其内部一定充满了应用系统的商业逻辑。</remarks>
    public class ProductB1 : AbstractProductB
    {
        public override void ProductB()
        {
            Console.WriteLine("ProductB1");
        }
    }
}
