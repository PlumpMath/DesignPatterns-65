using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplatePattern
{
    /// <summary>
    /// 准备一个抽象类，将部分逻辑以具体方法以及具体构造子的形式实现，然后声明一些抽象方法来迫使子类实现剩余的逻辑。不同的子类可以以不同的方式实现这些抽象方法，从而对剩余的逻辑有不同的实现。这就是模版方法模式的用意。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstractClass;
            abstractClass = new ConcreteClass();
            abstractClass.TemplateMethod();

            abstractClass = new ConcreteClassB();
            abstractClass.TemplateMethod();

            Console.Read();
        }
    }
}
