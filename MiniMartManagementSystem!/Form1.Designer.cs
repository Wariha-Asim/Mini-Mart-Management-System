namespace WinFormsApp6
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
            Admin = new Label();
            Customer = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 25);
            label1.Name = "label1";
            label1.Size = new Size(483, 45);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO MINI MART";
            // 
            // Admin
            // 
            Admin.AutoSize = true;
            Admin.Font = new Font("Cambria Math", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Admin.Location = new Point(88, 123);
            Admin.Name = "Admin";
            Admin.Size = new Size(146, 151);
            Admin.TabIndex = 1;
            Admin.Text = "Admin";
            Admin.Click += label2_Click;
            // 
            // Customer
            // 
            Customer.AutoSize = true;
            Customer.Font = new Font("Cambria Math", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Customer.Location = new Point(402, 123);
            Customer.Name = "Customer";
            Customer.Size = new Size(183, 151);
            Customer.TabIndex = 2;
            Customer.Text = "Customer";
            Customer.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(665, 316);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "EXIT";
            label3.Click += label3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 340);
            Controls.Add(label3);
            Controls.Add(Customer);
            Controls.Add(Admin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Admin;
        private Label Customer;
        private Label label3;
    }
}