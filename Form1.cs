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

            int[] input = textBoxInput.Text.Split(',').Select(s=> int.Parse(s)).ToArray();

            int result = FirstDuplicateService.FindFirstDuplicate(input);

            textBoxResultado.Text = $"Array deve sempre começar com 1; array deve estar em sequencia {Environment.NewLine}";
            textBoxResultado.Text += $"Para cada valor faz -1; {Environment.NewLine} esse resultado é algum índice {Environment.NewLine}";
            textBoxResultado.Text += $"Verifica se o valor desse índice é negativo; {Environment.NewLine} ";
            textBoxResultado.Text+= $"Se for negativo o índice já foi processado, retornar o valor; {Environment.NewLine} ";
            
            textBoxResultado.Text += string.Join(",", result);

        } catch (Exception ex) {
            textBoxResultado.Text = ex.Message;
        }
        
    }

    private void ClearTxtBoxResultado()
    {
        textBoxResultado.Text = string.Empty;
    }
}
