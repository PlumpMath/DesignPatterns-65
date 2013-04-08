using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    /// <summary>
    /// 合成模式将对象组织到树结构中，可以用来描述整体与部分的关系。合成模式可以使客户端将单纯元素与复合元素同等看待
    /// 对象的树结构:
    ///一个树结构由两种节点组成：树枝节点和树叶节点。树枝节点可以有子节点，而一个树叶节点不可以有子节点。除了根节点外，其它节点有且只有一个父节点。
    ///注意：一个树枝节点可以不带任何叶子，但是它因为有带叶子的能力，因此仍然是树枝节点，而不会成为叶节点。一个树叶节点永远不可能带有子节点。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region Safe
            //// Create a tree structure
            //CompositeForSafe root = new CompositeForSafe("root");
            //root.Add(new LeafForSafe("Leaf A"));
            //root.Add(new LeafForSafe("Leaf B"));

            //CompositeForSafe comp = new CompositeForSafe("Composite X");
            //comp.Add(new LeafForSafe("Leaf XA"));
            //comp.Add(new LeafForSafe("Leaf XB"));
            //root.Add(comp);

            //root.Add(new LeafForSafe("Leaf C"));

            //// Add and remove a leaf
            //LeafForSafe l = new LeafForSafe("Leaf D");
            //root.Add(l);
            //root.Remove(l);

            //// Recursively display nodes
            //root.Display(1);

            //Console.Read();
            #endregion

            #region Transparent
            // Create a tree structure
            CompositeForTransparent root = new CompositeForTransparent("root");
            root.Add(new LeafForTransparent("Leaf A"));
            root.Add(new LeafForTransparent("Leaf B"));
            CompositeForTransparent comp = new CompositeForTransparent("Composite X");

            comp.Add(new LeafForTransparent("Leaf XA"));
            comp.Add(new LeafForTransparent("Leaf XB"));
            root.Add(comp);

            root.Add(new LeafForTransparent("Leaf C"));

            // Add and remove a leaf
            LeafForTransparent l = new LeafForTransparent("Leaf D");
            root.Add(l);
            root.Remove(l);

            // Recursively display nodes
            root.Display(1);

            Console.Read();
            #endregion

        }
    }
}
