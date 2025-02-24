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
    }



    public class MyTreeNode
    {
        public int val;
        public MyTreeNode left;
        public MyTreeNode right;
        public MyTreeNode(int x) { val = x; }
    }
}
