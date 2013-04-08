using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public abstract class LightState
    {
        public abstract void PressSwitch(Light light);
        
    }
}
