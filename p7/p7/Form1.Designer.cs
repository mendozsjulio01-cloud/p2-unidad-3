﻿namespace p7
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
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 33);
            label1.Name = "label1";
            label1.Size = new Size(397, 20);
            label1.TabIndex = 0;
            label1.Text = "imprime numeros de un rango especifico y calcula la suma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 104);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "rango inferior";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 108);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 2;
            label3.Text = "rango superior";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 353);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = "suma";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(543, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(353, 356);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(530, 159);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 204);
            listBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(17, 154);
            button1.Name = "button1";
            button1.Size = new Size(467, 183);
            button1.TabIndex = 8;
            button1.Text = "imprime";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox listBox1;
        private Button button1;
    }
}
