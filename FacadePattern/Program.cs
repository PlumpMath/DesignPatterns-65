using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    /// <summary>
    /// 外部与一个子系统的通信必须通过一个统一的门面(Facade)对象进行，这就是门面模式。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Facade f = new Facade();
            f.TurnOnAll();
            f.TurnOffAll();
            f.TurnOnAll();
            f.TurnOffAll();

            Console.Read();
        }
    }
}
