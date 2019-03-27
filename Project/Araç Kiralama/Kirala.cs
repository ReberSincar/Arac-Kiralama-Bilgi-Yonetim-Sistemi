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
    public partial class Kirala : DevExpress.XtraEditors.XtraForm
    {
        public Kirala()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
        private void Kirala_Load(object sender, EventArgs e)
        {
            SqlDataAdapter data_arac = new SqlDataAdapter("Select id,Marka,Model,Plaka,Ucret From Araclar where Durum='Elimizde'", baglanti);
            DataSet ds_arac = new DataSet();
            baglanti.Open();
            data_arac.Fill(ds_arac, "Araclar");
            gridControl2.DataSource = ds_arac.Tables["Araclar"];
            baglanti.Close();

            SqlDataAdapter data_musteri = new SqlDataAdapter("Select id,Ad,Soyad,TC,Tur From musteri_kisisel", baglanti);
            DataSet ds_musteri = new DataSet();
            baglanti.Open();
            data_musteri.Fill(ds_musteri, "musteri_kisisel");
            gridControl1.DataSource = ds_musteri.Tables["musteri_kisisel"];
            baglanti.Close();

            dt_kira.Text= DateTime.Now.ToShortDateString();
            dt_teslim.Text= DateTime.Now.ToShortDateString(); ;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime baslamaTarihi = new DateTime(Convert.ToInt32(dt_kira.DateTime.Year), Convert.ToInt32(dt_kira.DateTime.Month), Convert.ToInt32(dt_kira.DateTime.Day));
            DateTime bitisTarihi = new DateTime(Convert.ToInt32(dt_teslim.DateTime.Year), Convert.ToInt32(dt_teslim.DateTime.Month), Convert.ToInt32(dt_teslim.DateTime.Day));

            TimeSpan kalangun = bitisTarihi - baslamaTarihi;
            double toplamGun = kalangun.TotalDays;

            int ucret = Convert.ToInt32(gridView2.GetFocusedRowCellValue("Ucret"));
            txt_ucret.Text = (toplamGun*ucret).ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dt_kira.Text = "";
            dt_teslim.Text = "";
            txt_kirasaat.Text = "";
            txt_teslimsaat.Text = "";
            txt_ucret.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (dt_kira.Text == "" || dt_teslim.Text == "" || txt_kirasaat.Text == "" || txt_teslimsaat.Text == "" || txt_ucret.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
            }
            else
            {
                string tur = Convert.ToString(gridView1.GetFocusedRowCellValue("Tur"));
                if (tur == "Kara Liste" || tur == "Sakıncalı")
                {
                    DialogResult sonuc = MessageBox.Show("Seçtiğiniz Kaydın Müşteri Türü " + tur + ".Emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (sonuc == DialogResult.Yes)
                    {
                        string sorgu = "Insert into Kiralar(Baslama,BaslamaSaat,Bitis,BitisSaat,Ad,Soyad,TC,Plaka,Marka,Model,Ucret,Durum) values (@bastar,@bassa,@bittar,@bitsa,@ad,@soyad,@tc,@plaka,@marka,@model,@ucret,@durum)";
                        SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                        cmd.Parameters.AddWithValue("@bastar", dt_kira.Text);
                        cmd.Parameters.AddWithValue("@bassa", txt_kirasaat.Text);
                        cmd.Parameters.AddWithValue("@bittar", dt_teslim.Text);
                        cmd.Parameters.AddWithValue("@bitsa", txt_teslimsaat.Text);
                        cmd.Parameters.AddWithValue("@ad", Convert.ToString(gridView1.GetFocusedRowCellValue("Ad")));
                        cmd.Parameters.AddWithValue("@soyad", Convert.ToString(gridView1.GetFocusedRowCellValue("Soyad")));
                        cmd.Parameters.AddWithValue("@tc", Convert.ToString(gridView1.GetFocusedRowCellValue("TC")));
                        cmd.Parameters.AddWithValue("@plaka", Convert.ToString(gridView2.GetFocusedRowCellValue("Plaka")));
                        cmd.Parameters.AddWithValue("@marka", Convert.ToString(gridView2.GetFocusedRowCellValue("Marka")));
                        cmd.Parameters.AddWithValue("@model", Convert.ToString(gridView2.GetFocusedRowCellValue("Model")));
                        cmd.Parameters.AddWithValue("@ucret", txt_ucret.Text);
                        cmd.Parameters.AddWithValue("@durum", "Kirada");

                        string sorgu2 = "Update Araclar Set Durum='Kirada' Where Plaka=@plaka";
                        SqlCommand komut = new SqlCommand(sorgu2, baglanti);
                        komut.Parameters.AddWithValue("@plaka", gridView2.GetFocusedRowCellValue("Plaka"));


                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Araç Kiralandı.");
                        Close();
                    }
                }
                else
                {
                    string sorgu = "Insert into Kiralar(Baslama,BaslamaSaat,Bitis,BitisSaat,Ad,Soyad,TC,Plaka,Marka,Model,Ucret,Durum) values (@bastar,@bassa,@bittar,@bitsa,@ad,@soyad,@tc,@plaka,@marka,@model,@ucret,@durum)";
                    SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                    cmd.Parameters.AddWithValue("@bastar", dt_kira.Text);
                    cmd.Parameters.AddWithValue("@bassa", txt_kirasaat.Text);
                    cmd.Parameters.AddWithValue("@bittar", dt_teslim.Text);
                    cmd.Parameters.AddWithValue("@bitsa", txt_teslimsaat.Text);
                    cmd.Parameters.AddWithValue("@ad", Convert.ToString(gridView1.GetFocusedRowCellValue("Ad")));
                    cmd.Parameters.AddWithValue("@soyad", Convert.ToString(gridView1.GetFocusedRowCellValue("Soyad")));
                    cmd.Parameters.AddWithValue("@tc", Convert.ToString(gridView1.GetFocusedRowCellValue("TC")));
                    cmd.Parameters.AddWithValue("@plaka", Convert.ToString(gridView2.GetFocusedRowCellValue("Plaka")));
                    cmd.Parameters.AddWithValue("@marka", Convert.ToString(gridView2.GetFocusedRowCellValue("Marka")));
                    cmd.Parameters.AddWithValue("@model", Convert.ToString(gridView2.GetFocusedRowCellValue("Model")));
                    cmd.Parameters.AddWithValue("@ucret", txt_ucret.Text);
                    cmd.Parameters.AddWithValue("@durum", "Kirada");

                    string sorgu2 = "Update Araclar Set Durum='Kirada' Where Plaka=@plaka";
                    SqlCommand komut = new SqlCommand(sorgu2, baglanti);
                    komut.Parameters.AddWithValue("@plaka", gridView2.GetFocusedRowCellValue("Plaka"));


                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Araç Kiralandı.");
                    Close();
                }
            }

        }
            
    }
}