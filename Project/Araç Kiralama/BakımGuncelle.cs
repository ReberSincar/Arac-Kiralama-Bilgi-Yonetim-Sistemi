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
    public partial class BakımGuncelle : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        private string Plaka, Ariza, Tarih, Kisi, Yer, Telefon, Tutar, Icerik;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");

        private void BakımGuncelle_Load(object sender, EventArgs e)
        {
            txt_tarih.Text= DateTime.Now.ToShortDateString();
            txt_ariza.Text = Ariza;
            txt_tarih.Text = Tarih;
            txt_kisi.Text = Kisi;
            txt_yer.Text = Yer;
            txt_tel.Text = Telefon;
            txt_tutar.Text = Tutar;
            txt_icerik.Text = Icerik;

            SqlDataAdapter data = new SqlDataAdapter("Select Marka,Model,Plaka From Araclar where Durum='Elimizde'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            data.Fill(ds, "Araclar");
            gridControl1.DataSource = ds.Tables["Araclar"];
            baglanti.Close();
        }

        
        public BakımGuncelle(int id, string Plaka, string Ariza, string Tarih, string Kisi, string Yer, string Telefon, string Tutar, string Icerik)
        {
            this.id = id;
            this.Plaka = Plaka;
            this.Ariza = Ariza;
            this.Tarih = Tarih;
            this.Kisi = Kisi;
            this.Yer = Yer;
            this.Telefon = Telefon;
            this.Tutar = Tutar;
            this.Icerik = Icerik;
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_ariza.Text = "";
            txt_tarih.Text = "";
            txt_kisi.Text = "";
            txt_yer.Text = "";
            txt_tel.Text = "";
            txt_tutar.Text = "";
            txt_icerik.Text = "";
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
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
            if (txt_tarih.Text == "")
            {
                if (durum == true)
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
                }
                durum = false;
            }

            if (durum == true)
            {
                DialogResult sonuc = MessageBox.Show("Seçtiğiniz Aracı Bakıma Almak Üzeresiniz. Emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.Yes)
                {
                    string sorgu = "Update Bakimlar Set Plaka=@plaka,Ariza=@ariza,Kisi=@Kisi,Yer=@yer,Telefon=@tel,Tutar=@tutar,Icerik=@icerik Where id=@id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@plaka", Convert.ToString(gridView1.GetFocusedRowCellValue("Plaka")));
                    komut.Parameters.AddWithValue("@ariza", txt_ariza.Text);
                    komut.Parameters.AddWithValue("@kisi", txt_kisi.Text);
                    komut.Parameters.AddWithValue("@yer", txt_yer.Text);
                    komut.Parameters.AddWithValue("@tel", txt_tel.Text);
                    komut.Parameters.AddWithValue("@tutar", txt_tutar.Text);
                    komut.Parameters.AddWithValue("@icerik", txt_icerik.Text);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Bakım Güncellendi.");
                    Close();
                }
            }
            

        }
    }
}