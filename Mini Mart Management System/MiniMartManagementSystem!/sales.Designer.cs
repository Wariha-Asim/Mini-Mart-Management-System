namespace WinFormsApp6
{
    partial class sales
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
            label6 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(704, 399);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 43;
            label6.Text = "EXIT";
            label6.Click += label6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria Math", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(529, 223);
            label2.Name = "label2";
            label2.Size = new Size(242, 111);
            label2.TabIndex = 42;
            label2.Text = "View customer sales";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.AppWorkspace;
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(517, 326);
            dataGridView1.TabIndex = 41;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria Math", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, -70);
            label1.Name = "label1";
            label1.Size = new Size(153, 184);
            label1.TabIndex = 40;
            label1.Text = "Sales";
            // 
            // sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 430);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "sales";
            Text = "sales";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
    }
}