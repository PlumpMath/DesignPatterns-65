using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 具体产品（Concrete Product）角色：这个角色实现了抽象产品角色所定义的接口。某具体产品有专门的具体工厂创建，它们之间往往一一对应。
    /// </summary>
    public class LightA : Light
    {
        public override void TurnOn()
        {
            Console.WriteLine("lightA turn on");
        }

        public override void TurnOff()
        {
            Console.WriteLine("lightA turn off");
        }
    }
}
