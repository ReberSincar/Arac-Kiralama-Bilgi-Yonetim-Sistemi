using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Anaform
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");

        public void Listele()
        {
            
            SqlDataAdapter data_arac = new SqlDataAdapter("Select Marka,Model,Plaka,Ucret From Araclar Where Durum='Elimizde'", baglanti);
            DataSet ds_arac = new DataSet();            
            baglanti.Open();
            data_arac.Fill(ds_arac, "Araclar");            
            grd_arac.DataSource = ds_arac.Tables["Araclar"];
            
            

            SqlDataAdapter data_musteri = new SqlDataAdapter("Select Ad,Soyad,Telefon,Tur From musteri_kisisel", baglanti);
            DataSet ds_musteri = new DataSet();
            data_musteri.Fill(ds_musteri, "musteri_kisisel");
            grd_musteri.DataSource = ds_musteri.Tables["musteri_kisisel"];

            

            SqlDataAdapter data_kira = new SqlDataAdapter("Select Baslama,Bitis,Ad,Soyad,Marka,Model,Plaka From Kiralar where Durum='Kirada'", baglanti);
            DataSet ds_kira = new DataSet();
            data_kira.Fill(ds_kira, "Kiralar");
            grd_kira.DataSource = ds_kira.Tables["Kiralar"];

            baglanti.Close();
           


        }

        private void rbn_btn_araclar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form arac = new Araclar();
            arac.ShowDialog();
            Listele();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            Listele();
            this.Show();
            timer1.Start();
            timer2.Start();
            timer2.Interval = 150;
            timer1.Interval = 100;
        }
        



        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form rezervasyon = new Rezervasyonlar();
            rezervasyon.ShowDialog();
            Listele();
        }
                       
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form kirala = new Kirala();
            kirala.ShowDialog();
            Listele();
        }

        private void rbn_btn_musteriler_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form musteri = new Musteriler();
            musteri.ShowDialog();
            Listele();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string Plaka = "";
            Form bakim = new Bakimlar(Plaka);
            bakim.ShowDialog();
            Listele();
        }

        private void btn_kiraraclar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string Plaka = "";
            Form kira = new KiralıkAraclar(Plaka,0);
            kira.ShowDialog();
            Listele();
        }

        private void btn_paroladegistir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form pd = new ParolaDegistir();
            pd.ShowDialog();
        }

        private void btn_kilit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            Form log = new Login();
            log.Show();
        }

        private void btn_kirala_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form kirala = new Kirala();
            kirala.ShowDialog();
            Listele();
        }

        private void AnaFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sorgu = "Select Bitis From Kiralar";
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<string> Bitis = new List<string>();
            int i = 0;
            while (dr.Read())
            {
                Bitis.Add(Convert.ToString(dr["Bitis"]));
                i = i + 1;

            }
            baglanti.Close();
            dr.Close();

            for (int j = 0; j < i; j++)
            {
                if (Bitis[j] == DateTime.Today.ToShortDateString())
                {
                    DialogResult sonuc = MessageBox.Show("Bugün Teslim Alınması Gereken Araçlarınız Var.Kontrol Etmek İster misiniz?", "HATIRLAATMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (sonuc == DialogResult.Yes)
                    {
                        string Plaka = "";
                        Form kiralar = new KiralıkAraclar(Plaka,1);
                        kiralar.ShowDialog();
                    }
                    break;
                }
            }


            sorgu = "Select Baslama From Rezervasyonlar";
            cmd = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataReader dr2 = cmd.ExecuteReader();
            List<string> Baslama = new List<string>();
            i = 0;
            while (dr2.Read())
            {
                Baslama.Add(Convert.ToString(dr2["Baslama"]));
                i = i + 1;

            }
            baglanti.Close();
            dr2.Close();

            for (int j = 0; j < i; j++)
            {
                if (Baslama[j] == DateTime.Today.ToShortDateString())
                {
                    DialogResult sonuc = MessageBox.Show("Bugün Kiralanması Gereken Araç Rezervasyonlarınız Var.Kontrol Etmek İster misiniz?", "HATIRLATMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (sonuc == DialogResult.Yes)
                    {
                        Form rezerve = new Rezervasyonlar();
                        rezerve.ShowDialog();
                        e.Cancel = true;
                    }
                    break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string sorgu = "Select Bitis From Kiralar";
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<string> Bitis = new List<string>();
            int i = 0;
            while (dr.Read())
            {
                Bitis.Add(Convert.ToString(dr["Bitis"]));
                i = i + 1;

            }
            baglanti.Close();
            dr.Close();

            for (int j = 0; j < i; j++)
            {
                if (Bitis[j] == DateTime.Today.ToShortDateString())
                {
                    DialogResult sonuc = MessageBox.Show("Bugün Teslim Alınması Gereken Araçlarınız Var.Kontrol Etmek İster misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (sonuc == DialogResult.Yes)
                    {
                        string Plaka = "";
                        Form kiralar = new KiralıkAraclar(Plaka,1);
                        kiralar.ShowDialog();
                        timer2.Stop();
                    }
                    break;
                }
            }


            sorgu = "Select Baslama From Rezervasyonlar";
            cmd = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataReader dr2 = cmd.ExecuteReader();
            List<string> Baslama = new List<string>();
            i = 0;
            while (dr2.Read())
            {
                Baslama.Add(Convert.ToString(dr2["Baslama"]));
                i = i + 1;

            }
            baglanti.Close();
            dr2.Close();

            for (int j = 0; j < i; j++)
            {
                if (Baslama[j] == DateTime.Today.ToShortDateString())
                {
                    DialogResult sonuc = MessageBox.Show("Bugün Kiralanması Gereken Araç Rezervasyonlarınız Var.Kontrol Etmek İster misiniz?", "HATIRLATMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (sonuc == DialogResult.Yes)
                    {
                        Form rezerve = new Rezervasyonlar();
                        rezerve.ShowDialog();
                        timer2.Stop();
                    }
                    break;
                }
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }

}
