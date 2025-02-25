namespace AlgoritmosProject;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnFirstDuplicate = new Button();
        textBoxInput = new TextBox();
        label1 = new Label();
        textBoxResultado = new TextBox();
        btnRemoveDuplicatesInPlace = new Button();
        btnRemoveNthNode = new Button();
        textBoxNth = new TextBox();
        btnBynarySerach = new Button();
        textBoxBinarySerach = new TextBox();
        buttonLeftAndRightBoundary = new Button();
        buttonTwoSum = new Button();
        textBoxTwoFourSum = new TextBox();
        groupBox1 = new GroupBox();
        buttonFourSum = new Button();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        groupBox2 = new GroupBox();
        buttonSmalestWindowBySum = new Button();
        buttonLongestSubstBySUm = new Button();
        buttonSort3Colors = new Button();
        textBoxTargetSumLongestSubArray = new TextBox();
        label2 = new Label();
        tabPage2 = new TabPage();
        buttonBoyerMooring = new Button();
        Tree = new TabPage();
        buttonIteratorNext = new Button();
        buttonIteratorTree = new Button();
        textBoxNodeToDelete = new TextBox();
        buttonDeleteNode = new Button();
        button1 = new Button();
        label3 = new Label();
        buttonDeserializarTree = new Button();
        buttonSerializarTree = new Button();
        groupBox1.SuspendLayout();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        groupBox2.SuspendLayout();
        tabPage2.SuspendLayout();
        Tree.SuspendLayout();
        SuspendLayout();
        // 
        // btnFirstDuplicate
        // 
        btnFirstDuplicate.ImageAlign = ContentAlignment.TopCenter;
        btnFirstDuplicate.Location = new Point(20, 19);
        btnFirstDuplicate.Name = "btnFirstDuplicate";
        btnFirstDuplicate.Size = new Size(115, 23);
        btnFirstDuplicate.TabIndex = 0;
        btnFirstDuplicate.Text = "First Duplicate";
        btnFirstDuplicate.TextAlign = ContentAlignment.TopCenter;
        btnFirstDuplicate.UseVisualStyleBackColor = true;
        btnFirstDuplicate.Click += btnFirstDuplicate_Click;
        // 
        // textBoxInput
        // 
        textBoxInput.Location = new Point(12, 27);
        textBoxInput.Name = "textBoxInput";
        textBoxInput.Size = new Size(297, 23);
        textBoxInput.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(37, 15);
        label1.TabIndex = 2;
        label1.Text = "Input";
        // 
        // textBoxResultado
        // 
        textBoxResultado.Location = new Point(13, 338);
        textBoxResultado.Multiline = true;
        textBoxResultado.Name = "textBoxResultado";
        textBoxResultado.ScrollBars = ScrollBars.Both;
        textBoxResultado.Size = new Size(744, 180);
        textBoxResultado.TabIndex = 1;
        textBoxResultado.WordWrap = false;
        // 
        // btnRemoveDuplicatesInPlace
        // 
        btnRemoveDuplicatesInPlace.Location = new Point(20, 48);
        btnRemoveDuplicatesInPlace.Name = "btnRemoveDuplicatesInPlace";
        btnRemoveDuplicatesInPlace.Size = new Size(115, 39);
        btnRemoveDuplicatesInPlace.TabIndex = 3;
        btnRemoveDuplicatesInPlace.Text = "Remove Duplicates In Place";
        btnRemoveDuplicatesInPlace.TextAlign = ContentAlignment.BottomRight;
        btnRemoveDuplicatesInPlace.UseVisualStyleBackColor = true;
        btnRemoveDuplicatesInPlace.Click += btnRemoveDuplicates_Click;
        // 
        // btnRemoveNthNode
        // 
        btnRemoveNthNode.Location = new Point(9, 40);
        btnRemoveNthNode.Name = "btnRemoveNthNode";
        btnRemoveNthNode.Size = new Size(122, 23);
        btnRemoveNthNode.TabIndex = 4;
        btnRemoveNthNode.Text = "Remove N-th node from List";
        btnRemoveNthNode.UseVisualStyleBackColor = true;
        btnRemoveNthNode.Click += btnRemoveNthNodeFromList_Click;
        // 
        // textBoxNth
        // 
        textBoxNth.Location = new Point(137, 41);
        textBoxNth.Name = "textBoxNth";
        textBoxNth.PlaceholderText = "n-th";
        textBoxNth.Size = new Size(40, 23);
        textBoxNth.TabIndex = 5;
        // 
        // btnBynarySerach
        // 
        btnBynarySerach.Location = new Point(121, 22);
        btnBynarySerach.Name = "btnBynarySerach";
        btnBynarySerach.Size = new Size(101, 23);
        btnBynarySerach.TabIndex = 6;
        btnBynarySerach.Text = "Bynary Search";
        btnBynarySerach.UseVisualStyleBackColor = true;
        btnBynarySerach.Click += btnBynarySerach_Click;
        // 
        // textBoxBinarySerach
        // 
        textBoxBinarySerach.Location = new Point(121, 51);
        textBoxBinarySerach.Name = "textBoxBinarySerach";
        textBoxBinarySerach.PlaceholderText = "Elemento to Find";
        textBoxBinarySerach.Size = new Size(100, 23);
        textBoxBinarySerach.TabIndex = 7;
        // 
        // buttonLeftAndRightBoundary
        // 
        buttonLeftAndRightBoundary.Location = new Point(6, 22);
        buttonLeftAndRightBoundary.Name = "buttonLeftAndRightBoundary";
        buttonLeftAndRightBoundary.Size = new Size(109, 52);
        buttonLeftAndRightBoundary.TabIndex = 8;
        buttonLeftAndRightBoundary.Text = "Left and Right Boundary";
        buttonLeftAndRightBoundary.UseVisualStyleBackColor = true;
        buttonLeftAndRightBoundary.Click += buttonLeftAndRightBoundary_Click;
        // 
        // buttonTwoSum
        // 
        buttonTwoSum.Location = new Point(228, 22);
        buttonTwoSum.Name = "buttonTwoSum";
        buttonTwoSum.Size = new Size(100, 23);
        buttonTwoSum.TabIndex = 9;
        buttonTwoSum.Text = "Two Sum";
        buttonTwoSum.UseVisualStyleBackColor = true;
        buttonTwoSum.Click += buttonTwoSum_Click;
        // 
        // textBoxTwoFourSum
        // 
        textBoxTwoFourSum.Location = new Point(228, 51);
        textBoxTwoFourSum.Name = "textBoxTwoFourSum";
        textBoxTwoFourSum.PlaceholderText = "Two/Four Sum";
        textBoxTwoFourSum.Size = new Size(181, 23);
        textBoxTwoFourSum.TabIndex = 7;
        // 
        // groupBox1
        // 
        groupBox1.BackColor = Color.Transparent;
        groupBox1.Controls.Add(buttonFourSum);
        groupBox1.Controls.Add(buttonLeftAndRightBoundary);
        groupBox1.Controls.Add(btnBynarySerach);
        groupBox1.Controls.Add(textBoxBinarySerach);
        groupBox1.Controls.Add(textBoxTwoFourSum);
        groupBox1.Controls.Add(buttonTwoSum);
        groupBox1.Location = new Point(272, 18);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(417, 99);
        groupBox1.TabIndex = 12;
        groupBox1.TabStop = false;
        groupBox1.Text = "Left and Rigth Boudary";
        // 
        // buttonFourSum
        // 
        buttonFourSum.Location = new Point(334, 22);
        buttonFourSum.Name = "buttonFourSum";
        buttonFourSum.Size = new Size(75, 23);
        buttonFourSum.TabIndex = 13;
        buttonFourSum.Text = "Four Sum";
        buttonFourSum.UseVisualStyleBackColor = true;
        buttonFourSum.Click += buttonFourSum_Click;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(Tree);
        tabControl1.Location = new Point(13, 56);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(748, 276);
        tabControl1.TabIndex = 15;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(groupBox2);
        tabPage1.Controls.Add(label2);
        tabPage1.Controls.Add(groupBox1);
        tabPage1.Controls.Add(btnRemoveNthNode);
        tabPage1.Controls.Add(textBoxNth);
        tabPage1.Location = new Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(740, 248);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Two Pointers";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(buttonSmalestWindowBySum);
        groupBox2.Controls.Add(buttonLongestSubstBySUm);
        groupBox2.Controls.Add(buttonSort3Colors);
        groupBox2.Controls.Add(textBoxTargetSumLongestSubArray);
        groupBox2.Location = new Point(272, 126);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(417, 116);
        groupBox2.TabIndex = 14;
        groupBox2.TabStop = false;
        groupBox2.Text = "Slide Window";
        // 
        // buttonSmalestWindowBySum
        // 
        buttonSmalestWindowBySum.Location = new Point(217, 22);
        buttonSmalestWindowBySum.Name = "buttonSmalestWindowBySum";
        buttonSmalestWindowBySum.Size = new Size(75, 54);
        buttonSmalestWindowBySum.TabIndex = 6;
        buttonSmalestWindowBySum.Text = "Find Smalest Subarray By Sum";
        buttonSmalestWindowBySum.UseVisualStyleBackColor = true;
        buttonSmalestWindowBySum.Click += buttonSmalestWindowBySum_Click;
        // 
        // buttonLongestSubstBySUm
        // 
        buttonLongestSubstBySUm.Location = new Point(120, 22);
        buttonLongestSubstBySUm.Name = "buttonLongestSubstBySUm";
        buttonLongestSubstBySUm.Size = new Size(91, 54);
        buttonLongestSubstBySUm.TabIndex = 1;
        buttonLongestSubstBySUm.Text = "Find Longest Subarray By Sum";
        buttonLongestSubstBySUm.UseVisualStyleBackColor = true;
        buttonLongestSubstBySUm.Click += buttonLongestSubstBySUm_Click;
        // 
        // buttonSort3Colors
        // 
        buttonSort3Colors.Location = new Point(6, 22);
        buttonSort3Colors.Name = "buttonSort3Colors";
        buttonSort3Colors.Size = new Size(108, 54);
        buttonSort3Colors.TabIndex = 0;
        buttonSort3Colors.Text = "Sort 3 Colors";
        buttonSort3Colors.UseVisualStyleBackColor = true;
        buttonSort3Colors.Click += buttonSort3Colors_Click;
        // 
        // textBoxTargetSumLongestSubArray
        // 
        textBoxTargetSumLongestSubArray.Location = new Point(121, 77);
        textBoxTargetSumLongestSubArray.Name = "textBoxTargetSumLongestSubArray";
        textBoxTargetSumLongestSubArray.PlaceholderText = "Target Sum";
        textBoxTargetSumLongestSubArray.Size = new Size(171, 23);
        textBoxTargetSumLongestSubArray.TabIndex = 5;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label2.Location = new Point(9, 18);
        label2.Name = "label2";
        label2.Size = new Size(122, 15);
        label2.TabIndex = 13;
        label2.Text = "Slow and fast runner";
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(buttonBoyerMooring);
        tabPage2.Controls.Add(btnFirstDuplicate);
        tabPage2.Controls.Add(btnRemoveDuplicatesInPlace);
        tabPage2.Location = new Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(740, 248);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "In Place";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // buttonBoyerMooring
        // 
        buttonBoyerMooring.Location = new Point(141, 48);
        buttonBoyerMooring.Name = "buttonBoyerMooring";
        buttonBoyerMooring.Size = new Size(108, 39);
        buttonBoyerMooring.TabIndex = 4;
        buttonBoyerMooring.Text = "Boyer-Moore Majority Voting";
        buttonBoyerMooring.UseVisualStyleBackColor = true;
        buttonBoyerMooring.Click += buttonBoyerMooring_Click;
        // 
        // Tree
        // 
        Tree.Controls.Add(buttonIteratorNext);
        Tree.Controls.Add(buttonIteratorTree);
        Tree.Controls.Add(textBoxNodeToDelete);
        Tree.Controls.Add(buttonDeleteNode);
        Tree.Controls.Add(button1);
        Tree.Controls.Add(label3);
        Tree.Controls.Add(buttonDeserializarTree);
        Tree.Controls.Add(buttonSerializarTree);
        Tree.Location = new Point(4, 24);
        Tree.Name = "Tree";
        Tree.Size = new Size(740, 248);
        Tree.TabIndex = 2;
        Tree.Text = "Tree";
        Tree.UseVisualStyleBackColor = true;
        // 
        // buttonIteratorNext
        // 
        buttonIteratorNext.Location = new Point(412, 95);
        buttonIteratorNext.Name = "buttonIteratorNext";
        buttonIteratorNext.Size = new Size(75, 23);
        buttonIteratorNext.TabIndex = 7;
        buttonIteratorNext.Text = "Next";
        buttonIteratorNext.UseVisualStyleBackColor = true;
        buttonIteratorNext.Click += buttonIteratorNext_Click;
        // 
        // buttonIteratorTree
        // 
        buttonIteratorTree.Location = new Point(306, 95);
        buttonIteratorTree.Name = "buttonIteratorTree";
        buttonIteratorTree.Size = new Size(100, 23);
        buttonIteratorTree.TabIndex = 6;
        buttonIteratorTree.Text = "Iterator Tree";
        buttonIteratorTree.UseVisualStyleBackColor = true;
        buttonIteratorTree.Click += buttonIteratorTree_Click;
        // 
        // textBoxNodeToDelete
        // 
        textBoxNodeToDelete.Location = new Point(306, 57);
        textBoxNodeToDelete.Name = "textBoxNodeToDelete";
        textBoxNodeToDelete.PlaceholderText = "Node to Delete";
        textBoxNodeToDelete.Size = new Size(100, 23);
        textBoxNodeToDelete.TabIndex = 5;
        // 
        // buttonDeleteNode
        // 
        buttonDeleteNode.Location = new Point(306, 29);
        buttonDeleteNode.Name = "buttonDeleteNode";
        buttonDeleteNode.Size = new Size(100, 23);
        buttonDeleteNode.TabIndex = 4;
        buttonDeleteNode.Text = "Delete Node";
        buttonDeleteNode.UseVisualStyleBackColor = true;
        buttonDeleteNode.Click += buttonDeleteNode_Click;
        // 
        // button1
        // 
        button1.Location = new Point(32, 85);
        button1.Name = "button1";
        button1.Size = new Size(113, 43);
        button1.TabIndex = 3;
        button1.Text = "Pre Order Traversal Iteratively";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(150, 33);
        label3.Name = "label3";
        label3.Size = new Size(73, 15);
        label3.TabIndex = 2;
        label3.Text = "10,9,13,11,12";
        // 
        // buttonDeserializarTree
        // 
        buttonDeserializarTree.Location = new Point(32, 56);
        buttonDeserializarTree.Name = "buttonDeserializarTree";
        buttonDeserializarTree.Size = new Size(113, 23);
        buttonDeserializarTree.TabIndex = 1;
        buttonDeserializarTree.Text = "Deserializar Ttree";
        buttonDeserializarTree.UseVisualStyleBackColor = true;
        // 
        // buttonSerializarTree
        // 
        buttonSerializarTree.Location = new Point(32, 27);
        buttonSerializarTree.Name = "buttonSerializarTree";
        buttonSerializarTree.Size = new Size(113, 23);
        buttonSerializarTree.TabIndex = 0;
        buttonSerializarTree.Text = "Serializar Tree";
        buttonSerializarTree.UseVisualStyleBackColor = true;
        buttonSerializarTree.Click += buttonSerializarTree_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(777, 530);
        Controls.Add(tabControl1);
        Controls.Add(label1);
        Controls.Add(textBoxResultado);
        Controls.Add(textBoxInput);
        Name = "Form1";
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        tabPage2.ResumeLayout(false);
        Tree.ResumeLayout(false);
        Tree.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnFirstDuplicate;
    private TextBox textBoxInput;
    private Label label1;
    private TextBox textBoxResultado;
    private Button btnRemoveDuplicatesInPlace;
    private Button btnRemoveNthNode;
    private TextBox textBoxNth;
    private Button btnBynarySerach;
    private TextBox textBoxBinarySerach;
    private Button buttonLeftAndRightBoundary;
    private Button buttonTwoSum;
    private TextBox textBoxTwoFourSum;
    private GroupBox groupBox1;
    private Button buttonFourSum;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Label label2;
    private GroupBox groupBox2;
    private Button buttonSort3Colors;
    private Button buttonLongestSubstBySUm;
    private TextBox textBoxTargetSumLongestSubArray;
    private Button buttonSmalestWindowBySum;
    private Button buttonBoyerMooring;
    private TabPage Tree;
    private Button buttonDeserializarTree;
    private Button buttonSerializarTree;
    private Label label3;
    private Button button1;
    private TextBox textBoxNodeToDelete;
    private Button buttonDeleteNode;
    private Button buttonIteratorNext;
    private Button buttonIteratorTree;
}
