using AlgoritmosProject.Services;
using AlgoritmosProject.Services.Tree;
using System;
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

            int result = InPlaceService.FindFirstDuplicate(input);

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

            int[] result = InPlaceService.RemoveDuplicates(input);

            textBoxResultado.Text += $"A única forma de eliminar o elemento da sequência é utilizand List<T>, hashSet, Linq(distinct) {Environment.NewLine}";
            textBoxResultado.Text += $"Utilizando uma estrutura de dados teremos: {string.Join(",", result)}{Environment.NewLine}{Environment.NewLine}";

            int newLength = InPlaceService.RemoveDuplicatesNewLength(input);
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

            if (input.Length > 0)
            {
                ListNode? head = GeneralService.CriarListNodeFromArray(input);

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
            else
            {
                textBoxResultado.Text += $"Nenhum valor encontrado para processar";
            }
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
            int target = int.Parse(textBoxTwoFourSum.Text);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            Dictionary<int, int> resultado = LeftRightBoundary.TwoSum(input, target);

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

    private void buttonFourSum_Click(object sender, EventArgs e)
    {


        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);
            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            var eresult = LeftRightBoundary.FourSum(input, int.Parse(textBoxTwoFourSum.Text));

            textBoxResultado.Text = $"{string.Join(",", eresult)}";

        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonSort3Colors_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            textBoxResultado.Text += $"Lista Original {string.Join(",", input)}{Environment.NewLine}{Environment.NewLine}";

            SlideWindowsService.Sort3ColorsInPlace(input);

            textBoxResultado.Text += $"Utiliza 3 ponteiros, um para o índice do vermelho, um para o índice do branco e um para o índice do azul{Environment.NewLine}";
            textBoxResultado.Text += $"Se o índice branco está na posição 1, então troca com indice da cor vermelha{Environment.NewLine}";
            textBoxResultado.Text += $"Se o índice branco está na posição 2, então troca com indice da azul{Environment.NewLine}{Environment.NewLine}";

            textBoxResultado.Text += $"Lista Final {string.Join(",", input)}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonLongestSubstBySUm_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            int targetSum = int.Parse(textBoxTargetSumLongestSubArray.Text);

            int[] result = SlideWindowsService.FindLongestSubstringBySum(input, targetSum);

            string resultadoConfigurado = result.Count() > 1 ? (result[0] + 1).ToString() + " a " + (result[1] + 1).ToString() : "nenhum";

            textBoxResultado.Text += $"Utiliza 2 ponteiros, para o slide window, um ponteiro para o início e outro para o fim{Environment.NewLine}";
            textBoxResultado.Text += $"Incrementa o ponteiro da direita ao mesmo que acumula a soma do índice desse ponteiro{Environment.NewLine}";
            textBoxResultado.Text += $"Quando a soma é igual ao target e a janela é maior que a janela atual, atualiza o array de retorno{Environment.NewLine}";
            textBoxResultado.Text += $"Continua no loop até a soma ser maior que o target{Environment.NewLine}";
            textBoxResultado.Text += $"\t subtrai da soma todas os índices do ponteiro da esquerda incrementando esse pointeiro {Environment.NewLine}";
            textBoxResultado.Text += $"\t enquanto a soma é maior que o target e o ponteiro da esquerda é menor que o da direita{Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text += $"A maior substring de {string.Join(",", input)} que resulta em {targetSum} é {resultadoConfigurado}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonSmalestWindowBySum_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);
            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            int targetSum = int.Parse(textBoxTargetSumLongestSubArray.Text);

            int[] result = SlideWindowsService.FindSmalestSubstringBySum(input, targetSum);

            string resultadoConfigurado = result.Count() > 1 ? (result[0] + 1).ToString() + " a " + (result[1] + 1).ToString() : "nenhum";

            textBoxResultado.Text += $"Utiliza o mesmo algoritmo de FindLongestSubstringBySum {Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text += $"\t Só vai funcionar se o input não estiver ordenado {Environment.NewLine}{Environment.NewLine}";

            textBoxResultado.Text += $"Utiliza 2 ponteiros, para o slide window, um ponteiro para o início e outro para o fim{Environment.NewLine}";
            textBoxResultado.Text += $"Incrementa o ponteiro da direita ao mesmo que acumula a soma do índice desse ponteiro{Environment.NewLine}";
            textBoxResultado.Text += $"Quando a soma é igual ao target e a janela é menor que a janela atual, atualiza o array de retorno{Environment.NewLine}";
            textBoxResultado.Text += $"Continua no loop até a soma ser maior que o target{Environment.NewLine}";
            textBoxResultado.Text += $"\t subtrai da soma todas os índices do ponteiro da esquerda incrementando esse pointeiro {Environment.NewLine}";
            textBoxResultado.Text += $"\t enquanto a soma é maior que o target e o ponteiro da esquerda é menor que o da direita{Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text += $"A menor substring de {string.Join(",", input)} que resulta em {targetSum} é {resultadoConfigurado}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonBoyerMooring_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            int majority = InPlaceService.FindMajorityByBoyerMoore(input);

            textBoxResultado.Text += $"A sequencia do imput deve estar ordenada? {Environment.NewLine}";
            textBoxResultado.Text += $"Seleciona 1 candidato, no algoritmo o 1º elemento{Environment.NewLine}";
            textBoxResultado.Text += $"Para cada interação, verifica a qtd de ocorrências desse candidato{Environment.NewLine}";
            textBoxResultado.Text += $"\t se o candidato é o mesmo incrementa um contador, senão decrementa o contador{Environment.NewLine}";
            textBoxResultado.Text += $"No final verifica se o contador é >- n/2{Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text += $"the majority element among the given elements is {majority}";

        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonSerializarTree_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            if (input.Length == 0)
            {
                textBoxResultado.Text = $" Nenhuma informação para processar{Environment.NewLine}";
            }
            else
            {


                MyTreeNode myTreeNode = TreeService.InsertFromArray(input);

                string arvoreSerializada = new TreeService().SerializarTree(myTreeNode);

                textBoxResultado.Text += $" TreeService Insert ... {Environment.NewLine}";

                TreeService service = new TreeService();
                service.PreOrderTraversal(myTreeNode);

                textBoxResultado.Text += $"PreOrderTraversal {service.SbSerializacao.ToString()}{Environment.NewLine}";

                textBoxResultado.Text += $" Árvore Serializada {arvoreSerializada} ... {Environment.NewLine}";
            }


        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            MyTreeNode myTreeNode = TreeService.InsertFromArray(input);

            var result = TreeService.PreOrderTraversalIteratively(myTreeNode);

            textBoxResultado.Text += $"Pre Order Traversal Iteratively {Environment.NewLine}";
            textBoxResultado.Text += $"Adiciona o root em uma stack {Environment.NewLine}";
            textBoxResultado.Text += $"faz push na stack e adiciona em uma lista o valor {Environment.NewLine}";
            textBoxResultado.Text += $"se houver lado direito adiciona{Environment.NewLine}";
            textBoxResultado.Text += $"se houver lado esquerdo adiciona{Environment.NewLine}";
            textBoxResultado.Text += $"\t adiciona o lado esquerdo por último para fazer push antes do lado direito (pre order){Environment.NewLine}{Environment.NewLine}";

            string treeSerialized = new TreeService().SerializarTree(myTreeNode);

            textBoxResultado.Text += $"{treeSerialized}{Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }
    }

    private void buttonDeleteNode_Click(object sender, EventArgs e)
    {

        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            MyTreeNode myTreeNode = TreeService.InsertFromArray(input);

            string treeSerialized = new TreeService().SerializarTree(myTreeNode);

            textBoxResultado.Text += $"Tree Before {treeSerialized} {Environment.NewLine}";

            MyTreeNode? treeNodeWithNodeDeleted = TreeService.Delete(myTreeNode, int.Parse(textBoxNodeToDelete.Text));

            treeSerialized = new TreeService().SerializarTree(treeNodeWithNodeDeleted);

            textBoxResultado.Text += $"Tree After {treeSerialized} {Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }
    BSTIterator bSTIterator = null;
    private void buttonIteratorTree_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            MyTreeNode myTreeNode = TreeService.InsertFromArray(input);

            bSTIterator = new BSTIterator(myTreeNode);

            textBoxResultado.Text += $"BSTIterator foi instanciado {Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonIteratorNext_Click(object sender, EventArgs e)
    {
        try
        {
            

            if (bSTIterator == null)
            {
                GeneralService.ClearTexttBox(textBoxResultado);
                textBoxResultado.Text += $"BSTIterator is null {Environment.NewLine}";

            }
            else
            {
                textBoxResultado.Text += $"Tree Element: {bSTIterator.Next()} {Environment.NewLine}";
            }

           
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

        
    }
}

