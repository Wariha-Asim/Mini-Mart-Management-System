namespace WinFormsApp6
{
    partial class Form10
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(201, 31);
            label1.Name = "label1";
            label1.Size = new Size(328, 45);
            label1.TabIndex = 24;
            label1.Text = "CUSTOMER MENU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(245, 85);
            label2.Name = "label2";
            label2.Size = new Size(229, 89);
            label2.TabIndex = 25;
            label2.Text = "1. Show Inventory Items";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(245, 149);
            label3.Name = "label3";
            label3.Size = new Size(185, 89);
            label3.TabIndex = 26;
            label3.Text = "2. Search Products";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(245, 216);
            label4.Name = "label4";
            label4.Size = new Size(270, 89);
            label4.TabIndex = 27;
            label4.Text = "3. View Products By Category";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(245, 299);
            label5.Name = "label5";
            label5.Size = new Size(204, 89);
            label5.TabIndex = 28;
            label5.Text = "4. Purchase Products";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(742, 417);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 29;
            label6.Text = "EXIT";
            label6.Click += label6_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form10";
            Text = "Form10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}