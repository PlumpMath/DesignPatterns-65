using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    class CompositeForSafe:ComponentForSafe
    {
        public CompositeForSafe(string name):base(name)
        {

        }

        public List<ComponentForSafe> children = new List<ComponentForSafe>();

        public void Add(ComponentForSafe componentForSafe)
        {
            children.Add(componentForSafe);
        }

        public void Remove(ComponentForSafe componentForSage)
        {
            children.Remove(componentForSage);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (ComponentForSafe item in children)
            {
                item.Display(depth+1);
            }
        }
    }
}
