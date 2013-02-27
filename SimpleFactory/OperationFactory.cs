using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public class OperationFactory
    {
        public static Operation CreateOperation(String operation)
        {
            Operation o = null;
            switch (operation)
            {
                case "+":
                    o = new OperationAdd();
                    break;
                case "-":
                    o = new OperationSub();
                    break;
                case "*":
                    o = new OperationMul();
                    break;
                case "/":
                    o = new OperationDiv();
                    break;
            }
            return o;
        }
    }
}
