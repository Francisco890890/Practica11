namespace Practica_11
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(254, 86);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "f(x)=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(357, 60);
            label2.Name = "label2";
            label2.Size = new Size(18, 21);
            label2.TabIndex = 1;
            label2.Text = "x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(305, 81);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 2;
            label3.Text = "_________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(343, 116);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 3;
            label4.Text = "1+x^2";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(69, 216);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 154);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(233, 216);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 154);
            listBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(117, 178);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 6;
            label5.Text = "x";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(273, 178);
            label6.Name = "label6";
            label6.Size = new Size(41, 25);
            label6.TabIndex = 7;
            label6.Text = "f(x)";
            // 
            // button1
            // 
            button1.Location = new Point(511, 173);
            button1.Name = "button1";
            button1.Size = new Size(88, 30);
            button1.TabIndex = 8;
            button1.Text = "for";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(511, 216);
            button2.Name = "button2";
            button2.Size = new Size(88, 30);
            button2.TabIndex = 9;
            button2.Text = "while";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(511, 261);
            button3.Name = "button3";
            button3.Size = new Size(88, 30);
            button3.TabIndex = 10;
            button3.Text = "do...while";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(511, 309);
            button4.Name = "button4";
            button4.Size = new Size(88, 30);
            button4.TabIndex = 11;
            button4.Text = "salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(511, 354);
            button5.Name = "button5";
            button5.Size = new Size(88, 30);
            button5.TabIndex = 12;
            button5.Text = "Borrar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "f(x)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}