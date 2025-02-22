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
        textBoxTwoSum = new TextBox();
        label3 = new Label();
        label4 = new Label();
        groupBox1 = new GroupBox();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // btnFirstDuplicate
        // 
        btnFirstDuplicate.Location = new Point(12, 85);
        btnFirstDuplicate.Name = "btnFirstDuplicate";
        btnFirstDuplicate.Size = new Size(170, 23);
        btnFirstDuplicate.TabIndex = 0;
        btnFirstDuplicate.Text = "First Duplicate";
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
        textBoxResultado.Location = new Point(12, 271);
        textBoxResultado.Multiline = true;
        textBoxResultado.Name = "textBoxResultado";
        textBoxResultado.ScrollBars = ScrollBars.Both;
        textBoxResultado.Size = new Size(758, 167);
        textBoxResultado.TabIndex = 1;
        textBoxResultado.WordWrap = false;
        // 
        // btnRemoveDuplicatesInPlace
        // 
        btnRemoveDuplicatesInPlace.Location = new Point(15, 114);
        btnRemoveDuplicatesInPlace.Name = "btnRemoveDuplicatesInPlace";
        btnRemoveDuplicatesInPlace.Size = new Size(167, 23);
        btnRemoveDuplicatesInPlace.TabIndex = 3;
        btnRemoveDuplicatesInPlace.Text = "Remove Duplicates In Place";
        btnRemoveDuplicatesInPlace.TextAlign = ContentAlignment.BottomRight;
        btnRemoveDuplicatesInPlace.UseVisualStyleBackColor = true;
        btnRemoveDuplicatesInPlace.Click += btnRemoveDuplicates_Click;
        // 
        // btnRemoveNthNode
        // 
        btnRemoveNthNode.Location = new Point(209, 85);
        btnRemoveNthNode.Name = "btnRemoveNthNode";
        btnRemoveNthNode.Size = new Size(122, 23);
        btnRemoveNthNode.TabIndex = 4;
        btnRemoveNthNode.Text = "Remove N-th node from List";
        btnRemoveNthNode.UseVisualStyleBackColor = true;
        btnRemoveNthNode.Click += btnRemoveNthNodeFromList_Click;
        // 
        // textBoxNth
        // 
        textBoxNth.Location = new Point(337, 86);
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
        // textBoxTwoSum
        // 
        textBoxTwoSum.Location = new Point(228, 51);
        textBoxTwoSum.Name = "textBoxTwoSum";
        textBoxTwoSum.PlaceholderText = "Two Sum";
        textBoxTwoSum.Size = new Size(100, 23);
        textBoxTwoSum.TabIndex = 7;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = SystemColors.GradientActiveCaption;
        label3.Location = new Point(15, 67);
        label3.Name = "label3";
        label3.Size = new Size(62, 15);
        label3.TabIndex = 11;
        label3.Text = "Duplicates";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.BackColor = SystemColors.GradientActiveCaption;
        label4.Location = new Point(209, 67);
        label4.Name = "label4";
        label4.Size = new Size(63, 15);
        label4.TabIndex = 11;
        label4.Text = "LInked List";
        // 
        // groupBox1
        // 
        groupBox1.BackColor = SystemColors.GradientActiveCaption;
        groupBox1.Controls.Add(buttonLeftAndRightBoundary);
        groupBox1.Controls.Add(btnBynarySerach);
        groupBox1.Controls.Add(textBoxBinarySerach);
        groupBox1.Controls.Add(textBoxTwoSum);
        groupBox1.Controls.Add(buttonTwoSum);
        groupBox1.Location = new Point(15, 153);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(335, 99);
        groupBox1.TabIndex = 12;
        groupBox1.TabStop = false;
        groupBox1.Text = "Left and Rigth Boudary";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(groupBox1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(textBoxNth);
        Controls.Add(btnRemoveNthNode);
        Controls.Add(btnRemoveDuplicatesInPlace);
        Controls.Add(label1);
        Controls.Add(textBoxResultado);
        Controls.Add(textBoxInput);
        Controls.Add(btnFirstDuplicate);
        Name = "Form1";
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
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
    private TextBox textBoxTwoSum;
    private Label label3;
    private Label label4;
    private GroupBox groupBox1;
}
