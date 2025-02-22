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
        SuspendLayout();
        // 
        // btnFirstDuplicate
        // 
        btnFirstDuplicate.Location = new Point(12, 66);
        btnFirstDuplicate.Name = "btnFirstDuplicate";
        btnFirstDuplicate.Size = new Size(110, 23);
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
        btnRemoveDuplicatesInPlace.Location = new Point(128, 66);
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
        btnRemoveNthNode.Location = new Point(301, 66);
        btnRemoveNthNode.Name = "btnRemoveNthNode";
        btnRemoveNthNode.Size = new Size(122, 23);
        btnRemoveNthNode.TabIndex = 4;
        btnRemoveNthNode.Text = "Remove N-th node from List";
        btnRemoveNthNode.UseVisualStyleBackColor = true;
        btnRemoveNthNode.Click += btnRemoveNthNodeFromList_Click;
        // 
        // textBoxNth
        // 
        textBoxNth.Location = new Point(301, 95);
        textBoxNth.Name = "textBoxNth";
        textBoxNth.PlaceholderText = "n-th";
        textBoxNth.Size = new Size(119, 23);
        textBoxNth.TabIndex = 5;
        // 
        // btnBynarySerach
        // 
        btnBynarySerach.Location = new Point(12, 129);
        btnBynarySerach.Name = "btnBynarySerach";
        btnBynarySerach.Size = new Size(101, 23);
        btnBynarySerach.TabIndex = 6;
        btnBynarySerach.Text = "Bynary Search";
        btnBynarySerach.UseVisualStyleBackColor = true;
        btnBynarySerach.Click += btnBynarySerach_Click;
        // 
        // textBoxBinarySerach
        // 
        textBoxBinarySerach.Location = new Point(13, 162);
        textBoxBinarySerach.Name = "textBoxBinarySerach";
        textBoxBinarySerach.PlaceholderText = "Elemento to Find";
        textBoxBinarySerach.Size = new Size(100, 23);
        textBoxBinarySerach.TabIndex = 7;
        // 
        // buttonLeftAndRightBoundary
        // 
        buttonLeftAndRightBoundary.Location = new Point(119, 129);
        buttonLeftAndRightBoundary.Name = "buttonLeftAndRightBoundary";
        buttonLeftAndRightBoundary.Size = new Size(145, 23);
        buttonLeftAndRightBoundary.TabIndex = 8;
        buttonLeftAndRightBoundary.Text = "Left and Right Boundary";
        buttonLeftAndRightBoundary.UseVisualStyleBackColor = true;
        buttonLeftAndRightBoundary.Click += buttonLeftAndRightBoundary_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(buttonLeftAndRightBoundary);
        Controls.Add(textBoxBinarySerach);
        Controls.Add(btnBynarySerach);
        Controls.Add(textBoxNth);
        Controls.Add(btnRemoveNthNode);
        Controls.Add(btnRemoveDuplicatesInPlace);
        Controls.Add(label1);
        Controls.Add(textBoxResultado);
        Controls.Add(textBoxInput);
        Controls.Add(btnFirstDuplicate);
        Name = "Form1";
        Text = "Form1";
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
}
