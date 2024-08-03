namespace WinFormsApp6
{
    partial class Form12
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
            button1 = new Button();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(398, 330);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(378, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 23);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(378, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria Math", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(269, 233);
            label3.Name = "label3";
            label3.Size = new Size(110, 84);
            label3.TabIndex = 9;
            label3.Text = "Password:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria Math", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(269, 161);
            label2.Name = "label2";
            label2.Size = new Size(113, 84);
            label2.TabIndex = 8;
            label2.Text = "UserName:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(378, 84);
            label1.Name = "label1";
            label1.Size = new Size(130, 45);
            label1.TabIndex = 7;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(368, 382);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 15);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "don't have an account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(759, 426);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 14;
            label4.Text = "EXIT";
            label4.Click += label4_Click;
            // 
            // Form12
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
            Name = "Form12";
            Text = "Form12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label4;
    }
}