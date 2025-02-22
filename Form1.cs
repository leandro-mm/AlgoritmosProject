using AlgoritmosProject.Services;
using System.Runtime.Intrinsics.X86;

namespace AlgoritmosProject;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        textBoxInput.Text = "1,2,3,4,5";
    }

    private void btnFirstDuplicate_Click(object sender, EventArgs e)
    {
        try
        {
            ClearTxtBoxResultado();

            int[] input = GetInput();

            int result = FirstDuplicateService.FindFirstDuplicate(input);
            textBoxResultado.Text = $"Explicação do algoritmo{Environment.NewLine}";
            textBoxResultado.Text += $"O Array deve sempre começar com 1 {Environment.NewLine}";
            textBoxResultado.Text += $"O array deve estar em sequencia {Environment.NewLine}";
            textBoxResultado.Text += $"O elemento repetido aparecerá 2 vezes, exemplo 1,2,2,3 {Environment.NewLine}";                 
            textBoxResultado.Text += $"Para cada elemento diminui 1, esse resultado será um índice, o valor desse índice é transformado em negativo; {Environment.NewLine}";
            textBoxResultado.Text += $"Para o próximo elemento faz elemento -1, verifica se esse índice é um valor negativo{Environment.NewLine} ";
            textBoxResultado.Text += $"Sendo um valor negativo então encontrou o 1ºelemento repetido{Environment.NewLine}{Environment.NewLine} ";            
            textBoxResultado.Text += result > 0 ? $"O elemento repetido é {result}": "Não existe elementos repetidos na sequência";

        }
        catch (Exception ex)
        {
            textBoxResultado.Text = ex.Message;
        }

    }

    private void btnRemoveDuplicates_Click(object sender, EventArgs e)
    {
        try
        {
            ClearTxtBoxResultado();
            
            int[] result = RemoveDuplicateService.RemoveDuplicates(GetInput());

            textBoxResultado.Text += $"A única forma de eliminar o elemento da sequência é utilizand List<T>, hashSet, Linq(distinct) {Environment.NewLine}";
            textBoxResultado.Text += $"Utilizando uma estrutura de dados teremos: {string.Join(",", result)}{Environment.NewLine}{Environment.NewLine}";

            int newLength = RemoveDuplicateService.RemoveDuplicatesNewLength(GetInput());
            textBoxResultado.Text += $"Outra maneira é retornar o novo tamanho da sequencia {Environment.NewLine}";
            textBoxResultado.Text += $"Percorre a sequencia e contabiliza todos os que forems diferentes entre o atual e anterior{Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text += $"Sequencia anterior {GetInput().Length} elementos, nova sequência {newLength} elementos";  ;
        }
        catch (Exception ex)
        {

            textBoxResultado.Text = ex.Message;
        }

    }

    private void btnRemoveNthNodeFromList_Click(object sender, EventArgs e)
    {
        try
        {
            ClearTxtBoxResultado();
            int elementoAserRemovido = int.Parse(textBoxNth.Text);

            int[] input = GetInput();

            ListNode? head = null;// new ListNode(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (head == null)
                {
                    head = new ListNode(input[0]);
                    ListNode next = new ListNode(input[i]);
                    head.Next = next;
                }
                else
                {
                    ListNode? currentNode = head;
                    while ((currentNode.Next is not null))
                    {
                        currentNode = currentNode.Next;
                    }

                    if (currentNode is not null)
                    {
                        ListNode node3 = new ListNode(input[i]);
                        currentNode.Next = node3;
                    }

                }
            }
            string valoresListNode = ObterValoresListNode(head);
            ListNode resultNode = RemoveNodeService.RemoveNthNodeFromList(head, elementoAserRemovido);

            textBoxResultado.Text += $"O algoritmo utiliza fast and slow pointers{Environment.NewLine}";
            textBoxResultado.Text += $"Dummy.next = head{Environment.NewLine}";
            textBoxResultado.Text += $"Fast = slow = Dummy{Environment.NewLine}";
            textBoxResultado.Text += $"Percorre fast.next n vezes {Environment.NewLine}";
            textBoxResultado.Text += $"Percorre slow.next até fast.next for null {Environment.NewLine}";
            textBoxResultado.Text += $"Pula o elemento a ser removido slow.next = slow.next.next {Environment.NewLine}";
            textBoxResultado.Text += $"Retorna dymmy.nex pois slow é uma referência para dymmy Pula o elemento a ser removido slow.next = slow.next.next {Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text += $"O resultado para remover o {elementoAserRemovido}º elemento da lista {string.Join(",", valoresListNode)} é {string.Join(",", ObterValoresListNode(resultNode))}";

        }
        catch (Exception ex)
        {

            textBoxResultado.Text = ex.Message;
        }
       
       
    }

    private static string ObterValoresListNode(ListNode? head)
    {
        if(head is null) return string.Empty;

        ListNode node = head;
        string valoresHead = node.Value.ToString()+",";
        
        while (node.Next is not null)
        {            
            node = node.Next;
            valoresHead += node.Value.ToString()+",";
        }

        return valoresHead;
    }

    private int[] GetInput()
    {
        return textBoxInput.Text.Split(',').Select(s => int.Parse(s)).ToArray();
    }

    private void ClearTxtBoxResultado()
    {
        textBoxResultado.Text = string.Empty;
    }
}
