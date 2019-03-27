using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Anaform
{
    public partial class Musteriler : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
        public int id;
        public string Ad, Soyad, TC,Telefon, Adres, Mail, EkBilgi, Tur;
        public string tc, nfs, baba, ana, dgmyer, dgmtarih, medeni, din, il, ilce, mahalle, cilt, aile, veryer, verneden, vertarih;

        private void btn_arackirala_Click(object sender, EventArgs e)
        {
            Form kirala = new Kirala();
            kirala.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            string TC = Convert.ToString(gridView1.GetFocusedRowCellValue("TC"));
            Form kira = new KiralıkAraclar(TC,0);
            kira.ShowDialog();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
            Form tur = new MusteriTuru(id);
            tur.ShowDialog();
            Listele();
        }

        public string eil, eilce, ebelge, evertarih, ecihaz, eduz;

        public void Listele()
        {
            SqlDataAdapter data = new SqlDataAdapter("Select * From musteri_kisisel", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            data.Fill(ds, "musteri_kisisel");
            gridControl1.DataSource = ds.Tables["musteri_kisisel"];
            baglanti.Close();
        }
        public Musteriler()
        {
            InitializeComponent();
        }

        private void btn_aracekle_Click(object sender, EventArgs e)
        {
            Form ekle = new MusteriKisisel();
            ekle.ShowDialog();
            Listele();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void txt_araad_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from musteri_kisisel where Ad like '" + txt_araad.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "musteri_kisisel");
            gridControl1.DataSource = ds.Tables["musteri_kisisel"];
            baglanti.Close();
        }

        private void txt_arasoyad_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from musteri_kisisel where Soyad like '" + txt_arasoyad.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "musteri_kisisel");
            gridControl1.DataSource = ds.Tables["musteri_kisisel"];
            baglanti.Close();
        }

        private void txt_aratel_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from musteri_kisisel where Telefon like '" + txt_aratel.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "musteri_kisisel");
            gridControl1.DataSource = ds.Tables["musteri_kisisel"];
            baglanti.Close();
        }

        private void txt_aramail_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from musteri_kisisel where Mail like '" + txt_aramail.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "musteri_kisisel");
            gridControl1.DataSource = ds.Tables["musteri_kisisel"];
            baglanti.Close();
        }

        private void txt_aratc_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from musteri_kisisel where TC like '" + txt_aratc.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "musteri_kisisel");
            gridControl1.DataSource = ds.Tables["musteri_kisisel"];
            baglanti.Close();
        }

        private void txt_musteriturara_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from musteri_kisisel where Tur like '" + txt_musteriturara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "musteri_kisisel");
            gridControl1.DataSource = ds.Tables["musteri_kisisel"];
            baglanti.Close();

        }

        private void btn_musterisil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Seçtiğiniz Kayıt Silinecek.Bu işlemden Sonra Geri Alınamaz.Onaylıyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                SqlCommand cmd = new SqlCommand("Delete from musteri_kisisel where id = @id", baglanti);
                SqlCommand cmd_kimlik = new SqlCommand("Delete from musteri_kimlik where kimlik_id = @id", baglanti);
                SqlCommand cmd_ehliyet = new SqlCommand("Delete from musteri_kisisel where ehliyet_id = @id", baglanti);
                cmd.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Kayıtlardan Silindi.");
                Listele();
            }
            

        }

        private void btn_musteriguncelle_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
            Ad = Convert.ToString(gridView1.GetFocusedRowCellValue("Ad"));
            Soyad = Convert.ToString(gridView1.GetFocusedRowCellValue("Soyad"));
            TC = Convert.ToString(gridView1.GetFocusedRowCellValue("TC"));
            Telefon = Convert.ToString(gridView1.GetFocusedRowCellValue("Telefon"));
            Adres = Convert.ToString(gridView1.GetFocusedRowCellValue("Adres"));
            Mail = Convert.ToString(gridView1.GetFocusedRowCellValue("Mail"));
            EkBilgi = Convert.ToString(gridView1.GetFocusedRowCellValue("EkBilgi"));
            Tur = Convert.ToString(gridView1.GetFocusedRowCellValue("Tur"));


            Form guncelle = new MusteriGuncelle(Ad, Soyad, TC, Telefon, Adres, Mail, EkBilgi, Tur, tc, nfs, baba, ana, dgmyer, dgmtarih, medeni, din, il, ilce, mahalle, cilt, aile, veryer, verneden, vertarih,eil, eilce, ebelge, evertarih, ecihaz, eduz);
            guncelle.ShowDialog();
            Listele();
        }
    }
}