using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Anaform
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
        private void Login_Load(object sender, EventArgs e)
        {
            string sorgu = "Select Ad From Login";
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                i = i + 1;
            }
            baglanti.Close();
            dr.Close();

            if(i == 0)
            {
                this.Hide();
                Form kayit = new Kayit();
                kayit.ShowDialog();
                this.Show();
                
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select kullanici_adi,parola from Login where kullanici_adi='"+txt_kadi.Text+"' and parola='"+txt_parola.Text+"'",baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                
                Form ana = new AnaForm();
                ana.Show();
                this.Hide();
                
            }
            else
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı!");
            baglanti.Close();
        }
    }
}