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
    public partial class Bakimekle : DevExpress.XtraEditors.XtraForm
    {
        
        public Bakimekle()
        {
            
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txt_ariza.Text = "";
            txt_tarih.Text = "";
            txt_kisi.Text = "";
            txt_yer.Text = "";
            txt_tel.Text = "";
            txt_tutar.Text = "";
            txt_icerik.Text = "";
        }

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
            if(txt_tarih.Text=="")
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
                    SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
                    string sorgu = "Insert into Bakimlar(Plaka,Ariza,Tarih,Kisi,Yer,Telefon,Tutar,Icerik,Durum) values (@plaka,@ariza,@tarih,@kisi,@yer,@tel,@tutar,@icerik,@durum)";
                    SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                    cmd.Parameters.AddWithValue("@plaka", Convert.ToString(gridView1.GetFocusedRowCellValue("Plaka")));
                    cmd.Parameters.AddWithValue("@ariza", txt_ariza.Text);
                    cmd.Parameters.AddWithValue("@tarih", txt_tarih.Text);
                    cmd.Parameters.AddWithValue("@kisi", txt_kisi.Text);
                    cmd.Parameters.AddWithValue("@yer", txt_yer.Text);
                    cmd.Parameters.AddWithValue("@tel", txt_tel.Text);
                    cmd.Parameters.AddWithValue("@tutar", txt_tutar.Text);
                    cmd.Parameters.AddWithValue("@icerik", txt_icerik.Text);
                    cmd.Parameters.AddWithValue("@durum", "Bakımda");
                    baglanti.Open();
                    cmd.ExecuteNonQuery();


                    SqlCommand komut = new SqlCommand("Update Araclar Set Durum='Bakımda' Where Plaka=@plaka", baglanti);
                    komut.Parameters.AddWithValue("@plaka", Convert.ToString(gridView1.GetFocusedRowCellValue("Plaka")));
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Bakım Eklendi.");
                    Close();
                }
            }
            
        }

        private void Bakimekle_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");

            SqlDataAdapter data = new SqlDataAdapter("Select Marka,Model,Plaka From Araclar where Durum='Elimizde'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            data.Fill(ds, "Araclar");
            gridControl1.DataSource = ds.Tables["Araclar"];
            baglanti.Close();
            txt_tarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}