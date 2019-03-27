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
    public partial class Rezervasyonguncelle : DevExpress.XtraEditors.XtraForm
    {
        private int id,ucret;
        private string Baslama;
        private string Bitis;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
        public Rezervasyonguncelle(int id,string Baslama,string Bitis,int ucret)
        {
            this.id = id;
            this.Baslama = Baslama;
            this.Bitis = Bitis;
            this.ucret = ucret;
            InitializeComponent();
        }

        private void Rezervasyonguncelle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter data_arac = new SqlDataAdapter("Select id,Marka,Model,Plaka,Ucret From Araclar", baglanti);
            DataSet ds_arac = new DataSet();
            baglanti.Open();
            data_arac.Fill(ds_arac, "Araclar");
            gridControl1.DataSource = ds_arac.Tables["Araclar"];
            baglanti.Close();

            SqlDataAdapter data_musteri = new SqlDataAdapter("Select id,Ad,Soyad,TC From musteri_kisisel", baglanti);
            DataSet ds_musteri = new DataSet();
            baglanti.Open();
            data_musteri.Fill(ds_musteri, "musteri_kisisel");
            gridControl2.DataSource = ds_musteri.Tables["musteri_kisisel"];
            baglanti.Close();

            dt_bas.Text = Baslama;
            dt_son.Text = Bitis;
            txt_ucret.Text = ucret.ToString();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DateTime baslamaTarihi = new DateTime(Convert.ToInt32(dt_bas.DateTime.Year), Convert.ToInt32(dt_bas.DateTime.Month), Convert.ToInt32(dt_bas.DateTime.Day));
            DateTime bitisTarihi = new DateTime(Convert.ToInt32(dt_son.DateTime.Year), Convert.ToInt32(dt_son.DateTime.Month), Convert.ToInt32(dt_son.DateTime.Day));

            TimeSpan kalangun = bitisTarihi - baslamaTarihi;
            double toplamGun = kalangun.TotalDays;

            int ucret = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Ucret"));
            txt_ucret.Text = (toplamGun * ucret).ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool durum=true;
            /*int durum1, durum2, durum3, durum4;
            string sorgu = "Select Baslama From Rezervasyonlar where Plaka=@plaka";
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@plaka", gridView1.GetFocusedRowCellValue("Plaka"));
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                i = i + 1;
            }
            DateTime[] bastarih = new DateTime[i];
            i = 0;
            while (dr.Read())
            {
                bastarih[i] = Convert.ToDateTime(dr["Baslama"]);
            }
            baglanti.Close();
            dr.Close();




            string sorgu2 = "Select Bitis From Rezervasyonlar where Plaka=@p";
            SqlCommand cmd_2 = new SqlCommand(sorgu2, baglanti);
            cmd_2.Parameters.AddWithValue("@p", gridView1.GetFocusedRowCellValue("Plaka"));
            baglanti.Open();
            SqlDataReader dr2 = cmd_2.ExecuteReader();
            i = 0;
            while (dr2.Read())
            {
                i = i + 1;
            }
            DateTime[] bittarih = new DateTime[i];
            i = 0;
            while (dr2.Read())
            {
                bittarih[i] = Convert.ToDateTime(dr2["Baslama"]);
            }
            baglanti.Close();
            dr2.Close();


            for (int j = 0; j < bastarih.Length; j++)
            {
                DateTime YeniBas = new DateTime(dt_bas.DateTime.Year, dt_bas.DateTime.Month, dt_bas.DateTime.Day);
                DateTime YeniBit = new DateTime(dt_son.DateTime.Year, dt_son.DateTime.Month, dt_son.DateTime.Day);
                DateTime EskiBas = new DateTime(bastarih[j].Year, bastarih[j].Month, bastarih[j].Day);
                DateTime EskiBit = new DateTime(bittarih[j].Year, bittarih[j].Month, bittarih[j].Day);

                durum1 = DateTime.Compare(EskiBas, YeniBas);
                durum2 = DateTime.Compare(EskiBit, YeniBas);
                durum3 = DateTime.Compare(EskiBas, YeniBit);
                durum4 = DateTime.Compare(EskiBit, YeniBit);

                if (durum1 == -1 && durum2 == 1)
                {
                    durum = false;
                    break;
                }
                if (durum3 == -1 && durum4 == -1)
                {
                    durum = false;
                    break;
                }
                else
                    durum = true;
            }
            */
            if (durum == true)
            {
                string sorgu3 = "Update Rezervasyonlar Set Baslama=@baslama,Bitis=@bitis,Ad=@ad,Soyad=@soyad,TC=@tc,Plaka=@plaka,Marka=@marka,Model=@model,Ucret=@ucret Where id=@id";
                SqlCommand komut = new SqlCommand(sorgu3, baglanti);

                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@baslama", dt_bas.Text);
                komut.Parameters.AddWithValue("@bitis", dt_son.Text);
                komut.Parameters.AddWithValue("@ad", Convert.ToString(gridView2.GetFocusedRowCellValue("Ad")));
                komut.Parameters.AddWithValue("@soyad", Convert.ToString(gridView2.GetFocusedRowCellValue("Soyad")));
                komut.Parameters.AddWithValue("@tc", Convert.ToString(gridView2.GetFocusedRowCellValue("TC")));
                komut.Parameters.AddWithValue("@plaka", Convert.ToString(gridView1.GetFocusedRowCellValue("Plaka")));
                komut.Parameters.AddWithValue("@marka", Convert.ToString(gridView1.GetFocusedRowCellValue("Marka")));
                komut.Parameters.AddWithValue("@model", Convert.ToString(gridView1.GetFocusedRowCellValue("Model")));
                komut.Parameters.AddWithValue("@ucret", Convert.ToString(gridView1.GetFocusedRowCellValue("Ucret")));

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Rezervasyon Güncellendi.");
                Close();
            }
            /*else
                MessageBox.Show("Seçtiğiniz tarihler arasında zaten bir rezervasyon var.Başka Tarih Seçin.");*/

        }
        
        
    }
}