using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    public class CompositeForTransparent : ComponentForTransparent
    {
        // Fields
        private List<ComponentForTransparent> children = new List<ComponentForTransparent>();

        // Constructors
        public CompositeForTransparent(string name) : base(name) { }

        // Methods
        public override void Add(ComponentForTransparent component)
        { children.Add(component); }

        public override void Remove(ComponentForTransparent component)
        { children.Remove(component); }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            // Display each of the node's children
            foreach (ComponentForTransparent component in children)
                component.Display(depth + 2);
        }
    }
}
