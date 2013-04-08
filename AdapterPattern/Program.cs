using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 适配器模式把一个类的接口变换成客户端所期待的另一种接口，从而使原本接口不匹配而无法在一起工作的两个类能够在一起工作。
    /// 例如：DataAdapter，和变压器。
    /// 1、 系统需要使用现有的类，而此类的接口不符合系统的需要。
    /// 2、 想要建立一个可以重复使用的类，用于与一些彼此之间没有太大关联的一些类，包括一些可能在将来引进的类一起工作。这些源类不一定有很复杂的接口。
    /// 3、 （对对象适配器而言）在设计里，需要改变多个已有子类的接口，如果使用类的适配器模式，就要针对每一个子类做一个适配器，而这不太实际。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adpter();
            target.Request();
            Console.Read();
        }
    }
}
