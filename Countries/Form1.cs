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
    public partial class Form1 : Form
    {
            BindingList<CountryData> countryList= new BindingList<CountryData>();
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.DataSource=countryList;
            countryDataBindingSource.DataSource=countryList;
        }

        private void megnyitas_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv=new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb=csv.GetRecords<CountryData>(); 
            foreach( var item in tömb)
            {
                countryList.Add(item);
            }
            sr.Close();
        }

        private void torles_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void szerkesztes_Click(object sender, EventArgs e)
        {
            CountryDataEdit fce=new CountryDataEdit();
            fce.CountryData=countryDataBindingSource.Current as CountryData;
            fce.Show();
        }

       

        private void mentes_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("../../european_countries.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(countryList);
            };
        }
    }
}
