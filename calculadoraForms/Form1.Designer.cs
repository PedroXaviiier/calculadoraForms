namespace calculadoraForms
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1Num1 = new TextBox();
            textBox2Num2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1Equal = new Button();
            button2AllClear = new Button();
            textBox3Resposta = new TextBox();
            checkedListBox1Tipos = new CheckedListBox();
            SuspendLayout();
            // 
            // textBox1Num1
            // 
            textBox1Num1.AllowDrop = true;
            textBox1Num1.BackColor = Color.Wheat;
            textBox1Num1.Location = new Point(11, 30);
            textBox1Num1.Name = "textBox1Num1";
            textBox1Num1.Size = new Size(361, 23);
            textBox1Num1.TabIndex = 0;
            // 
            // textBox2Num2
            // 
            textBox2Num2.AllowDrop = true;
            textBox2Num2.BackColor = Color.Wheat;
            textBox2Num2.Location = new Point(11, 87);
            textBox2Num2.Name = "textBox2Num2";
            textBox2Num2.Size = new Size(361, 23);
            textBox2Num2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Wheat;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 2;
            label1.Text = "Primeiro numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Wheat;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 3;
            label2.Text = "Segundo numero";
            // 
            // button1Equal
            // 
            button1Equal.BackColor = Color.Wheat;
            button1Equal.ForeColor = SystemColors.WindowFrame;
            button1Equal.Location = new Point(332, 216);
            button1Equal.Name = "button1Equal";
            button1Equal.Size = new Size(40, 28);
            button1Equal.TabIndex = 5;
            button1Equal.Text = "=";
            button1Equal.UseVisualStyleBackColor = false;
            button1Equal.Click += button1Equal_Click;
            // 
            // button2AllClear
            // 
            button2AllClear.BackColor = Color.Wheat;
            button2AllClear.ForeColor = SystemColors.WindowFrame;
            button2AllClear.Location = new Point(11, 216);
            button2AllClear.Name = "button2AllClear";
            button2AllClear.Size = new Size(41, 28);
            button2AllClear.TabIndex = 6;
            button2AllClear.Text = "AC";
            button2AllClear.UseVisualStyleBackColor = false;
            button2AllClear.Click += button2AllClear_Click;
            // 
            // textBox3Resposta
            // 
            textBox3Resposta.BackColor = Color.Wheat;
            textBox3Resposta.ForeColor = SystemColors.WindowFrame;
            textBox3Resposta.Location = new Point(59, 216);
            textBox3Resposta.Multiline = true;
            textBox3Resposta.Name = "textBox3Resposta";
            textBox3Resposta.ReadOnly = true;
            textBox3Resposta.Size = new Size(266, 28);
            textBox3Resposta.TabIndex = 7;
            textBox3Resposta.Text = "Reposta";
            textBox3Resposta.TextAlign = HorizontalAlignment.Center;
            // 
            // checkedListBox1Tipos
            // 
            checkedListBox1Tipos.BackColor = Color.Wheat;
            checkedListBox1Tipos.ForeColor = SystemColors.WindowFrame;
            checkedListBox1Tipos.FormattingEnabled = true;
            checkedListBox1Tipos.Items.AddRange(new object[] { "Adição ", "Subtração", "Divisão", "Multiplicação" });
            checkedListBox1Tipos.Location = new Point(11, 125);
            checkedListBox1Tipos.Name = "checkedListBox1Tipos";
            checkedListBox1Tipos.Size = new Size(360, 76);
            checkedListBox1Tipos.TabIndex = 8;
            checkedListBox1Tipos.SelectedIndexChanged += checkedListBox1Tipos_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(384, 261);
            Controls.Add(checkedListBox1Tipos);
            Controls.Add(textBox3Resposta);
            Controls.Add(button2AllClear);
            Controls.Add(button1Equal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2Num2);
            Controls.Add(textBox1Num1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculadora Maluca";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1Num1;
        private TextBox textBox2Num2;
        private Label label1;
        private Label label2;
        private Button button1Equal;
        private Button button2AllClear;
        private TextBox textBox3Resposta;
        private CheckedListBox checkedListBox1Tipos;
    }
}
