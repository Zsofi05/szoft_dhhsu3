using CsvHelper;
using System.ComponentModel;
using System.Diagnostics.PerformanceData;
using System.Formats.Asn1;
using System.Globalization;

namespace vegleges_mintazh
{
    public partial class FormProgram : Form
    {
        BindingList<Versenyzõk> versenyzok = new();
        public FormProgram()
        {
            InitializeComponent();
            // dataGridView1.DataSource = versenyzok;
            versenyzõkBindingSource.DataSource = versenyzok;

        }

        private void betoltes_Click(object sender, EventArgs e)
        {

            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Versenyzõk>();

                foreach (var item in tömb)
                {
                    versenyzok.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mentes_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(versenyzok);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void torles_Click(object sender, EventArgs e)
        {
            if (versenyzõkBindingSource.Current == null) return;

            if (MessageBox.Show("Biztosan szeretné törölni a kijelölt sort?", "Nem törlöm.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                versenyzõkBindingSource.RemoveCurrent();
            }
        }

        private void ujsor_Click(object sender, EventArgs e)
        {
            
            if (versenyzõkBindingSource.Current == null) return;
            Újsor ujsor = new Újsor();
            ujsor.Versenyzõk = (Versenyzõk)versenyzõkBindingSource.AddNew();
            ujsor.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int usaversenyzok = GetCompetitorsFromCountry("USA");
            string leggyorsabb = GetFastestCompetitorOverall();

            string message = $"Amerikai versenyzõk száma: {usaversenyzok}\n" +
                     $"Legjobb idõt futó versenyzõ: {leggyorsabb}";

            MessageBox.Show(message, "Verseny statisztika", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private int GetCompetitorsFromCountry(string orszag)
        {
            
            int count = 0;

            foreach (var competitor in versenyzok) 
            {
                if (competitor.Nemzetiseg == orszag)
                {
                    count++;
                }
            }

            return count;
        }
        private string GetFastestCompetitorOverall()
        {
           
            string fastestCompetitorName = "Nincs adat";

            
            double minTime = double.MaxValue;

            foreach (var competitor in versenyzok) 
            {
                if (competitor.EredmenyPerc < minTime)
                {
                    minTime = competitor.EredmenyPerc;
                    fastestCompetitorName = competitor.Nev;
                }
            }

            return fastestCompetitorName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (versenyzõkBindingSource.Current == null) return;
            FormSzerkesztés fce = new FormSzerkesztés();
            fce.Verseny = versenyzõkBindingSource.Current as Versenyzõk;
            fce.Show();



        }
    }
}
