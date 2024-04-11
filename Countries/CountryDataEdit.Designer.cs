namespace Countries
{
    partial class CountryDataEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.population = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country name:";
            // 
            // name
            // 
            this.name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Name", true));
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(48, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(189, 22);
            this.name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Population:";
            // 
            // population
            // 
            this.population.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Population", true));
            this.population.Location = new System.Drawing.Point(48, 202);
            this.population.Name = "population";
            this.population.Size = new System.Drawing.Size(189, 22);
            this.population.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Area in km2:";
            // 
            // area
            // 
            this.area.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "AreaInSquareKm", true));
            this.area.Location = new System.Drawing.Point(48, 330);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(189, 22);
            this.area.TabIndex = 5;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(251, 395);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 6;
            this.ok.Text = "&OK";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Countries.CountryData);
            // 
            // CountryDataEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.population);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "CountryDataEdit";
            this.Text = "CountryDataEdit";
            this.Load += new System.EventHandler(this.CountryDataEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox population;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}