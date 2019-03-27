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
    public partial class RezervasyonEkle : DevExpress.XtraEditors.XtraForm
    {
        public RezervasyonEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");

        void Listele()
        {
            SqlDataAdapter data_arac = new SqlDataAdapter("Select id,Marka,Model,Plaka,Ucret From Araclar where Durum !='Yasaklı'", baglanti);
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

        }
        private void Rezervasyonlar_Load(object sender, EventArgs e)
        {
            Listele();     
            dt_bas.Text= DateTime.Now.ToShortDateString();
            dt_son.Text= DateTime.Now.ToShortDateString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool durum = true;
            /*int durum1, durum2, durum3, durum4,durum5;
            string sorgu = "Select Baslama From Rezervasyonlar where Plaka=@plaka";
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@plaka", gridView1.GetFocusedRowCellValue("Plaka"));
            
            SqlDataReader dr = cmd.ExecuteReader();
            List<DateTime> bastarih = new List<DateTime>();
            int i = 0;
            while (dr.Read())
            {
                bastarih.Add(Convert.ToDateTime(dr["Baslama"]));
                i = i + 1;

            }
            baglanti.Close();
            dr.Close();




            string sorgu2 = "Select Bitis From Rezervasyonlar where Plaka=@p";
            SqlCommand cmd_2 = new SqlCommand(sorgu2, baglanti);
            cmd_2.Parameters.AddWithValue("@p", gridView1.GetFocusedRowCellValue("Plaka"));
            baglanti.Open();
            SqlDataReader dr2 = cmd_2.ExecuteReader();
            List<DateTime> bittarih = new List<DateTime>();
            while (dr2.Read())
            {
                bittarih.Add(Convert.ToDateTime(dr2["Bitis"]));
            }
            baglanti.Close();
            dr2.Close();


            sorgu = "Select Bitis From Kiralar where Plaka=@plaka";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@plaka", gridView1.GetFocusedRowCellValue("Plaka"));
            baglanti.Open();
            dr = cmd.ExecuteReader();
            i = 0;
            while (dr.Read())
            {
                i = i + 1;
            }
            string[] kirabitis = new string[i];
            i = 0;
            while (dr.Read())
            {
                kirabitis[i] = Convert.ToString(dr["Bitis"]);
            }
            baglanti.Close();
            dr.Close();

            for (int j = 0; j < i; j++)
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

            /*for (int j = 0; j < kirabitis.Length; j++)
            {
                DateTime KiraBit = new DateTime(kirabitis[j].Year, kirabitis[j].Month, kirabitis[j].Day);
                DateTime YeniBas = new DateTime(dt_bas.DateTime.Year, dt_bas.DateTime.Month, dt_bas.DateTime.Day);
                durum5 = DateTime.Compare(YeniBas, KiraBit);
                if (durum5 == -1)
                {
                    durum = false;
                    break;
                }
            }*/

            if (durum == true)
            {
                string tur = Convert.ToString(gridView1.GetFocusedRowCellValue("Tur"));
                if (tur == "Kara Liste" || tur == "Sakıncalı")
                {
                    DialogResult sonuc = MessageBox.Show("Seçtiğiniz Kaydın Müşteri Türü " + tur + ".Emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (sonuc == DialogResult.Yes)
                    {
                        string sorgu1 = "Insert into Rezervasyonlar(Baslama,Bitis,Ad,Soyad,TC,Plaka,Marka,Model,Ucret,Durum) values (@bas,@son,@ad,@soyad,@tc,@plaka,@marka,@model,@ucret,Durum)";
                        SqlCommand cmd1 = new SqlCommand(sorgu1, baglanti);
                        cmd1.Parameters.AddWithValue("@bas", dt_bas.Text);
                        cmd1.Parameters.AddWithValue("@son", dt_son.Text);
                        cmd1.Parameters.AddWithValue("@ad", gridView2.GetFocusedRowCellValue("Ad"));
                        cmd1.Parameters.AddWithValue("@soyad", gridView2.GetFocusedRowCellValue("Soyad"));
                        cmd1.Parameters.AddWithValue("@tc", gridView2.GetFocusedRowCellValue("TC"));
                        cmd1.Parameters.AddWithValue("@plaka", gridView1.GetFocusedRowCellValue("Plaka"));
                        cmd1.Parameters.AddWithValue("@marka", gridView1.GetFocusedRowCellValue("Marka"));
                        cmd1.Parameters.AddWithValue("@model", gridView1.GetFocusedRowCellValue("Model"));
                        cmd1.Parameters.AddWithValue("@ucret", txt_ucret.Text);
                        cmd1.Parameters.AddWithValue("@durum", "Beklemede");
                        baglanti.Open();
                        cmd1.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Rezervasyon Eklendi.");
                        Close();
                    }
                }
                else
                {
                    string sorgu3 = "Insert into Rezervasyonlar(Baslama,Bitis,Ad,Soyad,TC,Plaka,Marka,Model,Ucret,Durum) values (@bas,@son,@ad,@soyad,@tc,@plaka,@marka,@model,@ucret,@durum)";
                    SqlCommand cmd2 = new SqlCommand(sorgu3, baglanti);
                    cmd2.Parameters.AddWithValue("@bas", dt_bas.Text);
                    cmd2.Parameters.AddWithValue("@son", dt_son.Text);
                    cmd2.Parameters.AddWithValue("@ad", gridView2.GetFocusedRowCellValue("Ad"));
                    cmd2.Parameters.AddWithValue("@soyad", gridView2.GetFocusedRowCellValue("Soyad"));
                    cmd2.Parameters.AddWithValue("@tc", gridView2.GetFocusedRowCellValue("TC"));
                    cmd2.Parameters.AddWithValue("@plaka", gridView1.GetFocusedRowCellValue("Plaka"));
                    cmd2.Parameters.AddWithValue("@marka", gridView1.GetFocusedRowCellValue("Marka"));
                    cmd2.Parameters.AddWithValue("@model", gridView1.GetFocusedRowCellValue("Model"));
                    cmd2.Parameters.AddWithValue("@ucret", txt_ucret.Text);
                    cmd2.Parameters.AddWithValue("@durum", "Beklemede");
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Rezervasyon Eklendi.");
                    Close();
                }
                Listele();
            }
            /*else
                MessageBox.Show("Seçtiğiniz Tarihler Arasında Bir Rezervasyon Var Veya Araç Zaten Kirada.Başka Tarih Seçin.");*/
            
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
    }
}