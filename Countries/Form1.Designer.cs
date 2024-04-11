namespace Countries
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.torles = new System.Windows.Forms.Button();
            this.szerkesztes = new System.Windows.Forms.Button();
            this.megnyitas = new System.Windows.Forms.Button();
            this.mentes = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaInSquareKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.areaInSquareKmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.countryDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // torles
            // 
            this.torles.Location = new System.Drawing.Point(583, 415);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(75, 23);
            this.torles.TabIndex = 1;
            this.torles.Text = "Törlés";
            this.torles.UseVisualStyleBackColor = true;
            this.torles.Click += new System.EventHandler(this.torles_Click);
            // 
            // szerkesztes
            // 
            this.szerkesztes.Location = new System.Drawing.Point(677, 415);
            this.szerkesztes.Name = "szerkesztes";
            this.szerkesztes.Size = new System.Drawing.Size(111, 23);
            this.szerkesztes.TabIndex = 2;
            this.szerkesztes.Text = "Szerkesztés";
            this.szerkesztes.UseVisualStyleBackColor = true;
            this.szerkesztes.Click += new System.EventHandler(this.szerkesztes_Click);
            // 
            // megnyitas
            // 
            this.megnyitas.Location = new System.Drawing.Point(644, 2);
            this.megnyitas.Name = "megnyitas";
            this.megnyitas.Size = new System.Drawing.Size(108, 33);
            this.megnyitas.TabIndex = 3;
            this.megnyitas.Text = "Megnyitás";
            this.megnyitas.UseVisualStyleBackColor = true;
            this.megnyitas.Click += new System.EventHandler(this.megnyitas_Click);
            // 
            // mentes
            // 
            this.mentes.Location = new System.Drawing.Point(67, 415);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(251, 28);
            this.mentes.TabIndex = 4;
            this.mentes.Text = "Mentés a szövegfájlba";
            this.mentes.UseVisualStyleBackColor = true;
            this.mentes.Click += new System.EventHandler(this.mentes_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.Width = 125;
            // 
            // areaInSquareKmDataGridViewTextBoxColumn
            // 
            this.areaInSquareKmDataGridViewTextBoxColumn.DataPropertyName = "AreaInSquareKm";
            this.areaInSquareKmDataGridViewTextBoxColumn.HeaderText = "AreaInSquareKm";
            this.areaInSquareKmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.areaInSquareKmDataGridViewTextBoxColumn.Name = "areaInSquareKmDataGridViewTextBoxColumn";
            this.areaInSquareKmDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataBindingSource
            // 
            this.countryDataBindingSource.DataSource = typeof(Countries.CountryData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 488);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.megnyitas);
            this.Controls.Add(this.szerkesztes);
            this.Controls.Add(this.torles);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.Button szerkesztes;
        private System.Windows.Forms.Button megnyitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaInSquareKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource countryDataBindingSource;
        private System.Windows.Forms.Button mentes;
    }
}

