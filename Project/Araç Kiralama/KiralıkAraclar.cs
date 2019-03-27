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
    public partial class KiralıkAraclar : DevExpress.XtraEditors.XtraForm
    {
        private string Plaka;
        private int kontrol;
        public KiralıkAraclar(string Plaka,int kontrol)
        {
            this.Plaka = Plaka;
            this.kontrol = kontrol;
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");

        public void Listele()
        {
            SqlDataAdapter data_kira = new SqlDataAdapter("Select * From Kiralar", baglanti);
            DataSet ds_kira = new DataSet();
            baglanti.Open();
            data_kira.Fill(ds_kira, "Kiralar");
            gridControl1.DataSource = ds_kira.Tables["Kiralar"];
            baglanti.Close();
        }

        private void KiralıkAraclar_Load(object sender, EventArgs e)
        {
            Listele();
            checkEdit2.Checked = false;
            if (kontrol == 1)
                checkEdit2.Checked = true;
            if(Plaka.Length==11)
            {
                txt_tcara.Text = Plaka;
            }
            else
                txt_plakaara.Text = Plaka;
        }

        private void txt_plakaara_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Kiralar where Plaka like '" + txt_plakaara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Kiralar");
            gridControl1.DataSource = ds.Tables["Kiralar"];
            baglanti.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Seçtiğiniz Kayıt Silinecek.Bu işlemden Sonra Geri Alınamaz.Onaylıyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                SqlCommand cmd = new SqlCommand("Delete from Kiralar where id = @id", baglanti);
                cmd.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kira Kayıtlardan Silindi.");
                Listele();
            }
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
            string Baslama = Convert.ToString(gridView1.GetFocusedRowCellValue("Baslama"));
            string BaslamaSaat = Convert.ToString(gridView1.GetFocusedRowCellValue("BaslamaSaat"));
            string Bitis = Convert.ToString(gridView1.GetFocusedRowCellValue("Bitis"));
            string BitisSaat = Convert.ToString(gridView1.GetFocusedRowCellValue("BitisSaat"));
            int Ucret = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Ucret"));
            Form guncelle = new KiraGuncelle(id,Baslama,BaslamaSaat,Bitis,BitisSaat,Ucret);
            guncelle.ShowDialog();
            Listele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Form kirala = new Kirala();
            kirala.ShowDialog();
            Listele();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                SqlDataAdapter data_kira = new SqlDataAdapter("Select * From Kiralar where Durum='Kirada'", baglanti);
                DataSet ds_kira = new DataSet();
                baglanti.Open();
                data_kira.Fill(ds_kira, "Kiralar");
                gridControl1.DataSource = ds_kira.Tables["Kiralar"];
                baglanti.Close();
            }
            else
                Listele();
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            

            
            string Durum = Convert.ToString(gridView1.GetFocusedRowCellValue("Durum"));
            if (Durum == "Kirada")
            {
                DialogResult sonuc = MessageBox.Show("Seçtiğiniz Aracı Teslim Almak Üzeresiniz. Emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.Yes)
                {
                    string sorgu = "Update Kiralar Set Durum='Teslim' Where id=@id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", Convert.ToString(gridView1.GetFocusedRowCellValue("id")));
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    
                    sorgu = "Update Araclar Set Durum='Elimizde' Where Plaka=@plaka";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@plaka", Convert.ToString(gridView1.GetFocusedRowCellValue("Plaka")));
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Araç Teslim Alındı.");
                    Listele();
                }

            }
            else
            {
                MessageBox.Show("Seçtiğiniz Araç Zaten Teslim Alınmış.");
            }
        }

        private void txt_tcara_EditValueChanged_1(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Kiralar where TC like '" + txt_tcara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Kiralar");
            gridControl1.DataSource = ds.Tables["Kiralar"];
            baglanti.Close();
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked)
            {
                string tarih =DateTime.Today.ToShortDateString();
                SqlCommand komut = new SqlCommand("Select * From Kiralar Where Bitis=@bitis", baglanti);
                komut.Parameters.AddWithValue("@bitis", tarih);
                SqlDataAdapter data_kira = new SqlDataAdapter(komut);
                DataSet ds_kira = new DataSet();
                baglanti.Open();
                data_kira.Fill(ds_kira, "Kiralar");
                gridControl1.DataSource = ds_kira.Tables["Kiralar"];
                baglanti.Close();
            }
            else
                Listele();
        }
    }
}