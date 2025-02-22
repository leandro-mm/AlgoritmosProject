using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosProject.Services
{
    public static class GeneralService
    {
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
    }
}
