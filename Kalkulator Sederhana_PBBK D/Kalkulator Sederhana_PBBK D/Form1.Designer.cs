namespace Kalkulator_Sederhana_PBBK_D
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(371, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(289, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(371, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(289, 351);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(371, 39);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(107, 482);
            button1.Name = "button1";
            button1.Size = new Size(170, 170);
            button1.TabIndex = 3;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(298, 482);
            button2.Name = "button2";
            button2.Size = new Size(170, 170);
            button2.TabIndex = 4;
            button2.Text = "*";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(298, 675);
            button3.Name = "button3";
            button3.Size = new Size(170, 170);
            button3.TabIndex = 5;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(107, 675);
            button4.Name = "button4";
            button4.Size = new Size(170, 170);
            button4.TabIndex = 6;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(107, 873);
            button5.Name = "button5";
            button5.Size = new Size(553, 99);
            button5.TabIndex = 7;
            button5.Text = "C";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 86);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 8;
            label1.Text = "Nilai 1 :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 217);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 9;
            label2.Text = "Nilai 2 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 354);
            label3.Name = "label3";
            label3.Size = new Size(77, 32);
            label3.TabIndex = 10;
            label3.Text = "Hasil :";
            label3.Click += label3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(490, 675);
            button6.Name = "button6";
            button6.Size = new Size(170, 170);
            button6.TabIndex = 11;
            button6.Text = "^";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(490, 482);
            button7.Name = "button7";
            button7.Size = new Size(170, 170);
            button7.TabIndex = 12;
            button7.Text = "%";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 1058);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Kalkulator Sederhana";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button6;
        private Button button7;
    }
}