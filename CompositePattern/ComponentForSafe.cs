using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    abstract class ComponentForSafe
    {
        protected string name;

        public ComponentForSafe(string name)
        {
            this.name = name;
        }

        public abstract void Display(int depth);

    }
}
