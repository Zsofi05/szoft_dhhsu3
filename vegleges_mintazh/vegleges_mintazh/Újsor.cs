using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vegleges_mintazh
{
    public partial class Újsor : Form
    {
        public Versenyzők Versenyzők;
        public Újsor()
        {
            InitializeComponent();
        }


        private void ok_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Újsor_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = Versenyzők;
        }
    }
}
