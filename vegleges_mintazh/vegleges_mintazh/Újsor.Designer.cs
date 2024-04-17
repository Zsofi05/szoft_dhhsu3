namespace vegleges_mintazh
{
    partial class Újsor
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            ok = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 27);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "Versenyző azonosítója";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "VersenyzoID", true));
            textBox1.Location = new Point(154, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 27);
            textBox1.TabIndex = 1;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Versenyzők);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Nev", true));
            textBox2.Location = new Point(154, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 146);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 2;
            label2.Text = "Név";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "Nemzetiseg", true));
            textBox3.Location = new Point(154, 299);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 260);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 4;
            label3.Text = "Nemzetiség";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "EredmenyPerc", true));
            textBox4.Location = new Point(154, 426);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(248, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 387);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 6;
            label4.Text = "Eredmény";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "Kategoria", true));
            textBox5.Location = new Point(154, 537);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(248, 27);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 498);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 8;
            label5.Text = "Kategória";
            // 
            // ok
            // 
            ok.DialogResult = DialogResult.OK;
            ok.Location = new Point(227, 611);
            ok.Name = "ok";
            ok.Size = new Size(94, 29);
            ok.TabIndex = 10;
            ok.Text = "&Ok";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(329, 611);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "Mégse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Újsor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 665);
            Controls.Add(button1);
            Controls.Add(ok);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Újsor";
            Text = "Újsor";
            Load += Újsor_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Button ok;
        private BindingSource bindingSource1;
        private Button button1;
    }
}