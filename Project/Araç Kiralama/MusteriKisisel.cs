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
    public partial class MusteriKisisel : DevExpress.XtraEditors.XtraForm
    {
        public MusteriKisisel()
        {
            InitializeComponent();
        }
        public static int id;

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
            if (cmb_tur.Text=="")
            {
                if (durum == true)
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
                }
                durum = false;
            }
            if (durum == true)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
                bool durum2 = true;
                string sorgu = "Select TC From musteri_kisisel";
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<string> TC = new List<string>();
                int i = 0;
                while (dr.Read())
                {
                    TC.Add(Convert.ToString(dr["TC"]));
                    i = i + 1;

                }
                baglanti.Close();
                dr.Close();

                for(int j=0;j<i;j++)
                {
                    if(TC[j]==txt_tc.Text)
                    {
                        durum2 = false;
                        MessageBox.Show("Bu TC Kimlik Numarası Başka Müşteri Tarafından Kullanılıyor!");
                        break;
                    }
                }

                if(durum2==true)
                {
                    string kisisel = "Insert into musteri_kisisel(Ad,Soyad,TC,Telefon,Adres,Mail,EkBilgi,Tur) Values (@ad,@soyad,@tc,@telefon,@adres,@mail,@ekbilgi,@tur)";
                    baglanti.Open();
                    SqlCommand cmd_kisisel = new SqlCommand(kisisel, baglanti);
                    cmd_kisisel.Parameters.AddWithValue("@ad", txt_ad.Text);
                    cmd_kisisel.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                    cmd_kisisel.Parameters.AddWithValue("@tc", txt_tc.Text);
                    cmd_kisisel.Parameters.AddWithValue("@telefon", txt_tel.Text);
                    cmd_kisisel.Parameters.AddWithValue("@adres", txt_adres.Text);
                    cmd_kisisel.Parameters.AddWithValue("@mail", txt_mail.Text);
                    cmd_kisisel.Parameters.AddWithValue("@ekbilgi", txt_ekbilgi.Text);
                    cmd_kisisel.Parameters.AddWithValue("@tur", cmb_tur.SelectedItem);
                    cmd_kisisel.ExecuteNonQuery();
                    baglanti.Close();

                    Form ileri = new MusteriKimlik(txt_tc.Text);
                    ileri.ShowDialog();
                    this.Hide();
                }              
                
            }
            
        }
    }
}