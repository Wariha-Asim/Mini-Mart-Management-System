namespace WinFormsApp6
{
    partial class checkout
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
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.AutoSize = true;
            label3.Font = new Font("Cambria Math", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(138, 194);
            label3.Name = "label3";
            label3.Size = new Size(495, 184);
            label3.TabIndex = 45;
            label3.Text = " MANAGEMENT SYSTEM <3";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Font = new Font("Cambria Math", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(59, 72);
            label2.Name = "label2";
            label2.Size = new Size(683, 184);
            label2.TabIndex = 44;
            label2.Text = "THANKS FOR VISITING OUR MINI MART";
            // 
            // checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "checkout";
            Text = "checkout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
    }
}