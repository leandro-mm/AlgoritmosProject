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
        button1 = new Button();
        button2 = new Button();
        textBoxNth = new TextBox();
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
        textBoxResultado.Location = new Point(12, 141);
        textBoxResultado.Multiline = true;
        textBoxResultado.Name = "textBoxResultado";
        textBoxResultado.ScrollBars = ScrollBars.Both;
        textBoxResultado.Size = new Size(758, 167);
        textBoxResultado.TabIndex = 1;
        textBoxResultado.WordWrap = false;
        // 
        // button1
        // 
        button1.Location = new Point(128, 66);
        button1.Name = "button1";
        button1.Size = new Size(127, 23);
        button1.TabIndex = 3;
        button1.Text = "Remove Duplicates";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(261, 66);
        button2.Name = "button2";
        button2.Size = new Size(122, 23);
        button2.TabIndex = 4;
        button2.Text = "Remove N-th node from List";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // textBoxNth
        // 
        textBoxNth.Location = new Point(264, 91);
        textBoxNth.Name = "textBoxNth";
        textBoxNth.PlaceholderText = "n-th";
        textBoxNth.Size = new Size(119, 23);
        textBoxNth.TabIndex = 5;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(textBoxNth);
        Controls.Add(button2);
        Controls.Add(button1);
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
    private Button button1;
    private Button button2;
    private TextBox textBoxNth;
}
