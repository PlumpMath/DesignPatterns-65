using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 抽象工厂（Creator）角色：是工厂方法模式的核心，与应用程序无关。任何在模式中创建的对象的工厂类必须实现这个接口。
    /// </summary>
    public abstract class Creator
    {
        public abstract Light Factory();
    }
}
