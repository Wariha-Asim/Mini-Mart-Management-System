namespace WinFormsApp6
{
    partial class categorycus
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
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(718, 412);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 47;
            label7.Text = "EXIT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(218, 338);
            label6.Name = "label6";
            label6.Size = new Size(123, 89);
            label6.TabIndex = 46;
            label6.Text = "5. Perfume";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria Math", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, -39);
            label1.Name = "label1";
            label1.Size = new Size(485, 184);
            label1.TabIndex = 45;
            label1.Text = "View Products By Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(213, 272);
            label5.Name = "label5";
            label5.Size = new Size(122, 89);
            label5.TabIndex = 44;
            label5.Text = "4. Clothing";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(213, 158);
            label4.Name = "label4";
            label4.Size = new Size(127, 89);
            label4.TabIndex = 43;
            label4.Text = "2. Medicine";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(213, 215);
            label3.Name = "label3";
            label3.Size = new Size(145, 89);
            label3.TabIndex = 42;
            label3.Text = "3 Accessories";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(213, 107);
            label2.Name = "label2";
            label2.Size = new Size(96, 89);
            label2.TabIndex = 41;
            label2.Text = "1. Food";
            label2.Click += label2_Click;
            // 
            // categorycus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "categorycus";
            Text = "categorycus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}