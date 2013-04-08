using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    class LightOn:LightState
    {
        public override void PressSwitch(Light light)
        {
            Console.WriteLine("turn on");
            light.lightState = new LightOff();
        }
    }
}
