namespace WinFormsApp6
{
    partial class Form7
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria Math", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(497, 189);
            label2.Name = "label2";
            label2.Size = new Size(196, 179);
            label2.TabIndex = 10;
            label2.Text = "SIGN UP";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria Math", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(102, 188);
            label3.Name = "label3";
            label3.Size = new Size(178, 179);
            label3.TabIndex = 9;
            label3.Text = "LOG IN";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(287, 110);
            label4.Name = "label4";
            label4.Size = new Size(181, 35);
            label4.TabIndex = 8;
            label4.Text = "CUSTOMER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(759, 426);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 11;
            label1.Text = "EXIT";
            label1.Click += label1_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
    }
}