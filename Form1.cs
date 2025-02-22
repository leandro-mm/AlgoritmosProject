using AlgoritmosProject.Services;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace AlgoritmosProject;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        GeneralService.ClearTexttBox(textBoxResultado);
        GeneralService.SetInputBoxDefaultValues(textBoxInput, "1,2,3,4,5");
    }

    private void btnFirstDuplicate_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            int result = FirstDuplicateService.FindFirstDuplicate(input);
            textBoxResultado.Text = $"Explicação do algoritmo{Environment.NewLine}";
            textBoxResultado.Text += $"O Array deve sempre começar com 1 {Environment.NewLine}";
            textBoxResultado.Text += $"O array deve estar em sequencia {Environment.NewLine}";
            textBoxResultado.Text += $"O elemento repetido aparecerá 2 vezes, exemplo 1,2,2,3 {Environment.NewLine}";
            textBoxResultado.Text += $"Para cada elemento diminui 1, esse resultado será um índice, o valor desse índice é transformado em negativo; {Environment.NewLine}";
            textBoxResultado.Text += $"Para o próximo elemento faz elemento -1, verifica se esse índice é um valor negativo{Environment.NewLine} ";
            textBoxResultado.Text += $"Sendo um valor negativo então encontrou o 1ºelemento repetido{Environment.NewLine}{Environment.NewLine} ";
            textBoxResultado.Text += result > 0 ? $"O elemento repetido é {result}" : "Não existe elementos repetidos na sequência";

        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void btnRemoveDuplicates_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);
            var input = GeneralService.GetInputFromTextBox(textBoxInput);

            int[] result = RemoveDuplicateService.RemoveDuplicates(input);

            textBoxResultado.Text += $"A única forma de eliminar o elemento da sequência é utilizand List<T>, hashSet, Linq(distinct) {Environment.NewLine}";
            textBoxResultado.Text += $"Utilizando uma estrutura de dados teremos: {string.Join(",", result)}{Environment.NewLine}{Environment.NewLine}";

            int newLength = RemoveDuplicateService.RemoveDuplicatesNewLength(input);
            textBoxResultado.Text += $"Outra maneira é retornar o novo tamanho da sequencia {Environment.NewLine}";
            textBoxResultado.Text += $"Percorre a sequencia e contabiliza todos os que forems diferentes entre o atual e anterior{Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text += $"Sequencia anterior {input.Length} elementos, nova sequência {newLength} elementos"; ;
        }
        catch (Exception ex)
        {

            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void btnRemoveNthNodeFromList_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);
            int elementoAserRemovido = int.Parse(textBoxNth.Text);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

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
            string valoresListNode = GeneralService.ObterValoresListNode(head);
            ListNode resultNode = RemoveNodeService.RemoveNthNodeFromList(head, elementoAserRemovido);

            textBoxResultado.Text += $"O algoritmo utiliza fast and slow pointers{Environment.NewLine}";
            textBoxResultado.Text += $"Dummy.next = head{Environment.NewLine}";
            textBoxResultado.Text += $"Fast = slow = Dummy{Environment.NewLine}";
            textBoxResultado.Text += $"Percorre fast.next n vezes {Environment.NewLine}";
            textBoxResultado.Text += $"Percorre slow.next até fast.next for null {Environment.NewLine}";
            textBoxResultado.Text += $"Pula o elemento a ser removido slow.next = slow.next.next {Environment.NewLine}";
            textBoxResultado.Text += $"Retorna dymmy.nex pois slow é uma referência para dymmy Pula o elemento a ser removido slow.next = slow.next.next {Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text += $"O resultado para remover o {elementoAserRemovido}º elemento da lista {string.Join(",", valoresListNode)} é {string.Join(",", GeneralService.ObterValoresListNode(resultNode))}";

        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }
    }

    private void btnBynarySerach_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            int elementoToFind = int.Parse(textBoxBinarySerach.Text);

            string resultado = $"Elemento {elementoToFind} não está na lista";

            int left = 0, right = input.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (elementoToFind == input[mid])
                {
                    resultado = $"Elemento {elementoToFind} está na lista";
                    break;
                }

                if (elementoToFind > mid)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

            }

            textBoxResultado.Text = $"Array deve estar ordenado {Environment.NewLine}";
            textBoxResultado.Text = $"Inicia left = 0, right = list.size-1 {Environment.NewLine}";
            textBoxResultado.Text += $"while left<= right {Environment.NewLine}";
            textBoxResultado.Text += $"Calcula a posição do meio do array (left+right)/2 {Environment.NewLine}";
            textBoxResultado.Text += $"Verifica se o elemento está na posição do meio {Environment.NewLine}";
            textBoxResultado.Text += $"Se o elemento é maior que a posição do meio left = md+1{Environment.NewLine}";
            textBoxResultado.Text += $"Se o elemento é menor que a posição do meio right = md-1{Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text = resultado;
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }
    }

    private void buttonLeftAndRightBoundary_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);
            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            int left = 0, right = input.Length - 1;

            while (left <= right)
            {
                textBoxResultado.Text += $"Left está no índice {left}, Right está no índice {right} {Environment.NewLine}";
                textBoxResultado.Text += $"\t if LeftContidion(left) left-- {Environment.NewLine}";
                textBoxResultado.Text += $"\t if RightContidion(right) right-- {Environment.NewLine}";
                textBoxResultado.Text += $"\t if BothRightLeftContidion(right,left) {Environment.NewLine}";
                if (input[left] % 2 == 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonTwoSum_Click(object sender, EventArgs e)
    {   
        try
        {
            int target = int.Parse(textBoxTwoSum.Text);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            Dictionary<int, int> resultado =  LeftRightBoundary.TwoSum(input, target);

            GeneralService.ClearTexttBox(textBoxResultado);

            textBoxResultado.Text = $"utilizar 2 ponteiros inícioe  fim da lista{Environment.NewLine}";
            textBoxResultado.Text += $"se o pointeiro inicial + ponteiro final é igual ao target, sair{Environment.NewLine}";
            textBoxResultado.Text += $"se o pointeiro inicial + ponteiro < target move o ponteiro esquerdo +1{Environment.NewLine}";
            textBoxResultado.Text += $"se o pointeiro inicial + ponteiro > target move o ponteiro direitop para dentro do array{Environment.NewLine}{Environment.NewLine}";

            if (resultado.Count() == 0)
            {
                textBoxResultado.Text += $"Nehum par de valor que some {target}";                
            }
            else
            {
                string texto = "";
                foreach (var item in resultado)
                {
                    texto += $"indíce {item.Key}=> {item.Value}, ";
                }

                texto += $" é a soma de {target}";

                textBoxResultado.Text += texto;
            }
        }

        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }
    }
}

