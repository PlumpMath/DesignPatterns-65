using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class LightOff:LightState
    {

        public override void PressSwitch(Light light)
        {
            Console.WriteLine("light off");
            light.lightState = new LightOn();
        }
    }
}
