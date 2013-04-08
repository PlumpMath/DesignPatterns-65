using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    public abstract class ComponentForTransparent
    {
        protected string name;

        public ComponentForTransparent(string name)
        {
            this.name = name;
        }

       public abstract void Add(ComponentForTransparent c);
       public abstract void Remove(ComponentForTransparent c);
       public abstract void Display(int deply);

    }
}
