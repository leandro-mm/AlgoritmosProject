using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosProject.Services.Tree
{
    public class TreeService
    {
        public StringBuilder SbSerializacao { get; set; } = new();
        public string SerializarTree(MyTreeNode root)
        {
            if (root is null)
            {
                SbSerializacao.Append("null,");
                return SbSerializacao.ToString();
            }

            SbSerializacao.Append(root.Value.ToString()).Append(",");

            SerializarTree(root.Left);

            SerializarTree(root.Right);

            return SbSerializacao.ToString();
        }


        public static MyTreeNode Insert(MyTreeNode root, int val)
        {
            if (root is null)
            {
                root = new MyTreeNode(val);
            }
            else
            {
                if (val < root.Value)
                {
                    root.Left = Insert(root.Left, val);
                }
                else if (val > root.Value)
                {
                    root.Right = Insert(root.Right, val);
                }
            }
            return root;
        }

        public static MyTreeNode InsertFromArray(int[] array)
        {
            MyTreeNode myTreeNode = new(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                int valor = array[i];
                Insert(myTreeNode, valor);
            }

            return myTreeNode;
        }
        public void PreOrderTraversal(MyTreeNode root)
        {
            if (root is null)
            {
                SbSerializacao.Append("null,");
                return;
            }
            SbSerializacao.Append(root.Value.ToString()).Append(",");
            PreOrderTraversal(root.Left);
            PreOrderTraversal(root.Right);
        }

        public static MyTreeNode? Delete(MyTreeNode root, int key)
        {
            if (root == null)
                return null;

            if (key < root.Value)
            {
                root.Left = Delete(root.Left, key);
            }
            else if (key > root.Value)
            {
                root.Right = Delete(root.Right, key);
            }
            else
            {
                // Found node to delete
                if (root.Left == null)
                    return root.Right;
                if (root.Right == null)
                    return root.Left;

                // Find in-order successor (smallest in right subtree)
                MyTreeNode temp = FindMin(root.Right);
                root.Value = temp.Value;
                root.Right = Delete(root.Right, temp.Value);
            }
            return root;
        }

        private static MyTreeNode FindMin(MyTreeNode node)
        {
            while (node.Left is not null)
                node = node.Left;
            return node;
        }
        public static IList<int> PreOrderTraversalIteratively(MyTreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            else
            {
                List<int> preorderList = new List<int>();
                Stack<MyTreeNode> stack = new Stack<MyTreeNode>();
                stack.Push(root);
                while (stack.Count != 0)
                {
                    MyTreeNode node = stack.Pop();
                    preorderList.Add(node.Value);
                    if (node.Right != null)
                    {
                        stack.Push(node.Right);
                    }
                    if (node.Left != null)
                    {
                        stack.Push(node.Left);
                    }
                }
                return preorderList;
            }
        }
    }



    public class MyTreeNode
    {
        public int Value;
        public MyTreeNode Left;
        public MyTreeNode Right;
        public MyTreeNode(int x) { Value = x; }
    }
}
