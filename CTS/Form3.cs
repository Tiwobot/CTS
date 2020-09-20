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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =dataa.accdb");
        OleDbCommand adder = new OleDbCommand();

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }


            listView1.Columns.Add("ID");
            listView1.Columns.Add("İsim");
            listView1.Columns.Add("Soy İsim");
            listView1.Columns.Add("E-posta");
            listView1.Columns.Add("Şifre");
            listView1.Columns.Add("Oran");
            listView1.Columns.Add("GSM");
            listView1.Columns.Add("TC Kimlik No");
            listView1.Columns.Add("Yetki");

            adder.Connection = baglanti;
            adder.CommandText = "SELECT * FROM users";
            OleDbDataReader okur = adder.ExecuteReader();
            while(okur.Read())
            {
                int sayac = listView1.Items.Count;
                listView1.Items.Add(okur["id"].ToString());
                listView1.Items[sayac].SubItems.Add(okur["namet"].ToString());
                listView1.Items[sayac].SubItems.Add(okur["surnamet"].ToString());
                listView1.Items[sayac].SubItems.Add(okur["epost"].ToString());
                listView1.Items[sayac].SubItems.Add(okur["passt"].ToString());
                listView1.Items[sayac].SubItems.Add(okur["rankt"].ToString());
                listView1.Items[sayac].SubItems.Add(okur["numbert"].ToString());
                listView1.Items[sayac].SubItems.Add(okur["idnt"].ToString());
                listView1.Items[sayac].SubItems.Add(okur["autht"].ToString());



            }


            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 fffw = new Form6();
            fffw.ShowDialog();
            this.Close();
        }
    }
    
}
