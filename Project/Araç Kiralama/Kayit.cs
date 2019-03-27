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
    public partial class Kayit : DevExpress.XtraEditors.XtraForm
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool durum = true;
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextEdit)
                {
                    if (ctl.Text == String.Empty)
                    {
                        MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
                        durum = false;
                        break;
                    }
                }
            }
            if(durum==true)
            {
                if (txt_parola.Text == txt_parola2.Text)
                {
                    SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
                    string sorgu = "Insert into Login(Ad,Soyad,kullanici_adi,parola) values (@ad,@soyad,@kadi,@parola)";
                    SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                    cmd.Parameters.AddWithValue("@ad", txt_ad.Text);
                    cmd.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                    cmd.Parameters.AddWithValue("@kadi", txt_kadi.Text);
                    cmd.Parameters.AddWithValue("@parola", txt_parola.Text);
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Başarıyla Kayıt Oldunuz. Programa Hoşgeldin "+txt_ad.Text);
                    Close();
                }
                else
                    MessageBox.Show("Girdiğiniz Parolalar Aynı Değil.");
            }
            
        }
    }
}