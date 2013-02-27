using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public  class Operation
    {
        private double numberA;

        public double NumberA
        {
            get
            {
                return numberA;
            }
            set
            {
                numberA = value;
            }
        }

        private double numberB;

        public double NumberB
        {
            get
            {
                return numberB;
            }
            set
            {
                numberB = value;
            }
        }

        public virtual double Method()
        {
            throw new System.NotImplementedException();
        }
    }
}
