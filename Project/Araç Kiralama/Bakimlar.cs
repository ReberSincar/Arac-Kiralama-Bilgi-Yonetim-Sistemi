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
    public partial class Bakimlar : DevExpress.XtraEditors.XtraForm
    {
        public int id;
        public string Plaka, Ariza, Tarih, Kisi, Yer, Telefon, Tutar, Icerik;
        public string Plakara;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");

        private void btn_bakimbitir_Click(object sender, EventArgs e)
        {
            string Plaka = Convert.ToString(gridView1.GetFocusedRowCellValue("Plaka"));
            string Durum = Convert.ToString(gridView1.GetFocusedRowCellValue("Durum"));

            if (Durum == "Bakımda")
            {
                DialogResult sonuc = MessageBox.Show("Seçtiğiniz Aracın Bakımını Bitirmek Üzeresiniz. Emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.Yes)
                {
                    
                    string sorgu = "Update Araclar Set Durum='Elimizde' Where Plaka=@plaka";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@plaka", Plaka);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    
                    

                    sorgu = "Update Bakimlar Set Durum='Teslim' Where id=@id";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", Convert.ToInt32(gridView1.GetFocusedRowCellValue("id")));
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Araç Bakımı Bitti.");
                    Listele();

                }

            }
            else
            {
                MessageBox.Show("Seçtiğiniz Araç Zaten Teslim Alınmış.");
            }

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                SqlDataAdapter data_kira = new SqlDataAdapter("Select * From Bakimlar where Durum='Bakımda'", baglanti);
                DataSet ds_bakim = new DataSet();
                baglanti.Open();
                data_kira.Fill(ds_bakim, "Bakimlar");
                gridControl1.DataSource = ds_bakim.Tables["Bakimlar"];
                baglanti.Close();
            }
            else
                Listele();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Bakimlar where Plaka like '" + textEdit1.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Bakimlar");
            gridControl1.DataSource = ds.Tables["Bakimlar"];
            baglanti.Close();
        }

        
        public Bakimlar(string Plaka)
        {
            this.Plakara = Plaka;
            InitializeComponent();
        }

       public void Listele()
        {
            
            SqlDataAdapter data_bakim = new SqlDataAdapter("Select * From Bakimlar", baglanti);
            DataSet ds_bakim = new DataSet();
            baglanti.Open();
            data_bakim.Fill(ds_bakim, "Bakimlar");
            gridControl1.DataSource = ds_bakim.Tables["Bakimlar"];
            baglanti.Close();
        }

        private void Bakımlar_Load(object sender, EventArgs e)
        {
            
            Listele();
            textEdit1.Text = Plakara;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Form ekle = new Bakimekle();
            ekle.ShowDialog();
            Listele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Seçtiğiniz Kayıt Silinecek.Bu işlemden Sonra Geri Alınamaz.Onaylıyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                SqlCommand cmd = new SqlCommand("Delete from Bakimlar where id = @id", baglanti);
                cmd.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bakim Kayıtlardan Silindi.");
                Listele();
            }
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
            Plaka = Convert.ToString(gridView1.GetFocusedRowCellValue("Plaka"));
            Ariza = Convert.ToString(gridView1.GetFocusedRowCellValue("Ariza"));
            Tarih = Convert.ToString(gridView1.GetFocusedRowCellValue("Tarih"));
            Kisi = Convert.ToString(gridView1.GetFocusedRowCellValue("Kisi"));
            Yer = Convert.ToString(gridView1.GetFocusedRowCellValue("Yer"));
            Telefon = Convert.ToString(gridView1.GetFocusedRowCellValue("Telefon"));
            Tutar = Convert.ToString(gridView1.GetFocusedRowCellValue("Tutar"));
            Icerik = Convert.ToString(gridView1.GetFocusedRowCellValue("Icerik"));
            Form bakim = new BakımGuncelle(id,Plaka,Ariza,Tarih,Kisi,Yer,Telefon,Tutar,Icerik);
            bakim.ShowDialog();
            Listele();
        }
    }
}