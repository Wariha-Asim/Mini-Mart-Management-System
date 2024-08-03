namespace WinFormsApp6
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(192, 69);
            label1.Name = "label1";
            label1.Size = new Size(369, 45);
            label1.TabIndex = 23;
            label1.Text = "CUSTOMER SIGN UP";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria Math", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(207, 225);
            label3.Name = "label3";
            label3.Size = new Size(110, 84);
            label3.TabIndex = 25;
            label3.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(359, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 23);
            textBox1.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(359, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(202, 23);
            textBox3.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria Math", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(204, 167);
            label2.Name = "label2";
            label2.Size = new Size(113, 84);
            label2.TabIndex = 24;
            label2.Text = "UserName:";
            // 
            // button1
            // 
            button1.Location = new Point(359, 306);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 28;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(349, 365);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(94, 15);
            linkLabel1.TabIndex = 33;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "have an account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(759, 416);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 34;
            label4.Text = "EXIT";
            label4.Click += label4_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label4;
    }
}