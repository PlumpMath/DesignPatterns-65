using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 状态模式：但一个对象的内部状态改变时允许其改变其行为。
    /// 主要解决当控制一个对象的状态转换条件过于复杂时。把状态的判断逻辑转移到表示不同状态的一系列类中，可以把复杂的判断罗技简化。
    /// 好处：
    /// 1. 将特定的状态的行为都放在一个对象中，，所以通过定义子类可以很容易的增加新状态和转换。
    /// 2.消除庞大的条件分支。
    /// 何时使用：当一个对象的行为取决于他的状态，并且它必须在运行时刻根据它的状态改变其行为吗，就可以考虑使用状态模式了。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            light.PressSwitch();
            light.PressSwitch();
            light.PressSwitch();
            Console.Read();
        }
    }
}
