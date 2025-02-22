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
            textBoxResultado.Text = $"Explica��o do algoritmo{Environment.NewLine}";
            textBoxResultado.Text += $"O Array deve sempre come�ar com 1 {Environment.NewLine}";
            textBoxResultado.Text += $"O array deve estar em sequencia {Environment.NewLine}";
            textBoxResultado.Text += $"O elemento repetido aparecer� 2 vezes, exemplo 1,2,2,3 {Environment.NewLine}";                 
            textBoxResultado.Text += $"Para cada elemento diminui 1, esse resultado ser� um �ndice, o valor desse �ndice � transformado em negativo; {Environment.NewLine}";
            textBoxResultado.Text += $"Para o pr�ximo elemento faz elemento -1, verifica se esse �ndice � um valor negativo{Environment.NewLine} ";
            textBoxResultado.Text += $"Sendo um valor negativo ent�o encontrou o 1�elemento repetido{Environment.NewLine}{Environment.NewLine} ";            
            textBoxResultado.Text += result > 0 ? $"O elemento repetido � {result}": "N�o existe elementos repetidos na sequ�ncia";

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

            textBoxResultado.Text += $"A �nica forma de eliminar o elemento da sequ�ncia � utilizand List<T>, hashSet, Linq(distinct) {Environment.NewLine}";
            textBoxResultado.Text += $"Utilizando uma estrutura de dados teremos: {string.Join(",", result)}{Environment.NewLine}{Environment.NewLine}";

            int newLength = RemoveDuplicateService.RemoveDuplicatesNewLength(GetInput());
            textBoxResultado.Text += $"Outra maneira � retornar o novo tamanho da sequencia {Environment.NewLine}";
            textBoxResultado.Text += $"Percorre a sequencia e contabiliza todos os que forems diferentes entre o atual e anterior{Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text += $"Sequencia anterior {GetInput().Length} elementos, nova sequ�ncia {newLength} elementos";  ;
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
            textBoxResultado.Text += $"Percorre slow.next at� fast.next for null {Environment.NewLine}";
            textBoxResultado.Text += $"Pula o elemento a ser removido slow.next = slow.next.next {Environment.NewLine}";
            textBoxResultado.Text += $"Retorna dymmy.nex pois slow � uma refer�ncia para dymmy Pula o elemento a ser removido slow.next = slow.next.next {Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text += $"O resultado para remover o {elementoAserRemovido}� elemento da lista {string.Join(",", valoresListNode)} � {string.Join(",", ObterValoresListNode(resultNode))}";

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
