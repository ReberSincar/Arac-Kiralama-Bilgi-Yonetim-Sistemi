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
    public partial class KiraGuncelle : DevExpress.XtraEditors.XtraForm
    {
        private int id, Ucret;
        private string Baslama, BaslamaSaat, Bitis, BitisSaat;

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dt_kira.Text = "";
            dt_teslim.Text = "";
            txt_kirasaat.Text = "";
            txt_teslimsaat.Text = "";
            txt_ucret.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int ucret = Convert.ToInt32(gridView2.GetFocusedRowCellValue("Ucret"));
            int a = dt_kira.DateTime.Day;
            int b = dt_teslim.DateTime.Day;
            txt_ucret.Text = Convert.ToString((b - a) * ucret);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if(dt_kira.Text=="" || dt_teslim.Text=="" || txt_kirasaat.Text=="" || txt_teslimsaat.Text=="" || txt_ucret.Text=="")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
            }
            else
            {
                string sorgu = "Update Kiralar Set Baslama=@baslama,BaslamaSaat=@bassa,Bitis=@bitis,BitisSaat=@bitsa,Ad=@ad,Soyad=@soyad,TC=@tc,Plaka=@plaka,Marka=@marka,Model=@model,Ucret=@ucret Where id=@id";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@baslama", dt_kira.Text);
                komut.Parameters.AddWithValue("@bassa", txt_kirasaat.Text);
                komut.Parameters.AddWithValue("@bitis", dt_teslim.Text);
                komut.Parameters.AddWithValue("@bitsa", txt_teslimsaat.Text);
                komut.Parameters.AddWithValue("@ad", Convert.ToString(gridView1.GetFocusedRowCellValue("Ad")));
                komut.Parameters.AddWithValue("@soyad", Convert.ToString(gridView1.GetFocusedRowCellValue("Soyad")));
                komut.Parameters.AddWithValue("@tc", Convert.ToString(gridView1.GetFocusedRowCellValue("TC")));
                komut.Parameters.AddWithValue("@plaka", Convert.ToString(gridView2.GetFocusedRowCellValue("Plaka")));
                komut.Parameters.AddWithValue("@marka", Convert.ToString(gridView2.GetFocusedRowCellValue("Marka")));
                komut.Parameters.AddWithValue("@Model", Convert.ToString(gridView2.GetFocusedRowCellValue("Model")));
                komut.Parameters.AddWithValue("@Ucret", txt_ucret.Text);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kira Güncellendi.");
                Close();
            }
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Close();
        }



        public KiraGuncelle(int id, string Baslama, string BaslamaSaat, string Bitis, string BitisSaat, int Ucret)
        {
            this.id = id;
            this.Baslama = Baslama;
            this.BaslamaSaat = BaslamaSaat;
            this.Bitis = Bitis;
            this.BitisSaat = BitisSaat;
            this.Ucret = Ucret;
            InitializeComponent();
        }

        private void KiraGuncelle_Load(object sender, EventArgs e)
        {

            SqlDataAdapter data_arac = new SqlDataAdapter("Select id,Marka,Model,Plaka,Ucret From Araclar", baglanti);
            DataSet ds_arac = new DataSet();
            baglanti.Open();
            data_arac.Fill(ds_arac, "Araclar");
            gridControl2.DataSource = ds_arac.Tables["Araclar"];
            baglanti.Close();

            SqlDataAdapter data_musteri = new SqlDataAdapter("Select id,Ad,Soyad,TC From musteri_kisisel", baglanti);
            DataSet ds_musteri = new DataSet();
            baglanti.Open();
            data_musteri.Fill(ds_musteri, "musteri_kisisel");
            gridControl1.DataSource = ds_musteri.Tables["musteri_kisisel"];
            baglanti.Close();


            dt_kira.Text = Baslama;
            dt_teslim.Text = Bitis;
            txt_kirasaat.Text = BaslamaSaat;
            txt_teslimsaat.Text = BitisSaat;
            txt_ucret.Text = Ucret.ToString();
        }
    }
}