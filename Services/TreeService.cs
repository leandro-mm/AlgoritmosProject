using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosProject.Services
{
    public class TreeService
    {
        public StringBuilder SbSerializacao { get; set; } = new();
        public string SerializarTree(MyTreeNode root)
        {
            if (root is null) {
                SbSerializacao.Append("null,");
                return SbSerializacao.ToString();
            }

            SbSerializacao.Append(root.val.ToString()).Append(",");

            SerializarTree(root.left);

            SerializarTree(root.right);

            return SbSerializacao.ToString();
        }


        public static MyTreeNode Insert(MyTreeNode root, int val)
        {
            if(root is null)
            {
                root = new MyTreeNode(val);
            }
            else
            {
                if(val < root.val)
                {
                    root.left = Insert(root.left, val);
                }
                else if(val > root.val)
                {
                    root.right = Insert(root.right, val);
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
            SbSerializacao.Append(root.val.ToString()).Append(",");
            PreOrderTraversal(root.left);
            PreOrderTraversal(root.right);
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
                    preorderList.Add(node.val);
                    if (node.right != null)
                    {
                        stack.Push(node.right);
                    }
                    if (node.left != null)
                    {
                        stack.Push(node.left);
                    }
                }
                return preorderList;
            }
        }
    }



    public class MyTreeNode
    {
        public int val;
        public MyTreeNode left;
        public MyTreeNode right;
        public MyTreeNode(int x) { val = x; }
    }
}
