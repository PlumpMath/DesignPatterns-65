using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class LightA
    {
        public void TurnOn()
        {
            Console.WriteLine("turn on lightA");
        }
        public void TurnOff()
        {
            Console.WriteLine("turn off lightA");
        }
    }
}
