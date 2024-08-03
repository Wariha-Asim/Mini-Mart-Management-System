namespace WinFormsApp6
{
    partial class Form14
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria Math", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(293, -58);
            label1.Name = "label1";
            label1.Size = new Size(302, 184);
            label1.TabIndex = 2;
            label1.Text = "Show Products";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.AppWorkspace;
            dataGridView1.Location = new Point(172, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(517, 363);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria Math", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(695, 262);
            label2.Name = "label2";
            label2.Size = new Size(111, 111);
            label2.TabIndex = 4;
            label2.Text = "Search";
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(764, 457);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 35;
            label6.Text = "EXIT";
            label6.Click += label6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(4, 201);
            label3.Name = "label3";
            label3.Size = new Size(162, 19);
            label3.TabIndex = 36;
            label3.Text = "Enter product name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 260);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 37;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form14";
            Text = "Form14";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label6;
        private Label label3;
        private TextBox textBox1;
    }
}