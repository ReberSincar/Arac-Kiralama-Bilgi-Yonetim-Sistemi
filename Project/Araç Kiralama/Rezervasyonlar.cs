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
    public partial class Rezervasyonlar : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
        public int id,Ucret;
        public string Baslama, Bitis;
        public Rezervasyonlar()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            SqlDataAdapter data_bakim = new SqlDataAdapter("Select id,Baslama,Bitis,Ad,Soyad,TC,Plaka,Marka,Model,Ucret,Durum From Rezervasyonlar", baglanti);
            DataSet ds_bakim = new DataSet();
            baglanti.Open();
            data_bakim.Fill(ds_bakim, "Rezervasyonlar");
            gridControl1.DataSource = ds_bakim.Tables["Rezervasyonlar"];
            baglanti.Close();
        }

        private void Rezervasyonlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Form ekle = new RezervasyonEkle();
            ekle.ShowDialog();
            Listele();
        }

        private void txt_plakaara_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Rezervasyonlar where Plaka like '" + txt_plakaara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Rezervasyonlar");
            gridControl1.DataSource = ds.Tables["Rezervasyonlar"];
            baglanti.Close();
        }

        private void txt_tcara_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Rezervasyonlar where TC like '" + txt_tcara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Rezervasyonlar");
            gridControl1.DataSource = ds.Tables["Rezervasyonlar"];
            baglanti.Close();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                SqlDataAdapter data_rezervasyon = new SqlDataAdapter("Select * From Rezervasyonlar where Durum='Beklemede'", baglanti);
                DataSet ds_rezervasyon = new DataSet();
                baglanti.Open();
                data_rezervasyon.Fill(ds_rezervasyon, "Rezervasyonlar");
                gridControl1.DataSource = ds_rezervasyon.Tables["Rezervasyonlar"];
                baglanti.Close();
            }
            else
                Listele();
        }

        private void btn_kirala_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Seçtiğiniz Rezervasyon İşlemi Sonlanıp Araç Müşteriye Kiralanacaktır.Onaylıyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                string sorgu = "Insert into Kiralar(Baslama,BaslamaSaat,Bitis,BitisSaat,Ad,Soyad,TC,Plaka,Marka,Model,Ucret,Durum) values (@bastar,@bassa,@bittar,@bitsa,@ad,@soyad,@tc,@plaka,@marka,@model,@ucret,@durum)";
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@bastar", Convert.ToString(gridView1.GetFocusedRowCellValue("Baslama")));
                cmd.Parameters.AddWithValue("@bassa", "12:00:00");
                cmd.Parameters.AddWithValue("@bittar", Convert.ToString(gridView1.GetFocusedRowCellValue("Bitis")));
                cmd.Parameters.AddWithValue("@bitsa", "12:00:00");
                cmd.Parameters.AddWithValue("@ad", Convert.ToString(gridView1.GetFocusedRowCellValue("Ad")));
                cmd.Parameters.AddWithValue("@soyad", Convert.ToString(gridView1.GetFocusedRowCellValue("Soyad")));
                cmd.Parameters.AddWithValue("@tc", Convert.ToString(gridView1.GetFocusedRowCellValue("TC")));
                cmd.Parameters.AddWithValue("@plaka", Convert.ToString(gridView1.GetFocusedRowCellValue("Plaka")));
                cmd.Parameters.AddWithValue("@marka", Convert.ToString(gridView1.GetFocusedRowCellValue("Marka")));
                cmd.Parameters.AddWithValue("@model", Convert.ToString(gridView1.GetFocusedRowCellValue("Model")));
                cmd.Parameters.AddWithValue("@ucret", Convert.ToString(gridView1.GetFocusedRowCellValue("Ucret")));
                cmd.Parameters.AddWithValue("@durum", "Kirada");

                string sorgu2 = "Update Araclar Set Durum='Kirada' Where Plaka=@plaka";
                SqlCommand cmd_2 = new SqlCommand(sorgu2, baglanti);
                cmd_2.Parameters.AddWithValue("@plaka", gridView1.GetFocusedRowCellValue("Plaka"));

                string sorgu3 = "Update Rezervasyonlar Set Durum='Kiralandı' Where Plaka=@plaka and TC=@tc and Baslama=@baslama ";
                SqlCommand cmd_3 = new SqlCommand(sorgu3, baglanti);
                cmd_3.Parameters.AddWithValue("@plaka", gridView1.GetFocusedRowCellValue("Plaka"));
                cmd_3.Parameters.AddWithValue("@tc", gridView1.GetFocusedRowCellValue("TC"));
                cmd_3.Parameters.AddWithValue("@baslama", gridView1.GetFocusedRowCellValue("Baslama"));


                baglanti.Open();
                cmd.ExecuteNonQuery();
                cmd_2.ExecuteNonQuery();
                cmd_3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Araç Kiralandı.");
                Listele();
            }
            
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked)
            {
                string tarih = DateTime.Today.ToShortDateString();
                SqlCommand komut = new SqlCommand("Select * From Rezervasyonlar Where Baslama=@baslama", baglanti);
                komut.Parameters.AddWithValue("@baslama", tarih);
                SqlDataAdapter data_rzv = new SqlDataAdapter(komut);
                DataSet ds_rzv = new DataSet();
                baglanti.Open();
                data_rzv.Fill(ds_rzv, "Rezervasyonlar");
                gridControl1.DataSource = ds_rzv.Tables["Rezervasyonlar"];
                baglanti.Close();
            }
            else
                Listele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Seçtiğiniz Kayıt Silinecek.Bu işlemden Sonra Geri Alınamaz.Onaylıyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                SqlCommand cmd = new SqlCommand("Delete from Rezervasyonlar where id = @id", baglanti);
                cmd.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Rezervasyon Kayıtlardan Silindi.");
                Listele();
            }
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
            Baslama = Convert.ToString(gridView1.GetFocusedRowCellValue("Baslama"));
            Bitis = Convert.ToString(gridView1.GetFocusedRowCellValue("Bitis"));
            Ucret= Convert.ToInt32(gridView1.GetFocusedRowCellValue("Ucret"));
            Form guncelle = new Rezervasyonguncelle(id, Baslama, Bitis,Ucret);
            guncelle.ShowDialog();
            Listele();
        }
    }
}