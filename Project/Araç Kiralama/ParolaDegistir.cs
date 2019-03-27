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
    public partial class ParolaDegistir : DevExpress.XtraEditors.XtraForm
    {
        public ParolaDegistir()
        {
            InitializeComponent();
        }

        private void btn_degis_Click(object sender, EventArgs e)
        {
            if(txt_eski.Text == "" || txt_yeni1.Text == "" || txt_yeni2.Text == "")
            {
                MessageBox.Show("Lütfen Eksik Alan Bırakmayın.");
            }
            else
            {
                if (txt_yeni1.Text == txt_yeni2.Text)
                {
                    SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Select parola from Login where parola='" + txt_eski.Text +"'",baglanti);
                    SqlDataReader read = cmd.ExecuteReader();
                    
                    if (read.Read())
                    {
                        read.Close();
                        SqlCommand kmt = new SqlCommand("Update Login Set parola='" + txt_yeni2.Text + "'", baglanti);                        
                        kmt.ExecuteNonQuery();
                        MessageBox.Show("Parola Değiştirildi.");
                        baglanti.Close();
                        Close();
                    }
                    else
                        MessageBox.Show("Girdiğiniz Eski Şifre Hatalı!");
                }
                else
                    MessageBox.Show("Girdiginiz Yeni Şifreler Farklı!");
                
            }
        }
    }
}