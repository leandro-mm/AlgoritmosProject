using AlgoritmosProject.Services;
using AlgoritmosProject.Services.Graph;
using AlgoritmosProject.Services.Graph.Course;
using AlgoritmosProject.Services.Tree;
using System.Text;

namespace AlgoritmosProject;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        GeneralService.ClearTexttBox(textBoxResultado);
        GeneralService.SetInputBoxDefaultValues(textBoxInput, "1,2,3,4,5");
    }

    private string PrintListData(int[] array)
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
    private string PrintListData(IList<List<int>> data)
    {
        StringBuilder stringBuilder = new();

        foreach (var item in data)
        {
            stringBuilder.Append("[").Append(string.Join(",", item)).Append("],");
        }

        return stringBuilder.ToString();
    }

    private string PrintListData(IList<int> data)
    {
        StringBuilder stringBuilder = new();

        foreach (var item in data)
        {
            stringBuilder.Append("[").Append(string.Join(",", item)).Append("],");
        }

        return stringBuilder.ToString();
    }

    private void btnFirstDuplicate_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            int result = InPlaceService.FindFirstDuplicate(input);

            textBoxResultado.Text = $"Explica��o do algoritmo{Environment.NewLine}";
            textBoxResultado.Text += $"O Array deve sempre come�ar com 1 {Environment.NewLine}";
            textBoxResultado.Text += $"O array deve estar em sequencia {Environment.NewLine}";
            textBoxResultado.Text += $"O elemento repetido aparecer� 2 vezes, exemplo 1,2,2,3 {Environment.NewLine}";
            textBoxResultado.Text += $"Para cada elemento diminui 1, esse resultado ser� um �ndice, o valor desse �ndice � transformado em negativo; {Environment.NewLine}";
            textBoxResultado.Text += $"Para o pr�ximo elemento faz elemento -1, verifica se esse �ndice � um valor negativo{Environment.NewLine} ";
            textBoxResultado.Text += $"Sendo um valor negativo ent�o encontrou o 1�elemento repetido{Environment.NewLine}{Environment.NewLine} ";
            textBoxResultado.Text += result > 0 ? $"O elemento repetido � {result}" : "N�o existe elementos repetidos na sequ�ncia";

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

            textBoxResultado.Text += $"A �nica forma de eliminar o elemento da sequ�ncia � utilizand List<T>, hashSet, Linq(distinct) {Environment.NewLine}";
            textBoxResultado.Text += $"Utilizando uma estrutura de dados teremos: {string.Join(",", result)}{Environment.NewLine}{Environment.NewLine}";

            int newLength = InPlaceService.RemoveDuplicatesNewLength(input);
            textBoxResultado.Text += $"Outra maneira � retornar o novo tamanho da sequencia {Environment.NewLine}";
            textBoxResultado.Text += $"Percorre a sequencia e contabiliza todos os que forems diferentes entre o atual e anterior{Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text += $"Sequencia anterior {input.Length} elementos, nova sequ�ncia {newLength} elementos"; ;
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
                textBoxResultado.Text += $"Percorre slow.next at� fast.next for null {Environment.NewLine}";
                textBoxResultado.Text += $"Pula o elemento a ser removido slow.next = slow.next.next {Environment.NewLine}";
                textBoxResultado.Text += $"Retorna dymmy.nex pois slow � uma refer�ncia para dymmy Pula o elemento a ser removido slow.next = slow.next.next {Environment.NewLine}{Environment.NewLine}";
                textBoxResultado.Text += $"O resultado para remover o {elementoAserRemovido}� elemento da lista {string.Join(",", valoresListNode)} � {string.Join(",", GeneralService.ObterValoresListNode(resultNode))}";
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

            string resultado = $"Elemento {elementoToFind} n�o est� na lista";

            int left = 0, right = input.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (elementoToFind == input[mid])
                {
                    resultado = $"Elemento {elementoToFind} est� na lista";
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
            textBoxResultado.Text += $"Calcula a posi��o do meio do array (left+right)/2 {Environment.NewLine}";
            textBoxResultado.Text += $"Verifica se o elemento est� na posi��o do meio {Environment.NewLine}";
            textBoxResultado.Text += $"Se o elemento � maior que a posi��o do meio left = md+1{Environment.NewLine}";
            textBoxResultado.Text += $"Se o elemento � menor que a posi��o do meio right = md-1{Environment.NewLine}{Environment.NewLine}";
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
                textBoxResultado.Text += $"Left est� no �ndice {left}, Right est� no �ndice {right} {Environment.NewLine}";
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

            textBoxResultado.Text = $"utilizar 2 ponteiros in�cioe  fim da lista{Environment.NewLine}";
            textBoxResultado.Text += $"se o pointeiro inicial + ponteiro final � igual ao target, sair{Environment.NewLine}";
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
                    texto += $"ind�ce {item.Key}=> {item.Value}, ";
                }

                texto += $" � a soma de {target}";

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

            textBoxResultado.Text += $"Utiliza 3 ponteiros, um para o �ndice do vermelho, um para o �ndice do branco e um para o �ndice do azul{Environment.NewLine}";
            textBoxResultado.Text += $"Se o �ndice branco est� na posi��o 1, ent�o troca com indice da cor vermelha{Environment.NewLine}";
            textBoxResultado.Text += $"Se o �ndice branco est� na posi��o 2, ent�o troca com indice da azul{Environment.NewLine}{Environment.NewLine}";

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

            textBoxResultado.Text += $"Utiliza 2 ponteiros, para o slide window, um ponteiro para o in�cio e outro para o fim{Environment.NewLine}";
            textBoxResultado.Text += $"Incrementa o ponteiro da direita ao mesmo que acumula a soma do �ndice desse ponteiro{Environment.NewLine}";
            textBoxResultado.Text += $"Quando a soma � igual ao target e a janela � maior que a janela atual, atualiza o array de retorno{Environment.NewLine}";
            textBoxResultado.Text += $"Continua no loop at� a soma ser maior que o target{Environment.NewLine}";
            textBoxResultado.Text += $"\t subtrai da soma todas os �ndices do ponteiro da esquerda incrementando esse pointeiro {Environment.NewLine}";
            textBoxResultado.Text += $"\t enquanto a soma � maior que o target e o ponteiro da esquerda � menor que o da direita{Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text += $"A maior substring de {string.Join(",", input)} que resulta em {targetSum} � {resultadoConfigurado}";
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
            textBoxResultado.Text += $"\t S� vai funcionar se o input n�o estiver ordenado {Environment.NewLine}{Environment.NewLine}";

            textBoxResultado.Text += $"Utiliza 2 ponteiros, para o slide window, um ponteiro para o in�cio e outro para o fim{Environment.NewLine}";
            textBoxResultado.Text += $"Incrementa o ponteiro da direita ao mesmo que acumula a soma do �ndice desse ponteiro{Environment.NewLine}";
            textBoxResultado.Text += $"Quando a soma � igual ao target e a janela � menor que a janela atual, atualiza o array de retorno{Environment.NewLine}";
            textBoxResultado.Text += $"Continua no loop at� a soma ser maior que o target{Environment.NewLine}";
            textBoxResultado.Text += $"\t subtrai da soma todas os �ndices do ponteiro da esquerda incrementando esse pointeiro {Environment.NewLine}";
            textBoxResultado.Text += $"\t enquanto a soma � maior que o target e o ponteiro da esquerda � menor que o da direita{Environment.NewLine}{Environment.NewLine}";
            textBoxResultado.Text += $"A menor substring de {string.Join(",", input)} que resulta em {targetSum} � {resultadoConfigurado}";
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
            textBoxResultado.Text += $"Seleciona 1 candidato, no algoritmo o 1� elemento{Environment.NewLine}";
            textBoxResultado.Text += $"Para cada intera��o, verifica a qtd de ocorr�ncias desse candidato{Environment.NewLine}";
            textBoxResultado.Text += $"\t se o candidato � o mesmo incrementa um contador, sen�o decrementa o contador{Environment.NewLine}";
            textBoxResultado.Text += $"No final verifica se o contador � >- n/2{Environment.NewLine}{Environment.NewLine}";
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
                textBoxResultado.Text = $" Nenhuma informa��o para processar{Environment.NewLine}";
            }
            else
            {


                MyTreeNode myTreeNode = TreeService.BST_FromArray(input);

                string arvoreSerializada = new TreeService().TreePreOrderSerializar(myTreeNode);

                textBoxResultado.Text += $" TreeService Insert ... {Environment.NewLine}";

                TreeService service = new TreeService();
                service.PreOrderTraversalByFunction(myTreeNode);

                textBoxResultado.Text += $"PreOrderTraversal {service.SbSerializacao.ToString()}{Environment.NewLine}";

                textBoxResultado.Text += $" �rvore Serializada {arvoreSerializada} ... {Environment.NewLine}";
            }


        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }
    }

    private void buttonTreePreORderTravelrsal_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            MyTreeNode myTreeNode = TreeService.BST_FromArray(input);

            IList<int> listNodes = TreeService.PreOrderTraversalIteratively(myTreeNode);

            textBoxResultado.Text += $"Pre Order Traversal Iteratively {Environment.NewLine}";
            textBoxResultado.Text += $"Utilizar stack {Environment.NewLine}";
            textBoxResultado.Text += $"push(root){Environment.NewLine}";
            textBoxResultado.Text += $"pop(root) {Environment.NewLine}";
            textBoxResultado.Text += $"\t adiciona em uma lista o valor {Environment.NewLine}";
            textBoxResultado.Text += $"se houver lado direito faz push{Environment.NewLine}";
            textBoxResultado.Text += $"se houver lado esquerdo faz push{Environment.NewLine}";
            textBoxResultado.Text += $"\t adiciona o lado esquerdo por �ltimo para fazer pop antes do lado direito (pre order){Environment.NewLine}{Environment.NewLine}";

            string treeSerialized = new TreeService().TreePreOrderSerializar(myTreeNode);

            textBoxResultado.Text += $"Tree Pre Order Serializar {treeSerialized}{Environment.NewLine}";
            textBoxResultado.Text += $"Pre Order Traversal Iteratively {string.Join(",", listNodes)}{Environment.NewLine}";
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

            MyTreeNode myTreeNode = TreeService.BST_FromArray(input);

            string treeSerialized = new TreeService().TreePreOrderSerializar(myTreeNode);

            textBoxResultado.Text += $"Tree Before {treeSerialized} {Environment.NewLine}";

            MyTreeNode? treeNodeWithNodeDeleted = TreeService.Delete(myTreeNode, int.Parse(textBoxNodeToDelete.Text));

            treeSerialized = new TreeService().TreePreOrderSerializar(treeNodeWithNodeDeleted);

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

            MyTreeNode myTreeNode = TreeService.BST_FromArray(input);

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

    private void buttonTreeInOrderTraversal_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            MyTreeNode myTreeNode = TreeService.BST_FromArray(input);

            IList<int> listResult = TreeService.InOrderTraversalIteratively(myTreeNode);

            textBoxResultado.Text += $"In Order Traversal Iteratively: {string.Join(",", listResult)}{Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonNroCombinacoes_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int qtd = int.Parse(textBoxQtdCombinacoes.Text);

            int resultado = GeneralService.NumTrees(qtd);

            textBoxResultado.Text += $"Combinacoes {resultado} {Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonNroCombII_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int qtd = int.Parse(textBoxQtdCombinacoes.Text);

            IList<MyTreeNode> resultado = GeneralService.NumUniqueBST2(qtd);

            string values = "";
            foreach (var item in resultado)
            {
                values += item.Value.ToString() + ",";
            }

            textBoxResultado.Text += $"{resultado.Count} combinacoes: {values} {Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }
    }

    private void buttonAllPathSums_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);


            textBoxResultado.Text += $"Considerando a seguinte Binary Tree: {Environment.NewLine}";
            textBoxResultado.Text += $"       5 {Environment.NewLine}";
            textBoxResultado.Text += $"   /      \\ {Environment.NewLine}";
            textBoxResultado.Text += $"  4                  8 {Environment.NewLine}";
            textBoxResultado.Text += $"   /  \\           /  \\ {Environment.NewLine}";
            textBoxResultado.Text += $"11    null        13   10 {Environment.NewLine} ";
            textBoxResultado.Text += $"/  \\             /   \\ {Environment.NewLine} ";
            textBoxResultado.Text += $"7  2             null    {Environment.NewLine} ";
            textBoxResultado.Text += $"                      /   \\     {Environment.NewLine}";
            textBoxResultado.Text += $"                      5     1 {Environment.NewLine}{Environment.NewLine}";


            MyTreeNode root = new MyTreeNode(5);
            root.Left = new MyTreeNode(4);
            root.Left.Right = null;
            root.Left.Left = new MyTreeNode(11);
            root.Left.Left.Left = new MyTreeNode(7);
            root.Left.Left.Right = new MyTreeNode(2);
            root.Right = new MyTreeNode(8);
            root.Right.Left = new MyTreeNode(13);
            root.Right.Right = new MyTreeNode(4);
            root.Right.Right.Right = new MyTreeNode(1);
            root.Right.Right.Left = new MyTreeNode(5);

            IList<IList<int>> result = TreeService.AllPathSum(root, int.Parse(textBoxTargetSum.Text));

            if (result.Count > 0)
            {
                StringBuilder stringBuilder = new();
                foreach (var item in result)
                {
                    stringBuilder.Append("[");
                    stringBuilder.Append(string.Join(",", item));
                    stringBuilder.Append("]");
                    stringBuilder.Append(", ");
                }

                textBoxResultado.Text += $"Os seguintes caminhos somam {textBoxTargetSum.Text}: {stringBuilder}{Environment.NewLine}";
            }
            else
            {
                textBoxResultado.Text += $"Nenhum caminho encontrado para a soma de {textBoxTargetSum.Text}: {Environment.NewLine}";
            }


        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonLevelOrderTraversal_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            textBoxResultado.Text += $"Considerando a seguinte Binary Tree: {Environment.NewLine}";
            textBoxResultado.Text += $"   3 {Environment.NewLine}";
            textBoxResultado.Text += $" /  \\ {Environment.NewLine}";
            textBoxResultado.Text += $"9   20 {Environment.NewLine}";
            textBoxResultado.Text += $"     /  \\ {Environment.NewLine}";
            textBoxResultado.Text += $"    15   7 {Environment.NewLine} {Environment.NewLine}";

            IList<List<int>> listResult = TreeService.LevelOrderTraversal(TreeService.ObterTreeLevelOrderTraversal());

            string resultStreing = PrintListData(listResult);

            textBoxResultado.Text += $"Level Order Traversal: {resultStreing}{Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }
    }

    private void buttonLevelOrderTraversal2_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            textBoxResultado.Text += $"Considerando a seguinte Binary Tree: {Environment.NewLine}";
            textBoxResultado.Text += $"   3 {Environment.NewLine}";
            textBoxResultado.Text += $" /  \\ {Environment.NewLine}";
            textBoxResultado.Text += $"9   20 {Environment.NewLine}";
            textBoxResultado.Text += $"     /  \\ {Environment.NewLine}";
            textBoxResultado.Text += $"    15   7 {Environment.NewLine} {Environment.NewLine}";

            IList<List<int>> listResult = TreeService.LevelOrderTraversalII(TreeService.ObterTreeLevelOrderTraversal());

            string resultStreing = PrintListData(listResult);

            textBoxResultado.Text += $"Level Order Traversal: {resultStreing}{Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }
    }

    private void buttonRightSideView_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            MyTreeNode tree = TreeService.ObterTreeLevelRightSideView();

            IList<List<int>> levelORderTraversal = TreeService.LevelOrderTraversal(tree);

            textBoxResultado.Text += $"Level Order Traversal {PrintListData(levelORderTraversal)} {Environment.NewLine}";

            IList<int> rightSideTree = TreeService.FindRighSideViewFromTree(tree);

            textBoxResultado.Text += $"Righ Side View {string.Join(",", rightSideTree)} {Environment.NewLine}";


            //--outra tree
            tree = TreeService.ObterTreeLevelRightSideViewII();

            levelORderTraversal = TreeService.LevelOrderTraversal(tree);

            textBoxResultado.Text += $"Level Order Traversal {PrintListData(levelORderTraversal)} {Environment.NewLine}";

            rightSideTree = TreeService.FindRighSideViewFromTree(tree);

            textBoxResultado.Text += $"Righ Side View {string.Join(",", rightSideTree)} {Environment.NewLine}";

        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }



    }

    private void buttonAggregateNumsOnPath_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            IList<int> result = TreeService.AgregateRootToPath(TreeService.BST_FromArray(input));

            string stringResult = PrintListData(result);
            textBoxResultado.Text += $"Using Input {Environment.NewLine}";
            textBoxResultado.Text += $"Agregat Root To Path {stringResult}{Environment.NewLine}";
            textBoxResultado.Text += $"Sum Root to Leaves {result.Sum():#,##0}{Environment.NewLine}{Environment.NewLine}";

            textBoxResultado.Text += $"Tree Level Right Side View {Environment.NewLine}";
            MyTreeNode tree = TreeService.ObterTreeLevelRightSideView();

            result = TreeService.AgregateRootToPath(tree);
            stringResult = PrintListData(result);
            textBoxResultado.Text += $"Agregat Root To Path {stringResult}{Environment.NewLine}";
            textBoxResultado.Text += $"Sum Root to Leaves {result.Sum():#,##0}{Environment.NewLine}{Environment.NewLine}";


            textBoxResultado.Text += $"Tree Level Right Side View II{Environment.NewLine}";
            tree = TreeService.ObterTreeLevelRightSideViewII();

            result = TreeService.AgregateRootToPath(tree);
            stringResult = PrintListData(result);
            textBoxResultado.Text += $"Agregat Root To Path {stringResult}{Environment.NewLine}";
            textBoxResultado.Text += $"Sum Root to Leaves {result.Sum():#,##0}{Environment.NewLine}{Environment.NewLine}";

        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonLevelOrderZigZag_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            textBoxResultado.Text += $"Considerando a seguinte Binary Tree: {Environment.NewLine}";
            textBoxResultado.Text += $"      3 {Environment.NewLine}";
            textBoxResultado.Text += $"    /  \\ {Environment.NewLine}";
            textBoxResultado.Text += $"   9   20 {Environment.NewLine}";
            textBoxResultado.Text += $" /  \\     /  \\ {Environment.NewLine}";
            textBoxResultado.Text += $"2   5    15   7 {Environment.NewLine} ";
            textBoxResultado.Text += $"               /      \\ {Environment.NewLine} ";
            textBoxResultado.Text += $"              55        100 {Environment.NewLine} {Environment.NewLine}";

            IList<List<int>> listResult = TreeService.ZigZagLevelOrderTraversal(TreeService.ObterTreeLevelOrderTraversalII());

            string resultStreing = PrintListData(listResult);

            textBoxResultado.Text += $"Level Order Traversal: {resultStreing}{Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }
    }

    private void buttonRouseHobber_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            textBoxResultado.Text += $"Considerando a seguinte Binary Tree: {Environment.NewLine}";
            textBoxResultado.Text += $"      3 {Environment.NewLine}";
            textBoxResultado.Text += $"    /  \\ {Environment.NewLine}";
            textBoxResultado.Text += $"   9   20 {Environment.NewLine}";
            textBoxResultado.Text += $" /  \\     /  \\ {Environment.NewLine}";
            textBoxResultado.Text += $"2   5    15   7 {Environment.NewLine} ";
            textBoxResultado.Text += $"               /      \\ {Environment.NewLine} ";
            textBoxResultado.Text += $"              55        100 {Environment.NewLine} {Environment.NewLine}";

            int listResult = TreeService.HouseRobeerIII(TreeService.ObterTreeLevelOrderTraversalII());

            textBoxResultado.Text += $"House Robeer III: {listResult}{Environment.NewLine}";

        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonLCA_BST_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            MyTreeNode root = TreeService.BST_FromArray(input);

            textBoxResultado.Text += $"Par�metros: TreeNode A, TreeNode B {Environment.NewLine}";
            textBoxResultado.Text += $"Fazer In Order do root{Environment.NewLine}";
            textBoxResultado.Text += $"Fazer Post Order do root{Environment.NewLine}";
            textBoxResultado.Text += $"Verificar o �ndice de P e Q na in order list{Environment.NewLine}";
            textBoxResultado.Text += $"Obter um range de In Order a partir de P a Q, ou Q a P{Environment.NewLine}";
            textBoxResultado.Text += $"Encontrar o maior �ndice do range{Environment.NewLine}";
            textBoxResultado.Text += $"\t utiliza a Post Order List {Environment.NewLine}";
            textBoxResultado.Text += $"Encontrar o node desse �ndice na BST{Environment.NewLine}";
            textBoxResultado.Text += $"{Environment.NewLine}";
            textBoxResultado.Text += $"Falta Implementar{Environment.NewLine}";
            textBoxResultado.Text += $"{Environment.NewLine}";

            MyTreeNode? result = TreeService.LCA_BST(root, new MyTreeNode(int.Parse(textBoxLCAnode1.Text)), new MyTreeNode(int.Parse(textBoxLCAnode2.Text)));

            textBoxResultado.Text += $"LCA de {textBoxLCAnode1.Text} e {textBoxLCAnode2.Text} � {result?.Value} {Environment.NewLine}";

        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonSucessor_InOrder_BST_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            MyTreeNode myTreeNode = TreeService.BST_FromArray(input);

            IList<int> listResult = TreeService.InOrderTraversalIteratively(myTreeNode);

            int index = listResult.IndexOf(int.Parse(textBoxSucessor.Text));

            string result = "";

            if (index >= 0)
            {
                if (index + 1 > listResult.Count())
                {
                    result = $"error index {index + 1} > total elements {listResult.Count()}";
                }
                else
                {
                    result = $"{listResult[index + 1]}";
                }
            }
            else
            {
                result = $"error index {index} does not exist";
            }

            textBoxResultado.Text += $"In Order sucessor of {textBoxSucessor.Text} of a BST {string.Join(",", listResult)} is: {result}{Environment.NewLine}";


        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }



    }

    private void buttonLCA_BT_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            MyTreeNode root = TreeService.GetStandardtBinaryTree();

            MyTreeNode? result = TreeService.LCA_BT(
                                    root,
                                    new MyTreeNode(int.Parse(textBoxLCAnode1.Text)),
                                    new MyTreeNode(int.Parse(textBoxLCAnode2.Text)));

            textBoxResultado.Text += $"LCA de uma BT de {textBoxLCAnode1.Text} e {textBoxLCAnode2.Text}" +
                $" � {result?.Value} {Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }



    }

    private void buttonLongestConsecSeqBT_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            MyTreeNode myTreeNode = TreeService.BST_FromArray(input);

            int result = TreeService.LongestConsecutiveSequenceBT(myTreeNode);

            IList<int> listResult = TreeService.InOrderTraversalIteratively(myTreeNode);

            textBoxResultado.Text += $"Longest Consecutive Sequence BT {string.Join(",", listResult)} is {result} {Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonValidPreOrderBST_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            bool validPreOrder = TreeService.IsValidPreOrderBST(input);

            textBoxResultado.Text += $"Is Valid Pre Order BST from Array {string.Join(",", input)}: {validPreOrder} {Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonBT_UpSideDown_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int[] input = GeneralService.GetInputFromTextBox(textBoxInput);

            //MyTreeNode root = TreeService.GetStandardtBinaryTree();

            MyTreeNode myTreeNode = TreeService.BST_FromArray(input);

            MyTreeNode? upSideDownTree = TreeService.UpSideDownTree(myTreeNode);

            textBoxResultado.Text += $"UpSide Down Tree from " +
                $"{string.Join(",", TreeService.InOrderTraversalIteratively(myTreeNode))} is" +
                $" {string.Join(",", TreeService.InOrderTraversalIteratively(upSideDownTree))} {Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonConnectedCompUndirectedGraph_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            int numberOfNodes = 5;

            IList<List<int>> edgesList1 = new List<List<int>>
                                            {
                                                new List<int> { 0, 1 },
                                                new List<int> { 1, 2 },
                                                new List<int> { 3, 4 }
                                            };

            IList<List<int>> edgesList2 = new List<List<int>>
                                            {
                                                new List<int> { 0, 1 },
                                                new List<int> { 1, 2 },
                                                new List<int> { 2, 3 },
                                                new List<int> { 3, 4 }
                                            };

            Solution solutionInstance = new Solution();

            StringBuilder stringBuilder = new();
            foreach (var item in edgesList1)
            {
                stringBuilder.Append($"[{string.Join(",", item)}], ");
            }

            int result1 = solutionInstance.CountComponents(numberOfNodes, edgesList1);

            textBoxResultado.Text += $"Count Components edgesList1 --> {stringBuilder}: {result1} {Environment.NewLine}";


            stringBuilder = new();
            foreach (var item in edgesList2)
            {
                stringBuilder.Append($"[{string.Join(",", item)}], ");
            }

            int result2 = solutionInstance.CountComponents(numberOfNodes, edgesList2);

            textBoxResultado.Text += $"Count Components edgesList2 --> {stringBuilder}: {result2} {Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonGraph_adjascList_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            GraphII graphII = new(4);
            graphII.AddEdge(0, 1);
            graphII.AddEdge(0, 2);
            graphII.AddEdge(1, 1);
            graphII.AddEdge(1, 2);
            graphII.AddEdge(2, 1);
            graphII.AddEdge(2, 2);
            graphII.AddEdge(3, 1);
            graphII.AddEdge(3, 2);

            textBoxResultado.Text += $"Graph Print Adjacent Matrix {Environment.NewLine}";
            textBoxResultado.Text += $"{graphII.PrintAdjacentMatrix()}{Environment.NewLine}";
            textBoxResultado.Text += $"Graph BFS 1 {Environment.NewLine}";
            textBoxResultado.Text += $"{graphII.BFS(2)}{Environment.NewLine}";
            textBoxResultado.Text += $"Graph DFS 1 {Environment.NewLine}";
            textBoxResultado.Text += $"{graphII.DFS(1)}{Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }

    private void buttonCourseSchedule_Click(object sender, EventArgs e)
    {
        try
        {
            GeneralService.ClearTexttBox(textBoxResultado);

            SolutionCourse solutionCourse = new();

            int[][] array = [[1, 0]];

            bool canFinish = solutionCourse.CanFinish(2, array);

            //textBoxResultado.Text += $"Graph Course Schedule  " +
            //                            $"{Environment.NewLine}" +
            //                            $"{PrintListData(array[0])} " +                                        
            //                            $"Can Finish: {canFinish} {Environment.NewLine}{Environment.NewLine}";

            array = [[1, 0], [0, 1]];

            canFinish = solutionCourse.CanFinish(2, array);

            textBoxResultado.Text += $"Graph Course Schedule  " +
                                        $"{Environment.NewLine}" +
                                        $"{PrintListData(array[0])},{PrintListData(array[1])} " +
                                        $"Can Finish: {canFinish} {Environment.NewLine}{Environment.NewLine}";
        }
        catch (Exception ex)
        {
            GeneralService.ReportarExcecao(textBoxResultado, ex.Message);
        }

    }
}

