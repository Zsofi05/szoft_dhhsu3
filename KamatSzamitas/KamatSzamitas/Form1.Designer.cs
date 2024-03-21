namespace KamatSzamitas
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
            label2 = new Label();
            torlesztocomboBox1 = new ComboBox();
            textboxhitel = new TextBox();
            kamattextBox = new TextBox();
            label3 = new Label();
            okbutton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 129);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Hitel összege";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 129);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 1;
            label2.Text = "Havi törlesztő";
            // 
            // torlesztocomboBox1
            // 
            torlesztocomboBox1.FormattingEnabled = true;
            torlesztocomboBox1.Items.AddRange(new object[] { "20000", "30000", "50000" });
            torlesztocomboBox1.Location = new Point(369, 161);
            torlesztocomboBox1.Name = "torlesztocomboBox1";
            torlesztocomboBox1.Size = new Size(151, 28);
            torlesztocomboBox1.TabIndex = 2;
            torlesztocomboBox1.Text = "20000";
            // 
            // textboxhitel
            // 
            textboxhitel.Location = new Point(181, 161);
            textboxhitel.Name = "textboxhitel";
            textboxhitel.Size = new Size(125, 27);
            textboxhitel.TabIndex = 3;
            textboxhitel.Text = "1000000";
            // 
            // kamattextBox
            // 
            kamattextBox.Location = new Point(181, 258);
            kamattextBox.Name = "kamattextBox";
            kamattextBox.Size = new Size(125, 27);
            kamattextBox.TabIndex = 5;
            kamattextBox.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 235);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Havi kamat";
            // 
            // okbutton
            // 
            okbutton.Location = new Point(395, 256);
            okbutton.Name = "okbutton";
            okbutton.Size = new Size(94, 29);
            okbutton.TabIndex = 6;
            okbutton.Text = "Oké";
            okbutton.UseVisualStyleBackColor = true;
            okbutton.Click += okbutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 322);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(612, 116);
            dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 450);
            Controls.Add(dataGridView1);
            Controls.Add(okbutton);
            Controls.Add(kamattextBox);
            Controls.Add(label3);
            Controls.Add(textboxhitel);
            Controls.Add(torlesztocomboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox torlesztocomboBox1;
        private TextBox textboxhitel;
        private TextBox kamattextBox;
        private Label label3;
        private Button okbutton;
        private DataGridView dataGridView1;
    }
}
