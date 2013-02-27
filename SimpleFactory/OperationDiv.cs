using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public class OperationDiv : Operation
    {
        public override double Method()
        {
            return NumberA / NumberB;
        }
    }
}
