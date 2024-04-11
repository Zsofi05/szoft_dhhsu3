using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countries
{
    public partial class CountryDataEdit : Form
    {
        public CountryData CountryData;

        public CountryDataEdit()
        {
            InitializeComponent();
        }

        private void CountryDataEdit_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CountryData;
        }

       
    }
}
