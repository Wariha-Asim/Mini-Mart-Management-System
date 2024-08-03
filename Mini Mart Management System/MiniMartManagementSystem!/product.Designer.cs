namespace WinFormsApp6
{
    partial class product
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria Math", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, -43);
            label1.Name = "label1";
            label1.Size = new Size(335, 184);
            label1.TabIndex = 37;
            label1.Text = "Manage Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 160);
            label2.Name = "label2";
            label2.Size = new Size(149, 89);
            label2.TabIndex = 38;
            label2.Text = "Product Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 216);
            label3.Name = "label3";
            label3.Size = new Size(145, 89);
            label3.TabIndex = 39;
            label3.Text = "Product Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(-1, 272);
            label4.Name = "label4";
            label4.Size = new Size(171, 89);
            label4.TabIndex = 40;
            label4.Text = "Product Quantity";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(-5, 326);
            label5.Name = "label5";
            label5.Size = new Size(175, 89);
            label5.TabIndex = 41;
            label5.Text = "Product Category";
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(218, 430);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 43;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(402, 431);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 44;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(606, 431);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 45;
            button4.Text = "Show all";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(336, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(504, 314);
            dataGridView1.TabIndex = 46;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 47;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 361);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 49;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(176, 251);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 51;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(176, 307);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 53;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(47, 430);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 42;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(822, 463);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 54;
            label6.Text = "EXIT";
            label6.Click += label6_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(176, 132);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 97);
            label7.Name = "label7";
            label7.Size = new Size(121, 89);
            label7.TabIndex = 56;
            label7.Text = "Product Id";
            // 
            // product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 487);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "product";
            Text = "product";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
    }
}