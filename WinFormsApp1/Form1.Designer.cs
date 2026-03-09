namespace WinFormsApp1
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
            this.argX = new TextBox();
            argY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // argX
            // 
            this.argX.Location = new Point(21, 23);
            this.argX.Name = "argX";
            this.argX.Size = new Size(125, 29);
            this.argX.TabIndex = 0;
            this.argX.TextChanged += this.textBox1_TextChanged;
            // 
            // argY
            // 
            argY.Location = new Point(21, 58);
            argY.Name = "argY";
            argY.Size = new Size(125, 29);
            argY.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 26);
            label1.Name = "label1";
            label1.Size = new Size(181, 21);
            label1.TabIndex = 2;
            label1.Text = "значение переменной x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 61);
            label2.Name = "label2";
            label2.Size = new Size(182, 21);
            label2.TabIndex = 3;
            label2.Text = "значение переменной y";
            // 
            // button1
            // 
            button1.Location = new Point(21, 93);
            button1.Name = "button1";
            button1.Size = new Size(312, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 148);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(argY);
            Controls.Add(this.argX);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox argY;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
