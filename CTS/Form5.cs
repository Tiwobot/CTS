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
    public partial class Form5 : Form
    {


        public string kimm { get; set; }

        public Form5()
        {
            
            InitializeComponent();
        }


        int puantor = 0;

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =dataa.accdb");
        OleDbCommand adder = new OleDbCommand();


        private void Form5_Load(object sender, EventArgs e)
        {
            soru2.Visible = false;
            soru2a.Visible = false;
            soru2b.Visible = false;
            soru3.Visible = false;
            soru3a.Visible = false;
            soru3b.Visible = false;
            soru3c.Visible = false;
            soru3d.Visible = false;
            soru4.Visible = false;
            soru4a.Visible = false;
            soru4b.Visible = false;
            soru5.Visible = false;
            soru5a.Visible = false;
            soru5b.Visible = false;
            soru6.Visible = false;
            soru6a.Visible = false;
            soru6b.Visible = false;


            MessageBox.Show("Süre sınırı yoktur ancak, cevaplarken dikkat ediniz;\n!cevaplanan soruya tekrar dönemezsiniz!\n 6 adet soru bulunmaktadır\nsağlığınız için cevaplarken dürüst olunuz.");
        }





        private void soru1a_Click(object sender, EventArgs e)
        {
            puantor = puantor + 28;
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru1b_Click(object sender, EventArgs e)
        {
            puantor = puantor + 26;
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru1c_Click(object sender, EventArgs e)
        {
            puantor = puantor + 24;
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru1d_Click(object sender, EventArgs e)
        {
            puantor = puantor + 22;
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru1e_Click(object sender, EventArgs e)
        {
            puantor = puantor + 20;
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru1f_Click(object sender, EventArgs e)
        {
            puantor = puantor + 18;
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru1g_Click(object sender, EventArgs e)
        {
            puantor = puantor + 16;
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru1h_Click(object sender, EventArgs e)
        {
            puantor = puantor + 14;
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru1i_Click(object sender, EventArgs e)
        {
            puantor = puantor + 12;
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru1j_Click(object sender, EventArgs e)
        {
            puantor = puantor + 10;
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru1k_Click(object sender, EventArgs e)
        {
            puantor = puantor + 8;
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru1l_Click(object sender, EventArgs e)
        {
            puantor = puantor + 6;
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru1m_Click(object sender, EventArgs e)
        {
            puantor = puantor + 4;
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru1n_Click(object sender, EventArgs e)
        {
            soru1.Visible = false;
            soru1a.Visible = false;
            soru1b.Visible = false;
            soru1c.Visible = false;
            soru1d.Visible = false;
            soru1e.Visible = false;
            soru1f.Visible = false;
            soru1g.Visible = false;
            soru1h.Visible = false;
            soru1i.Visible = false;
            soru1j.Visible = false;
            soru1k.Visible = false;
            soru1l.Visible = false;
            soru1m.Visible = false;
            soru1n.Visible = false;
            soru2.Visible = true;
            soru2a.Visible = true;
            soru2b.Visible = true;
        }

        private void soru2a_Click(object sender, EventArgs e)
        {
            puantor = puantor + 12;
            soru2.Visible = false;
            soru2a.Visible = false;
            soru2b.Visible = false;
            soru3.Visible = true;
            soru3a.Visible = true;
            soru3b.Visible = true;
            soru3c.Visible = true;
            soru3d.Visible = true;
        }

        private void soru2b_Click(object sender, EventArgs e)
        {
            soru2.Visible = false;
            soru2a.Visible = false;
            soru2b.Visible = false;
            soru3.Visible = true;
            soru3a.Visible = true;
            soru3b.Visible = true;
            soru3c.Visible = true;
            soru3d.Visible = true;
        }

        private void soru3a_Click(object sender, EventArgs e)
        {
            puantor = puantor + 13;
            soru3.Visible = false;
            soru3a.Visible = false;
            soru3b.Visible = false;
            soru3c.Visible = false;
            soru3d.Visible = false;
            soru4.Visible = true;
            soru4a.Visible = true;
            soru4b.Visible = true;
        }

        private void soru3b_Click(object sender, EventArgs e)
        {
            puantor = puantor + 7;
            soru3.Visible = false;
            soru3a.Visible = false;
            soru3b.Visible = false;
            soru3c.Visible = false;
            soru3d.Visible = false;
            soru4.Visible = true;
            soru4a.Visible = true;
            soru4b.Visible = true;
        }

        private void soru3c_Click(object sender, EventArgs e)
        {
            soru3.Visible = false;
            soru3a.Visible = false;
            soru3b.Visible = false;
            soru3c.Visible = false;
            soru3d.Visible = false;
            soru4.Visible = true;
            soru4a.Visible = true;
            soru4b.Visible = true;
        }

        private void soru3d_Click(object sender, EventArgs e)
        {
            puantor = puantor + 13;
            soru3.Visible = false;
            soru3a.Visible = false;
            soru3b.Visible = false;
            soru3c.Visible = false;
            soru3d.Visible = false;
            soru4.Visible = true;
            soru4a.Visible = true;
            soru4b.Visible = true;
        }

        private void soru4a_Click(object sender, EventArgs e)
        {
            puantor = puantor + 7;
            soru4.Visible = false;
            soru4a.Visible = false;
            soru4b.Visible = false;
            soru5.Visible = true;
            soru5a.Visible = true;
            soru5b.Visible = true;
        }

        private void soru4b_Click(object sender, EventArgs e)
        {
            soru4.Visible = false;
            soru4a.Visible = false;
            soru4b.Visible = false;
            soru5.Visible = true;
            soru5a.Visible = true;
            soru5b.Visible = true;
        }

        private void soru5a_Click(object sender, EventArgs e)
        {
            soru5.Visible = false;
            soru5a.Visible = false;
            soru5b.Visible = false;
            soru6.Visible = true;
            soru6a.Visible = true;
            soru6b.Visible = true;
        }

        private void soru5b_Click(object sender, EventArgs e)
        {
            puantor = puantor + 13;
            soru5.Visible = false;
            soru5a.Visible = false;
            soru5b.Visible = false;
            soru6.Visible = true;
            soru6a.Visible = true;
            soru6b.Visible = true;
        }

        private void soru6a_Click(object sender, EventArgs e)
        {
            puantor = puantor + 27;
            soru6.Visible = false;
            soru6a.Visible = false;
            soru6b.Visible = false;
            MessageBox.Show("Final sonucunuz = " + puantor.ToString());

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            else
            {
                baglanti.Close();
                baglanti.Open();
            }

            adder.Connection = baglanti;
            adder.CommandText = "update users set rankt = '" + puantor + "'where idnt = '" + kimm + "' ";
            adder.ExecuteNonQuery();
            adder.Dispose();
            baglanti.Close();

            MessageBox.Show("İşlem başarıyla gerçekleştirildi tekrar giriş yapınız.");

            this.Hide();
            Form1 fffw = new Form1();
            fffw.ShowDialog();
            this.Close();
        }

        private void soru6b_Click(object sender, EventArgs e)
        {
            soru6.Visible = false;
            soru6a.Visible = false;
            soru6b.Visible = false;
            MessageBox.Show("Final sonucunuz = " + puantor.ToString());

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            else
            {
                baglanti.Close();
                baglanti.Open();
            }

            adder.Connection = baglanti;
            adder.CommandText = "update users set rankt = '" + puantor + "'where idnt = '" + kimm + "' ";
            adder.ExecuteNonQuery();
            adder.Dispose();
            baglanti.Close();

            MessageBox.Show("İşlem başarıyla gerçekleştirildi tekrar giriş yapınız.");

            this.Hide();
            Form1 fffw = new Form1();
            fffw.ShowDialog();
            this.Close();
        }
    }
    
}
