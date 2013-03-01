using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    /// <summary>
    ///单例模式的特点：
    ///单例类只能有一个实例。
    ///单例类必须自己创建自己的唯一实例。
    ///单例类必须给所有其它对象提供这一实例。
    ///单例模式应用：
    ///每台计算机可以有若干个打印机，但只能有一个Printer Spooler，避免两个打印作业同时输出到打印机。
    ///一个具有自动编号主键的表可以有多个用户同时使用，但数据库中只能有一个地方分配下一个主键编号。否则会出现主键重复。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
                Console.WriteLine("The same instance");
            Console.Read();
        }
    }
}
