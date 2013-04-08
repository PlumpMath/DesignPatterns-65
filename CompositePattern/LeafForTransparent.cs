using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    class LeafForTransparent : ComponentForTransparent
    {
        public LeafForTransparent(string name) : base(name) { }

        // Methods
        public override void Add(ComponentForTransparent c)
        { Console.WriteLine("Cannot add to a leaf"); }

        public override void Remove(ComponentForTransparent c)
        { Console.WriteLine("Cannot remove from a leaf"); }

        public override void Display(int depth)
        { Console.WriteLine(new String('-', depth) + name); }
    }
}
