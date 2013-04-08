using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    class Adpter:Adaptee,ITarget
    {

        public void Request()
        {
            SpecificRequest();
        }
    }
}
