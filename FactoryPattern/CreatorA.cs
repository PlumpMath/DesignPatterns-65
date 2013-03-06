using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 具体工厂（Concrete Creator）角色：这是实现抽象工厂接口的具体工厂类，包含与应用程序密切相关的逻辑，并且受到应用程序调用以创建产品对象。在上图中有两个这样的角色：BulbCreator与TubeCreator。
    /// </summary>
    public class CreatorA : Creator
    {
        public override Light Factory()
        {
            return new LightA();
        }
    }
}
