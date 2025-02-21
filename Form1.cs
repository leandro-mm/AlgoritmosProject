using AlgoritmosProject.Services;
using System.Runtime.Intrinsics.X86;

namespace AlgoritmosProject;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnFirstDuplicate_Click(object sender, EventArgs e)
    {
        try
        {
            ClearTxtBoxResultado();

            int[] input = GetInput();

            int result = FirstDuplicateService.FindFirstDuplicate(input);

            textBoxResultado.Text = $"Array deve sempre começar com 1; array deve estar em sequencia {Environment.NewLine}";
            textBoxResultado.Text += $"Para cada valor faz -1; {Environment.NewLine} esse resultado é algum índice {Environment.NewLine}";
            textBoxResultado.Text += $"Verifica se o valor desse índice é negativo; {Environment.NewLine} ";
            textBoxResultado.Text += $"Se for negativo o índice já foi processado, retornar o valor; {Environment.NewLine} ";

            textBoxResultado.Text += string.Join(",", result);

        }
        catch (Exception ex)
        {
            textBoxResultado.Text = ex.Message;
        }

    }

    private int[] GetInput()
    {
        return textBoxInput.Text.Split(',').Select(s => int.Parse(s)).ToArray();
    }

    private void ClearTxtBoxResultado()
    {
        textBoxResultado.Text = string.Empty;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            ClearTxtBoxResultado();
            int[] result = RemoveDuplicateService.RemoveDuplicates(GetInput());

            int newIndex = RemoveDuplicateService.RemoveDuplicatesNewLength(GetInput());

            textBoxResultado.Text += string.Join(",", result);
            textBoxResultado.Text += Environment.NewLine;
            textBoxResultado.Text += newIndex;
        }
        catch (Exception ex)
        {

            textBoxResultado.Text = ex.Message;
        }

    }

    private void button2_Click(object sender, EventArgs e)
    {
        try
        {
            ClearTxtBoxResultado();
            int[] input = GetInput();

            ListNode? head = null;// new ListNode(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if(head == null)
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

                    if(currentNode is not null)
                    {
                        ListNode node3 = new ListNode(input[i]);
                        currentNode.Next = node3;
                    }
                   
                }
            }

            ListNode resultNode = RemoveNodeService.RemoveNthNodeFromList(head, int.Parse(textBoxNth.Text));
            
            string texto = resultNode.Value.ToString()+",";

            while (resultNode.Next is not null)
            {
                texto += resultNode.Next.Value.ToString() + ",";
                resultNode = resultNode.Next;                
            }

            textBoxResultado.Text = texto;

        }
        catch (Exception ex)
        {

            textBoxResultado.Text = ex.Message;
        }
       
       
    }
}
