using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class Context
    {
        public Context(Strategy strategy)
        {
            this.Strategy = strategy;
        }

        public Strategy Strategy
        {
            get;
            set;
        }

        public void ContextInterface()
        {
            Strategy.AlgorithmInterface();
        }
    }
}
