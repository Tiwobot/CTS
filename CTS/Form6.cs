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
using System.Threading;

namespace coron
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =dataa.accdb");
        OleDbCommand adder;


        private void listelink_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fffw = new Form3();
            fffw.ShowDialog();
            timer1.Stop();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman.Text = DateTime.Now.ToString();
        }

        private void canlık_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu özellik Beta versiyonda kullanılamaz");
        }

        private void tcara_Click(object sender, EventArgs e)
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

            adder = new OleDbCommand("select * from users where idnt = '" + aratt.Text + "'", baglanti);
            OleDbDataReader okur = adder.ExecuteReader();
            string tckimlikk = "";
            string isim = "";
            string soyyis = "";
            string eposttr = "";
            string orann = "";
            string tellter = "";




            while (okur.Read())
            {
                tckimlikk = (okur["idnt"].ToString());
                isim = (okur["namet"].ToString()); ;
                soyyis = (okur["surnamet"].ToString()); ;
                eposttr = (okur["epost"].ToString()); ;
                orann = (okur["rankt"].ToString()); ;
                tellter = (okur["numbert"].ToString()); ;
            }

            textBox1.Text = tckimlikk;
            textBox2.Text = isim;
            textBox3.Text = soyyis;
            textBox4.Text = eposttr;
            textBox5.Text = orann;
            textBox6.Text = tellter;


        }
    }
}