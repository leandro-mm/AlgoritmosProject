
namespace AlgoritmosProject.Services
{
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


    }
}
