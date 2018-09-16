using System;

namespace LuxoftTask1
{
    class BTree
    {
        BTN root1;
        BTN root2;
        static void Main(string[] args)
        {
            BTree tree = new BTree();
            //Tree 1
            tree.root1 = new BTN(1);
            tree.root1.left = new BTN(2);
            tree.root1.right = new BTN(3);
            tree.root1.left.left = new BTN(4);
            tree.root1.left.right = new BTN(5);

            //Tree 2
            tree.root2 = new BTN(1);
            tree.root2.left = new BTN(2);
            tree.root2.right = new BTN(3);
            tree.root2.left.left = new BTN(4);
            tree.root2.left.right = new BTN(5);

            Console.WriteLine(tree.CompareBTrees(tree.root1, tree.root2));
            Console.ReadKey();
        }

        /// <summary>
        /// Compare BTree
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        bool CompareBTrees(BTN n1, BTN n2)
        {
            bool isIdentical = false;
            if (((n1 == null) && (n2 == null)))
                isIdentical= true;
            else if (((n1 != null) && (n2 != null)))
                isIdentical = ((n1.val == n2.val) && (CompareBTrees(n1.left, n2.left) && CompareBTrees(n1.right, n2.right)));
            return isIdentical;
        }
    }
}
