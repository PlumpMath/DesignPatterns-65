using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class Light
    {
        public LightState lightState;
    
        public Light()
        {
            lightState = new LightOn();
        }

        public void PressSwitch()
        {
            lightState.PressSwitch(this);
        }
    }
}
