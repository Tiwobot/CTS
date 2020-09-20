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
    public partial class Form4 : Form
    {
        public string tckmlikk { get; set; }
        public string sifrr { get; set; }

        string idntaz = "";

        public Form4()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =dataa.accdb");
        OleDbCommand adder;


        private void Form4_Load(object sender, EventArgs e)
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

            adder = new OleDbCommand("select * from users where idnt = '" + tckmlikk + "' and passt = '" + sifrr + "' ", baglanti);
            OleDbDataReader okur = adder.ExecuteReader();
            string ranker = "";
            
            while (okur.Read())
                
            {
                idntaz = (okur["idnt"].ToString());
                ranker = (okur["rankt"].ToString());
            }


            button1.Visible = false;
            if (ranker == "-1")
            {
                MessageBox.Show("Risk oranınız daha bilinmemekte; Lütfen son 14 gün yaptıklarınız hakkındaki soruları cevaplayınız.");
                info.Visible = false;
                label1.Visible = false;
                button1.Visible = true;
            }
            info.Text = ranker;
        }

        private void info_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 fffa = new Form5();
            fffa.kimm = idntaz;
            fffa.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void genelarayuz_Click(object sender, EventArgs e)
        {

        }
    }
}
