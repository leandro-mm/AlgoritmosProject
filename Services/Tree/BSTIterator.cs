using AlgoritmosProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgoritmosProject.Services.Tree
{
    public class BSTIterator : IIterator
    {
        private Stack<MyTreeNode> stack;

        public BSTIterator(MyTreeNode node)
        {
            stack = new Stack<MyTreeNode>();

            MyTreeNode nodeCopy = node;
            while (nodeCopy != null)
            {
                stack.Push(nodeCopy);
                nodeCopy = nodeCopy.Left;
            }
        }
        public bool HasNext()
        {
            return stack.Count > 0; 
        }

        public int Next()
        {
            if (HasNext())
            {
                MyTreeNode node = stack.Pop();

                MyTreeNode nodeCopy = node.Right;

                while (nodeCopy != null)
                {
                    stack.Push(nodeCopy);
                    nodeCopy = nodeCopy.Left;
                }

                return node.Value;
            }

            return -999;
           
        }
    }
}
