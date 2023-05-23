namespace Calculadora
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
            Button button4;
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(252, 272);
            button4.Name = "button4";
            button4.Size = new Size(63, 40);
            button4.TabIndex = 4;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 195);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(12, 272);
            button1.Name = "button1";
            button1.Size = new Size(63, 40);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(93, 272);
            button2.Name = "button2";
            button2.Size = new Size(63, 40);
            button2.TabIndex = 2;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(172, 272);
            button3.Name = "button3";
            button3.Size = new Size(63, 40);
            button3.TabIndex = 3;
            button3.Text = "x";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(93, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.Location = new Point(92, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(139, 272);
            label2.Name = "label2";
            label2.Size = new Size(0, 47);
            label2.TabIndex = 7;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(148, 149);
            label3.Name = "label3";
            label3.Size = new Size(25, 25);
            label3.TabIndex = 8;
            label3.Text = "=";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(110, 174);
            label4.Name = "label4";
            label4.Size = new Size(100, 36);
            label4.TabIndex = 9;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(111, 77);
            label5.Name = "label5";
            label5.Size = new Size(100, 43);
            label5.TabIndex = 10;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(327, 327);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}