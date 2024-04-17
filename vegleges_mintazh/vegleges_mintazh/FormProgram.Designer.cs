namespace vegleges_mintazh
{
    partial class FormProgram
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            versenyzoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nemzetisegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eredmenyPercDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            versenyzőkBindingSource = new BindingSource(components);
            betoltes = new Button();
            mentes = new Button();
            torles = new Button();
            ujsor = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)versenyzőkBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { versenyzoIDDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, nemzetisegDataGridViewTextBoxColumn, eredmenyPercDataGridViewTextBoxColumn, kategoriaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = versenyzőkBindingSource;
            dataGridView1.Location = new Point(27, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 344);
            dataGridView1.TabIndex = 0;
            // 
            // versenyzoIDDataGridViewTextBoxColumn
            // 
            versenyzoIDDataGridViewTextBoxColumn.DataPropertyName = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.HeaderText = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            versenyzoIDDataGridViewTextBoxColumn.Name = "versenyzoIDDataGridViewTextBoxColumn";
            versenyzoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.MinimumWidth = 6;
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            nevDataGridViewTextBoxColumn.Width = 125;
            // 
            // nemzetisegDataGridViewTextBoxColumn
            // 
            nemzetisegDataGridViewTextBoxColumn.DataPropertyName = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.HeaderText = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.MinimumWidth = 6;
            nemzetisegDataGridViewTextBoxColumn.Name = "nemzetisegDataGridViewTextBoxColumn";
            nemzetisegDataGridViewTextBoxColumn.Width = 125;
            // 
            // eredmenyPercDataGridViewTextBoxColumn
            // 
            eredmenyPercDataGridViewTextBoxColumn.DataPropertyName = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.HeaderText = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.MinimumWidth = 6;
            eredmenyPercDataGridViewTextBoxColumn.Name = "eredmenyPercDataGridViewTextBoxColumn";
            eredmenyPercDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            kategoriaDataGridViewTextBoxColumn.DataPropertyName = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            kategoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // versenyzőkBindingSource
            // 
            versenyzőkBindingSource.DataSource = typeof(Versenyzők);
            // 
            // betoltes
            // 
            betoltes.Location = new Point(612, 100);
            betoltes.Name = "betoltes";
            betoltes.Size = new Size(94, 29);
            betoltes.TabIndex = 1;
            betoltes.Text = "Betöltés";
            betoltes.UseVisualStyleBackColor = true;
            betoltes.Click += betoltes_Click;
            // 
            // mentes
            // 
            mentes.Location = new Point(36, 517);
            mentes.Name = "mentes";
            mentes.Size = new Size(94, 29);
            mentes.TabIndex = 2;
            mentes.Text = "Mentés";
            mentes.UseVisualStyleBackColor = true;
            mentes.Click += mentes_Click;
            // 
            // torles
            // 
            torles.Location = new Point(612, 517);
            torles.Name = "torles";
            torles.Size = new Size(94, 29);
            torles.TabIndex = 3;
            torles.Text = "Törlés";
            torles.UseVisualStyleBackColor = true;
            torles.Click += torles_Click;
            // 
            // ujsor
            // 
            ujsor.Location = new Point(497, 517);
            ujsor.Name = "ujsor";
            ujsor.Size = new Size(94, 29);
            ujsor.TabIndex = 4;
            ujsor.Text = "Új sor";
            ujsor.UseVisualStyleBackColor = true;
            ujsor.Click += ujsor_Click;
            // 
            // button1
            // 
            button1.Location = new Point(64, 110);
            button1.Name = "button1";
            button1.Size = new Size(128, 29);
            button1.TabIndex = 5;
            button1.Text = "Érdekességek";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(385, 517);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Szerkeztés";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", versenyzőkBindingSource, "Nev", true));
            textBox1.Location = new Point(760, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 27);
            textBox1.TabIndex = 7;
            // 
            // FormProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 570);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ujsor);
            Controls.Add(torles);
            Controls.Add(mentes);
            Controls.Add(betoltes);
            Controls.Add(dataGridView1);
            Name = "FormProgram";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)versenyzőkBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button betoltes;
        private DataGridViewTextBoxColumn versenyzoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nemzetisegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eredmenyPercDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private BindingSource versenyzőkBindingSource;
        private Button mentes;
        private Button torles;
        private Button ujsor;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
    }
}
