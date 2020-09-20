using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace coron
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =dataa.accdb");
        OleDbCommand adder;



        private void gsmtext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GSM Numarası = telefon numarasının başında 0 olmayan hali\ntel. no: 0555 444 33 22\ngsm no: 555 444 33 22");
        }






        private void kaydol_but_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            else
            {
                baglanti.Close();
                baglanti.Open();
            }

            adder = new OleDbCommand();

            adder.Connection = baglanti;
            adder.CommandText = "INSERT INTO users (namet, surnamet, epost, passt, rankt, numbert, idnt, autht) VALUES(@pisimmm, @psoyaddd, @peposttt, @psifrrr, -1, @pgsmmm, @ptccc, 0)";

            adder.Parameters.AddWithValue("@pisimmm", isimtextbox.Text);
            adder.Parameters.AddWithValue("@psoyaddd", soyadtextbox.Text);
            adder.Parameters.AddWithValue("@peposttt", eposttextbox.Text);
            adder.Parameters.AddWithValue("@psifrrr", sifrtextbox.Text);
            adder.Parameters.AddWithValue("@pgsmmm", gsmtextbox.Text);
            adder.Parameters.AddWithValue("@ptccc", tctextbox.Text);




            adder.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız Tamamlandı.");

            

            Form1 fffw = new Form1();
            this.Hide();
            fffw.ShowDialog();
            this.Close();
        }






        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            baglanti.Close();
        }
    }
}
