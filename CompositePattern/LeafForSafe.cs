using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    class LeafForSafe : ComponentForSafe
    {
        public LeafForSafe(string name)
            : base(name)
        {

        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
