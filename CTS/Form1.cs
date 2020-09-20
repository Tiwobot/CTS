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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =dataa.accdb");
        OleDbDataAdapter cz;
        DataTable dt = new DataTable();
        OleDbCommand adder;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            yetkfoto.Visible = false;
            yetkgiris.Visible = false;
            label2.Visible = false;
           
            baglanti.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.turkiye.gov.tr/bilgilendirme?konu=sikcaSorulanlar#:~:text=%C5%9Eifre%20yenileme%20hizmetinin%20detaylar%C4%B1%20i%C3%A7in,%C5%9Fubelerinden%20yeni%20%C5%9Fifre%20zarf%C4%B1%20alarak");
        }

        private void giris_Click(object sender, EventArgs e)
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

            
            //idnt ve passt kontrol edilecek
            cz = new OleDbDataAdapter("select * from users where idnt = '" + tckm.Text + "' and passt = '" + tcksif.Text + "' ", baglanti);

                cz.Fill(dt);

            if(dt.Rows.Count <=0)
            {
                MessageBox.Show("TC Kimlik yada şifre hatalı\n! Eğer bir hesabınız yoksa yenisini oluşturunuz.");
            }
            else
            {
                adder = new OleDbCommand("select * from users where idnt = '" + tckm.Text + "' and passt = '" + tcksif.Text + "' ", baglanti);
                OleDbDataReader okur = adder.ExecuteReader();
                string tckimlikk = "";
                string passer = "";

                while (okur.Read())
                {
                    tckimlikk = (okur["idnt"].ToString());
                    passer = (okur["passt"].ToString());
                }

                MessageBox.Show("Giriş başarılı!");
                pictureBox1.Visible = false;
                giris.Visible = false;
                tckm.Visible = false;
                tcksif.Visible = false;
                linkLabel1.Visible = false;
                label1.Visible = false;
                hesapac.Visible = false;
                baglanti.Close();

                this.Hide();
                Form4 fffw = new Form4();
                fffw.tckmlikk = tckimlikk;
                fffw.sifrr = passer;
                fffw.ShowDialog();
                this.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e) //yetkili ç
        {
            pictureBox1.Visible = false;
            giris.Visible = false;
            linkLabel1.Visible = false;
            label1.Visible = false;
            hesapac.Visible = false;
            yetkfoto.Visible = true;
            yetkgiris.Visible = true;
            label2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e) //kullanıcı ç
        {
            pictureBox1.Visible = true;
            giris.Visible = true;
            linkLabel1.Visible = true;
            label1.Visible = true;
            hesapac.Visible = true;
            yetkfoto.Visible = false;
            yetkgiris.Visible = false;
            label2.Visible = false;
        }

        private void yetkgiris_Click(object sender, EventArgs e)
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


            cz = new OleDbDataAdapter("select * from users where epost = '" + tckm.Text + "' and passt = '" + tcksif.Text + "' and autht = 1", baglanti);

            cz.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("E-Posta yada şifre hatalı\n! Yetkili olduğuna emin misin?");
            }

            else
            {
                MessageBox.Show("Giriş başarılı!");
                yetkfoto.Visible = false;
                yetkgiris.Visible = false;
                label2.Visible = false;
                tckm.Visible = false;
                tcksif.Visible = false;

                baglanti.Close();

                this.Hide();
                Form6 fffw = new Form6();
                fffw.ShowDialog();
                this.Close();
            }
          

        }

        private void hesapac_Click(object sender, EventArgs e)
        {
            Form2 fffw = new Form2();
            this.Hide();
            fffw.ShowDialog();
        }
    }
}