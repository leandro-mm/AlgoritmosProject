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
        public void PreOrderTraversalByFunction(MyTreeNode root)
        {
            if (root is null)
            {
                SbSerializacao.Append("null,");
                return;
            }
            SbSerializacao.Append(root.Value.ToString()).Append(",");
            PreOrderTraversalByFunction(root.Left);
            PreOrderTraversalByFunction(root.Right);
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

        public static IList<int> InOrderTraversalIteratively(MyTreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            else
            {
                List<int> preorderList = new List<int>();
                
                Stack<MyTreeNode> stack = new Stack<MyTreeNode>();
                
                MyTreeNode node = root;

                while (stack.Count != 0 || node is MyTreeNode)
                {
                    if(node is MyTreeNode)
                    {
                        stack.Push(node);
                        node = node.Left;
                    }
                    else
                    {
                        node = stack.Pop();
                        preorderList.Add(node.Value);
                        node = node.Right;
                    }
                }
                return preorderList;
            }
        }

        public static IList<IList<int>> LevelOrderTraversalII(MyTreeNode root)
        {
            IList<IList<int>> levelORderTraversal = LevelOrderTraversal(root);

            for (int i = 0; i < levelORderTraversal.Count / 2; i++)
            {
                IList<int> temp = levelORderTraversal[i];
                levelORderTraversal[i] = levelORderTraversal[levelORderTraversal.Count - 1];
                levelORderTraversal[levelORderTraversal.Count - 1] = temp;
            }

            return levelORderTraversal;

        }
        public static IList<IList<int>> LevelOrderTraversal(MyTreeNode root)
        {
            List<IList<int>> result = [];

            if(root is null)
            {
                return result;
            }

            Queue<MyTreeNode?> queue = [];

            queue.Enqueue(root);

            queue.Enqueue(null);

            List<int> currentLevel = [];

            while(queue.Count > 0)
            {
                MyTreeNode? currentNode = queue.Dequeue();

                if(currentNode is null)
                {
                    result.Add(new List<int>(currentLevel));

                    currentLevel.Clear();
                    
                    if(queue.Count > 0)
                    {
                        queue.Enqueue(null);
                    }
                }
                else
                {
                    currentLevel.Add(currentNode.Value);

                    if(currentNode.Left is MyTreeNode)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right is MyTreeNode)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }
            }
            return result;
        }

        public static IList<IList<int>> AllPathSum(MyTreeNode root, int targetSum)
        {

            if (root == null)
            {
                return [];
            }
            else
            {
                MyTreeNode currentNode = root;

                Stack<MyTreeNode> nodeStack = [];
                nodeStack.Push(currentNode);

                Stack<IList<int>> pathStack = [];
                pathStack.Push(new List<int> { currentNode.Value });

                IList<IList<int>> validPaths = [];

                while (nodeStack.Count > 0)
                {
                    MyTreeNode current = nodeStack.Pop();

                    IList<int> currentPath = pathStack.Pop();                    

                    if (current.Left == null && current.Right == null)
                    {
                        if (currentPath.Sum() == targetSum)
                        {
                            validPaths.Add(currentPath);
                        }
                    }

                    if (current.Right != null)
                    {
                        IList<int> rightPath = new List<int>(currentPath) { current.Right.Value };

                        nodeStack.Push(current.Right);

                        pathStack.Push(rightPath);
                    }

                    if (current.Left != null)
                    {
                        IList<int> leftPath = new List<int>(currentPath) { current.Left.Value };
                        
                        nodeStack.Push(current.Left);

                        pathStack.Push(leftPath);
                    }
                }
                return validPaths;
            }
        }
    
        public static MyTreeNode ObterTreeLevelOrderTraversal()
        {
            MyTreeNode root = new MyTreeNode(3);
            root.Left = new MyTreeNode(9);
            root.Left.Right = null;
            root.Left.Left = null;
            root.Right = new MyTreeNode(20);
            root.Right.Left = new MyTreeNode(15);
            root.Right.Right = new MyTreeNode(7);

            return root;
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
