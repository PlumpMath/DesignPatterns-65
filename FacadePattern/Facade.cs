using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class Facade
    {
        private LightA lighta;
        private LightB lightb;
        private LightC lightc;

        public  Facade()
        {
            lighta = new LightA();
            lightb = new LightB();
            lightc = new LightC();
        }

        public void TurnOnAll()
        {
            lighta.TurnOn();
            lightb.TurnOn();
            lightc.TurnOn();
        }

        public void TurnOffAll()
        {
            lighta.TurnOff();
            lightb.TurnOff();
            lightc.TurnOff();
        }
    }
}
