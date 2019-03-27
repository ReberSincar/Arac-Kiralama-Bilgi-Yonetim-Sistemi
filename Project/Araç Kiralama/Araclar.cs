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
    public partial class Araclar : DevExpress.XtraEditors.XtraForm
    {
        public Araclar()
        {
            InitializeComponent();
        }
        public bool Secim = false;
        public static int id;
        public string Marka;
        public string Model;
        public string Plaka;
        public string Yil;
        public string Motor;
        public string Renk;
        public string Yakit;
        public string Ucret;
        public string Durum;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");


        public void Listele()
        {
            SqlDataAdapter data = new SqlDataAdapter("Select *From Araclar", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            data.Fill(ds, "Araclar");
            Grid_arac.DataSource = ds.Tables["Araclar"];
            baglanti.Close();
        }

        private void araclar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        
        private void btn_aracekle_Click_1(object sender, EventArgs e)
        {
            Form arac_ekle = new AracEkle();
            arac_ekle.ShowDialog();
            Listele();
        }

        private void btn_aracsil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Seçtiğiniz Kayıt Silinecek.Bu işlemden Sonra Geri Alınamaz.Onaylıyor musunuz?","ONAY",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(sonuc==DialogResult.Yes)
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                SqlCommand cmd = new SqlCommand("Delete from Araclar where id = @id", baglanti);
                cmd.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Araç Kayıtlardan Silindi.");
                Listele();
            }          


        }

        private void Araclar_Load_1(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_aracguncelle_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
            Marka = Convert.ToString(gridView1.GetFocusedRowCellValue("Marka"));
            Model = Convert.ToString(gridView1.GetFocusedRowCellValue("Model"));
            Plaka = Convert.ToString(gridView1.GetFocusedRowCellValue("Plaka"));
            Yil = Convert.ToString(gridView1.GetFocusedRowCellValue("Yil"));
            Motor = Convert.ToString(gridView1.GetFocusedRowCellValue("Motor"));
            Renk = Convert.ToString(gridView1.GetFocusedRowCellValue("Renk"));
            Yakit = Convert.ToString(gridView1.GetFocusedRowCellValue("Yakit"));
            Ucret = Convert.ToString(gridView1.GetFocusedRowCellValue("Ucret"));
            Durum = Convert.ToString(gridView1.GetFocusedRowCellValue("Durum"));
            Form arac_guncelle = new AracGuncelle(Marka,Model,Plaka,Yil,Renk, Motor, Yakit,Ucret,Durum);
            arac_guncelle.ShowDialog();
            Listele();


        }

        private void txt_aracmodelara_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Araclar where Model like '" + txt_aracmodelara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Araclar");
            Grid_arac.DataSource = ds.Tables["Araclar"];
            baglanti.Close();
        }

        private void txt_aracplakaara_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Araclar where Plaka like '" + txt_aracplakaara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Araclar");
            Grid_arac.DataSource = ds.Tables["Araclar"];
            baglanti.Close();
        }

        private void txt_aracyilara_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Araclar where Yil like '" + txt_aracyilara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Araclar");
            Grid_arac.DataSource = ds.Tables["Araclar"];
            baglanti.Close();
        }

        private void txt_aracrenkara_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Araclar where Renk like '" + txt_aracrenkara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Araclar");
            Grid_arac.DataSource = ds.Tables["Araclar"];
            baglanti.Close();
        }

        private void txt_aracucretara_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Araclar where Ucret like '" + txt_aracucretara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Araclar");
            Grid_arac.DataSource = ds.Tables["Araclar"];
            baglanti.Close();
        }

        private void txt_aracyakitara_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Araclar where Yakit like '" + txt_aracyakitara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Araclar");
            Grid_arac.DataSource = ds.Tables["Araclar"];
            baglanti.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txt_aracmarkaara.Text = "";
            txt_aracmodelara.Text = "";
            txt_aracplakaara.Text = "";
            txt_aracyilara.Text = "";
            txt_aracrenkara.Text = "";
            txt_aracyakitara.Text = "";
            txt_aracucretara.Text = "";
        }

        private void txt_aracmarkaara_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Araclar where Marka like '" + txt_aracmarkaara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Araclar");
            Grid_arac.DataSource = ds.Tables["Araclar"];
            baglanti.Close();
        }

        private void txt_aracdurumara_EditValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Araclar where Durum like '" + txt_aracdurumara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Araclar");
            Grid_arac.DataSource = ds.Tables["Araclar"];
            baglanti.Close();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Araclar where Durum like '" + txt_aracdurumara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Araclar");
            Grid_arac.DataSource = ds.Tables["Araclar"];
            baglanti.Close();
        }

        private void btn_aracrezerve_Click(object sender, EventArgs e)
        {
            Form rezervasyon = new RezervasyonEkle();
            rezervasyon.ShowDialog();
            Listele();
        }

        private void checkEdit1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(checkEdit1.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select *from Araclar where Durum='Elimizde'", baglanti);
                DataSet ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "Araclar");
                Grid_arac.DataSource = ds.Tables["Araclar"];
                baglanti.Close();
            }
            else
            {
                Listele();
            }
            
        }

        private void btn_aracyasakla_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
            string Durum = Convert.ToString(gridView1.GetFocusedRowCellValue("Durum"));
            if(Durum == "Kirada")
            {
                MessageBox.Show("Seçtiğiniz Araç Kirada.Yasaklayamazsınız.");
            }
            else if(Durum == "Yasaklı")
            {
                MessageBox.Show("Seçtiğiniz Araç Zaten Yasaklı.");
            }
            else
            {
                DialogResult sonuc = MessageBox.Show("Seçtiğiniz Aracı Yasaklamak Üzeresiniz. Emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.Yes)
                {
                    string sorgu = "Update Araclar Set Durum='Yasaklı' Where id=@id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", id);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Araç Yasaklandı.");
                    Listele();
                }
            }
            

        }

        private void btn_aracyasakkaldir_Click(object sender, EventArgs e)
        {


            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
            string Durum = Convert.ToString(gridView1.GetFocusedRowCellValue("Durum"));
            if (Durum == "Yasaklı")
            {
                DialogResult sonuc = MessageBox.Show("Seçtiğiniz Aracın Yasağını Kaldırmak Üzeresiniz. Emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.Yes)
                {
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                    string sorgu = "Update Araclar Set Durum='Elimizde' Where id=@id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", id);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Araç Yasağı Kaldırıldı.");
                    Listele();
                }

            }
            else
            {
                MessageBox.Show("Seçtiğiniz Araç Yasaklı Değil.");
            }

        }

        private void btn_bakimal_Click(object sender, EventArgs e)
        {
            string Durum = Convert.ToString(gridView1.GetFocusedRowCellValue("Durum"));
            if (Durum == "Kirada")
            {
                MessageBox.Show("Seçtiğiniz Araç Kirada.Bakıma Alamazsınız.");
            }
            else if (Durum == "Bakımda")
            {
                MessageBox.Show("Seçtiğiniz Araç Zaten Bakımda.");
            }
            else
            {
                Form ekle = new Bakimekle();
                ekle.ShowDialog();
                Listele();
                
            }
        }

        private void btn_bakimbitir_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
            string Durum = Convert.ToString(gridView1.GetFocusedRowCellValue("Durum"));
            
            if (Durum == "Bakımda")
            {
                DialogResult sonuc = MessageBox.Show("Seçtiğiniz Aracın Bakımını Bitirmek Üzeresiniz. Emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.Yes)
                {
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
                    string sorgu = "Update Araclar Set Durum='Elimizde' Where id=@id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", id);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();


                    sorgu = "Update Bakimlar Set Durum='Teslim' Where Plaka=@plaka";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@plaka", Convert.ToString(gridView1.GetFocusedRowCellValue("Plaka")));
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Araç Bakımı Bitti.");
                    Listele();
                }

            }
            else
            {
                MessageBox.Show("Seçtiğiniz Araç Bakımda Değil.");
            }
            
        }

        private void btn_gecmisbakim_Click(object sender, EventArgs e)
        {
            Plaka = Convert.ToString(gridView1.GetFocusedRowCellValue("Plaka"));
            Form bakimlar = new Bakimlar(Plaka);
            bakimlar.ShowDialog();
        }

        private void btn_arackira_Click(object sender, EventArgs e)
        {

            Form kirala = new Kirala();
            kirala.ShowDialog();
            Listele();
        }

        private void btn_aracgiderleri_Click(object sender, EventArgs e)
        {
            Plaka = Convert.ToString(gridView1.GetFocusedRowCellValue("Plaka"));
            Form kira = new KiralıkAraclar(Plaka,0);
            kira.ShowDialog();
        }

        private void btn_aracteslim_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
            string Durum = Convert.ToString(gridView1.GetFocusedRowCellValue("Durum"));
            if(Durum == "Kirada")
            {
                DialogResult sonuc = MessageBox.Show("Seçtiğiniz Aracı Teslim Almak Üzeresiniz. Emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.Yes)
                {
                    string sorgu = "Update Araclar Set Durum='Elimizde' Where id=@id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", id);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    sorgu = "Update Kiralar Set Durum='Teslim' Where Plaka=@plaka";
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
                MessageBox.Show("Seçtiğiniz Araç Kirada Değil.");
            }
            
        }
    }
}