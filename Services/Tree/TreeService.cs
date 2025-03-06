using System.Text;

namespace AlgoritmosProject.Services.Tree;

public class TreeService
{
    public StringBuilder SbSerializacao { get; set; } = new();
    public string TreePreOrderSerializar(MyTreeNode root)
    {
        if (root is null)
        {
            SbSerializacao.Append("null,");
            return SbSerializacao.ToString();
        }

        SbSerializacao.Append(root.Value.ToString()).Append(",");

        TreePreOrderSerializar(root.Left);

        TreePreOrderSerializar(root.Right);

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

    public static MyTreeNode BST_FromArray(int[] array)
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
                if (node is MyTreeNode)
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

    public static IList<List<int>> LevelOrderTraversalII(MyTreeNode root)
    {
        IList<List<int>> levelORderTraversal = LevelOrderTraversal(root);

        for (int i = 0; i < levelORderTraversal.Count / 2; i++)
        {
            List<int> temp = levelORderTraversal[i];
            levelORderTraversal[i] = levelORderTraversal[levelORderTraversal.Count - 1];
            levelORderTraversal[levelORderTraversal.Count - 1] = temp;
        }

        return levelORderTraversal;

    }
    public static IList<List<int>> LevelOrderTraversal(MyTreeNode root)
    {
        IList<List<int>> result = [];

        if (root is null)
        {
            return result;
        }

        Queue<MyTreeNode?> queue = [];

        queue.Enqueue(root);

        queue.Enqueue(null);

        List<int> currentLevel = [];

        while (queue.Count > 0)
        {
            MyTreeNode? currentNode = queue.Dequeue();

            if (currentNode is null)
            {
                result.Add(new List<int>(currentLevel));

                currentLevel.Clear();

                if (queue.Count > 0)
                {
                    queue.Enqueue(null);
                }
            }
            else
            {
                currentLevel.Add(currentNode.Value);

                if (currentNode.Left is MyTreeNode)
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

    public static IList<List<int>> ZigZagLevelOrderTraversal(MyTreeNode root)
    {
        IList<List<int>> result = [];

        if (root is null)
        {
            return result;
        }

        Queue<MyTreeNode?> queue = [];

        queue.Enqueue(root);

        queue.Enqueue(null);

        List<int> currentLevel = [];

        int countNullPositions = 0;

        while (queue.Count > 0)
        {
            MyTreeNode? currentNode = queue.Dequeue();

            if (currentNode is null)
            {
                countNullPositions++;

                if (countNullPositions % 2 == 0)
                {
                    for (int i = 0; i < currentLevel.Count / 2; i++)
                    {
                        int temp = currentLevel[i];
                        currentLevel[i] = currentLevel[currentLevel.Count - i - 1];
                        currentLevel[currentLevel.Count - i - 1] = temp;
                    }
                }
                result.Add(new List<int>(currentLevel));

                currentLevel.Clear();

                if (queue.Count > 0)
                {
                    queue.Enqueue(null);
                }
            }
            else
            {
                currentLevel.Add(currentNode.Value);

                if (currentNode.Left is MyTreeNode)
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

    public static IList<int> FindRighSideViewFromTree(MyTreeNode root)
    {
        IList<int> result = [];

        IList<List<int>> levelOrderTree = LevelOrderTraversal(root);

        for (int i = 0; i < levelOrderTree.Count(); i++)
        {
            if (levelOrderTree[i].Count() == 2)
            {
                result.Add(levelOrderTree[i][1]);
            }
            else
            {
                result.Add(levelOrderTree[i][0]);
            }
        }

        return result;
    }

    public static IList<int> AgregateRootToPath(MyTreeNode root)
    {
        IList<int> result = [];

        Stack<MyTreeNode> stackTree = [];
        stackTree.Push(root);

        Stack<string> stackPathSoFar = [];
        stackPathSoFar.Push(root.Value.ToString());

        while (stackTree.Count > 0)
        {
            MyTreeNode currentNode = stackTree.Pop();

            string currentPath = stackPathSoFar.Pop();

            if (currentNode.Left == null && currentNode.Right == null)
            {
                result.Add(int.Parse(currentPath));
            }

            if (currentNode.Right != null)
            {
                stackTree.Push(currentNode.Right);
                stackPathSoFar.Push(currentPath + currentNode.Right.Value);
            }

            if (currentNode.Left != null)
            {
                stackTree.Push(currentNode.Left);
                stackPathSoFar.Push(currentPath + currentNode.Left.Value);
            }
        }

        return result;
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

    public static MyTreeNode ObterTreeLevelOrderTraversalII()
    {
        MyTreeNode root = new MyTreeNode(3);
        root.Left = new MyTreeNode(9);
        root.Left.Left = new MyTreeNode(2);
        root.Left.Right = new MyTreeNode(5);


        root.Right = new MyTreeNode(20);
        root.Right.Left = new MyTreeNode(15);
        root.Right.Left.Left = new MyTreeNode(33);
        root.Right.Left.Right = new MyTreeNode(99);
        root.Right.Right = new MyTreeNode(7);
        root.Right.Right.Left = new MyTreeNode(77);
        root.Right.Right.Right = new MyTreeNode(107);

        root.Left.Right.Left = new MyTreeNode(55);
        root.Left.Right.Right = new MyTreeNode(100);

        root.Left.Left.Left = new MyTreeNode(22);
        root.Left.Left.Right = new MyTreeNode(44);

        return root;
    }

    public static MyTreeNode ObterTreeLevelRightSideView()
    {
        MyTreeNode root = new MyTreeNode(1);
        root.Left = new MyTreeNode(2);
        root.Right = new MyTreeNode(3); ;
        root.Left.Left = new MyTreeNode(4); ;
        root.Left.Left.Left = new MyTreeNode(5); ;

        return root;
    }

    public static MyTreeNode ObterTreeLevelRightSideViewII()
    {
        MyTreeNode root = new MyTreeNode(1);
        root.Left = new MyTreeNode(2);
        root.Right = new MyTreeNode(3); ;
        root.Left.Right = new MyTreeNode(5); ;
        root.Right.Right = new MyTreeNode(4); ;

        return root;
    }

    public static int HouseRobeerIII(MyTreeNode root)
    {
        if (root is null)
        {
            return 0;
        }

        IList<List<int>> levels = [];

        MyTreeNode node = root;

        Queue<MyTreeNode?> queueNodes = [];
        queueNodes.Enqueue(node);
        queueNodes.Enqueue(null);

        List<int> levelValues = [];

        while (queueNodes.Count() > 0)
        {
            MyTreeNode? currentNode = queueNodes.Dequeue();

            if (currentNode is null)
            {
                levels.Add(new List<int>(levelValues));

                levelValues.Clear();

                if (queueNodes.Count() > 0)
                {
                    queueNodes.Enqueue(null);
                }
            }
            else
            {
                levelValues.Add(currentNode.Value);

                if (currentNode.Left is MyTreeNode)
                {
                    queueNodes.Enqueue(currentNode.Left);
                }

                if (currentNode.Right is MyTreeNode)
                {
                    queueNodes.Enqueue(currentNode.Right);
                }
            }

        }

        return Math.Max(SumLevels(0, levels), SumLevels(1, levels));

    }

    private static int SumLevels(int startIndex, IList<List<int>> levels)
    {
        int sum = 0;

        while (startIndex < levels.Count)
        {
            sum += levels[startIndex].Sum();

            startIndex += 2;
        }
        return sum;
    }

    internal static MyTreeNode? LCA_BST(MyTreeNode root, MyTreeNode node1, MyTreeNode node2)
    {
        return null;
    }

    internal static MyTreeNode? LCA_BT(MyTreeNode root, MyTreeNode node1, MyTreeNode node2)
    {
        if (root is null)
            return null;

        if (root == node1 || root == node2)
            return root;

        MyTreeNode? left = LCA_BT(root.Left, node1, node2);

        MyTreeNode? right = LCA_BT(root.Right, node1, node2);

        if (left is MyTreeNode && right is MyTreeNode)
            return root;

        if (left is null)
            return right;
        else
            return left;
    }

    internal static MyTreeNode GetStandardtBinaryTree()
    {
        MyTreeNode root = new MyTreeNode(3);
        
        root.Left = new MyTreeNode(5);
        root.Left.Left = new MyTreeNode(6);
        root.Left.Right = new MyTreeNode(2);
        root.Left.Right.Left = new MyTreeNode(7);
        root.Left.Right.Right = new MyTreeNode(4);

        root.Right = new MyTreeNode(1);
        root.Right.Left = new MyTreeNode(0);
        root.Right.Right= new MyTreeNode(8);

        return root;
    }

    public static int LongestConsecutiveSequenceBT(MyTreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
            

        if (root.Right == null && root.Left == null)
        {
            return 1;
        }
            

        else
        {
            int maxSize = 1;

            Queue<int> sizeQ = new Queue<int>();
            sizeQ.Enqueue(1);

            Queue<MyTreeNode> nodeQ = [];
            nodeQ.Enqueue(root);

            while (nodeQ.Count != 0)
            {
                MyTreeNode currNode = nodeQ.Dequeue();

                int currSize = sizeQ.Dequeue();

                if (currNode.Left != null)
                {
                    int leftSize = currSize;

                    if (currNode.Value == currNode.Left.Value - 1)
                        leftSize += 1;
                    else
                        leftSize = 1;

                    maxSize = Math.Max(maxSize, leftSize);

                    nodeQ.Enqueue(currNode.Left);

                    sizeQ.Enqueue(leftSize);
                }
                if (currNode.Right != null)
                {
                    int rightSize = currSize;
                    if (currNode.Value == currNode.Right.Value - 1)
                        rightSize += 1;
                    else
                        rightSize = 1;

                    maxSize = Math.Max(maxSize, rightSize);

                    nodeQ.Enqueue(currNode.Right);

                    sizeQ.Enqueue(rightSize);
                }
            }

            return maxSize;
        }
    }

    public static bool IsValidPreOrderBST(int[] input)
    {
        Stack<int> stack = new Stack<int>();

        int predecessor = int.MinValue;

        foreach (int nodeVal in input)
        {
            if (nodeVal < predecessor)
            {
                return false;
            }

            while (stack.Count != 0 && stack.Peek() < nodeVal)
            {
                predecessor = stack.Pop();
            }

            stack.Push(nodeVal);
        }
        return true;
    }

    public static MyTreeNode? UpSideDownTree(MyTreeNode root)
    {
        if(root is null)
        {
            return null;
        }

        MyTreeNode? rootCopy = root;
        
        MyTreeNode? parent = null;

        MyTreeNode? right = null;

        while(rootCopy is MyTreeNode)
        {
            MyTreeNode? left = rootCopy.Left;

            rootCopy.Left = parent;

            right = rootCopy.Right ;

            rootCopy.Right = parent;

            parent = rootCopy;

            rootCopy = left;
        }

        return parent;

    }
}

public class MyTreeNode
{
    public int Value;
    public MyTreeNode Left;
    public MyTreeNode Right;
    public MyTreeNode(int x) { Value = x; }
}


