using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{

    /// <summary>
    /// Simple Factory模式根据提供给它的数据，返回几个可能类中的一个类的实例。通常它返回的类都有一个公共的父类和公共的方法。
    /// 
    /// 优点：工厂类含有必要的判断逻辑，可以决定在什么时候创建哪一个产品类的实例，客户端可以免除直接创建产品对象的责任，而仅仅"消费"产品。简单工厂模式通过这种做法实现了对责任的分割。
    /// 缺点：当产品有复杂的多层等级结构时，工厂类只有自己，以不变应万变，就是模式的缺点。因为工厂类集中了所有产品创建逻辑，一旦不能正常工作，整个系统都要受到影响。
    /// 同时，系统扩展困难，一旦添加新产品就不得不修改工厂逻辑，有可能造成工厂逻辑过于复杂。
    /// 另外，简单工厂模式通常使用静态工厂方法，这使得无法由子类继承，造成工厂角色无法形成基于继承的等级结构。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Operation o = OperationFactory.CreateOperation("+");

            o.NumberA = 5;

            o.NumberB = 4;

            Console.WriteLine(o.Method());

            Console.Read();
        }
    }
}
