namespace U3_Practica_2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 32);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 0;
            label1.Text = "Tabla de multiplicar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleGoldenrod;
            label2.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 215);
            label2.Name = "label2";
            label2.Size = new Size(199, 22);
            label2.TabIndex = 1;
            label2.Text = "Limite de multiplicaciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 100);
            label3.Name = "label3";
            label3.Size = new Size(164, 22);
            label3.TabIndex = 2;
            label3.Text = "Introduce un número";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LemonChiffon;
            textBox1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(32, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LemonChiffon;
            textBox2.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(44, 252);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 29);
            textBox2.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LemonChiffon;
            listBox1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(240, 81);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 268);
            listBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Cornsilk;
            button1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(63, 320);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PaleGoldenrod;
            label4.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 122);
            label4.Name = "label4";
            label4.Size = new Size(124, 22);
            label4.TabIndex = 7;
            label4.Text = "para multiplicar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(429, 388);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Multiplicación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button1;
        private Label label4;
    }
}