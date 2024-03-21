namespace KamatSzamitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            decimal hitelosszeg =decimal.Parse( textboxhitel.Text);
            decimal havikamat= decimal.Parse(kamattextBox.Text);
            decimal torleszto = decimal.Parse(torlesztocomboBox1.Text);

            decimal hatralek = hitelosszeg;
            int honapok = 1;
            decimal koltseg = 0;

            List<Extrasor> sorok = new List<Extrasor>();

            while (hatralek > 0)
            {
                hatralek += hatralek * (havikamat / 100m);
                hatralek -= torleszto;
                koltseg += torleszto;

                 
                
                if (torleszto < hatralek * (havikamat / 100m)) 
                    {
                    MessageBox.Show(":(");
                    break;
                    }
                
                Extrasor extra = new Extrasor(); 
                extra.Hónap=honapok;
                extra.Hátraléj=hatralek;
                extra.KummuláltBefizetés = koltseg;


                sorok.Add(extra);
                honapok++;
            }
            koltseg += hatralek;
           dataGridView1.DataSource = sorok;   
        }
    }
}
