using AlgoritmosProject.Services.Tree;
using System.Text;

namespace AlgoritmosProject.Services;

public static class GeneralService
{
    public static ListNode? CriarListNodeFromArray(int[] array)
    {
        if (array.Length == 0)
            return null;

        ListNode node = new ListNode(array[0]);

        ListNode head = node;

        for (int i = 1; i < array.Length; i++)
        {
            ListNode newNode = new ListNode(array[i]);
            node.Next = newNode;
            node = newNode;
        }

        return head;
    }

    public static string ObterValoresListNode(ListNode? head)
    {
        if (head is null) return string.Empty;

        ListNode node = head;
        string valoresHead = node.Value.ToString() + ",";

        while (node.Next is not null)
        {
            node = node.Next;
            valoresHead += node.Value.ToString() + ",";
        }

        return valoresHead;
    }

    public static int[] GetInputFromTextBox(TextBox textBox)
    {
        return textBox.Text.Split(',').Select(s => int.Parse(s)).ToArray();
    }

    public static void ClearTexttBox(TextBox textBox)
    {
        textBox.Text = string.Empty;
    }

    public static void ReportarExcecao(TextBox textBox, string text)
    {
        ClearTexttBox(textBox);
        textBox.Text = text;
    }
    public static void SetInputBoxDefaultValues(TextBox textBox, string text)
    {
        ClearTexttBox(textBox);
        textBox.Text = text;
    }

    public static int NumTrees(int n)
    {
        int[] solutions = new int[n + 1];

        for (int i = 0; i < n + 1; i++)
        {
            solutions[i] = -1;
        }
        return NumUniqueBST(n, solutions);
    }

    
    public static string PrintListData<T>(T[,] inputArray)
    {
        StringBuilder stringBuilder = new();

        int rows = inputArray.GetLength(0);
        
        int columns = inputArray.GetLength(1);

        for (int i = 0; i < rows; i++) 
        {           
            for (int j = 0; j < columns; j++) 
            {
                stringBuilder.Append(inputArray[i,j]).Append(',');
            }
            stringBuilder.AppendLine();
        }

      

        return stringBuilder.ToString();
    }

    public static string PrintListDataAsGrid<T>(T[][] inputArray)
    {
        StringBuilder stringBuilder = new();

        int rows = inputArray.Length;

        int columns = inputArray[0].Length;

        stringBuilder.AppendLine("[");

        for (int i = 0; i < rows; i++) // Loop through rows
        {
            stringBuilder.Append("\t[");

            for (int j = 0; j < columns; j++) // Loop through columns
            {
                stringBuilder.Append(inputArray[i][j]).Append(',');
            }
            stringBuilder.AppendLine("]"); // Move to the next line after each row
        }

        stringBuilder.AppendLine("]");

        return stringBuilder.ToString();
    }
    public static string PrintListData<T>(T[][] inputArray)
    {
        StringBuilder stringBuilder = new();

        int rows = inputArray.Length;

        int columns = inputArray[0].Length ;

        stringBuilder.Append("[");

        for (int i = 0; i < rows; i++) // Loop through rows
        {
            stringBuilder.Append("[");

            for (int j = 0; j < columns; j++) // Loop through columns
            {
                stringBuilder.Append(inputArray[i][j]).Append(',');                
            }
            stringBuilder.Append(']'); // Move to the next line after each row
        }

        stringBuilder.AppendLine("]");

        return stringBuilder.ToString();
    }
    public static string PrintListData(int[] array)
    {
        StringBuilder stringBuilder = new();

        stringBuilder.Append("[");

        for (int k = 0; k < array.Length; k++)
        {
            stringBuilder.Append($"{array[k].ToString()},");
        }

        stringBuilder.AppendLine("]");

        return stringBuilder.ToString();
    }
    public static string PrintListData(IList<List<int>> data)
    {
        StringBuilder stringBuilder = new();

        foreach (var item in data)
        {
            stringBuilder.Append("[").Append(string.Join(",", item)).Append("],");
        }

        return stringBuilder.ToString();
    }

    public static string PrintListData(IList<int> data)
    {
        StringBuilder stringBuilder = new();

        foreach (var item in data)
        {
            stringBuilder.Append("[").Append(string.Join(",", item)).Append("],");
        }

        return stringBuilder.ToString();
    }
    private static int NumUniqueBST(int n, int[] solutions)
    {
        if (n < 0)
        {
            return 0;
        }

        if (n == 0 || n == 1)
        {
            return 1;
        }

        if (solutions[n] != -1)
        {
            return solutions[n];
        }

        int possibilities = 0;

        for (int i = 0; i < n; i++)
        {
            if (solutions[i] == -1)
            {
                solutions[i] = NumUniqueBST(i, solutions);
            }

            if (solutions[n - 1 - i] == -1)
            {
                solutions[n - 1 - i] = NumUniqueBST(n - 1 - i, solutions);
            }
            possibilities += solutions[i] * solutions[n - 1 - i];
        }

        solutions[n] = possibilities;

        return possibilities;
    }

    public static IList<MyTreeNode> NumUniqueBST2(int n)
    {
        if (n == 0)
        {
            return new List<MyTreeNode>();
        }
        else
        {
            return TreeConstructor(1, n);
        }
    }

    private static IList<MyTreeNode?> TreeConstructor(int start, int end)
    {
        List<MyTreeNode?> results = new();

        if (start > end)
        {
            results.Add(null);

            return results;
        }
        for (int i = start; i <= end; i++)
        {
            var leftTrees = TreeConstructor(start, i - 1);

            var rightTrees = TreeConstructor(i + 1, end);

            foreach (var leftTree in leftTrees)
            {
                foreach (var rightTree in rightTrees)
                {
                    var currNode = new MyTreeNode(i);

                    currNode.Left = leftTree;

                    currNode.Right = rightTree;

                    results.Add(currNode);
                }
            }
        }
        return results;
    }

    
}
