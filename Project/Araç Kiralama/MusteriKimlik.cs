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
    public partial class MusteriKimlik : DevExpress.XtraEditors.XtraForm
    {
        public int deger;
        private string TC;
        public MusteriKimlik(string TC)
        {
            this.TC = TC;
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
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
            if (dt_dgmtarih.Text == "")
            {
                if (durum == true)
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
                }
                durum = false;
            }
            if(dt_vrldgzaman.Text=="")
            {
                if (durum == true)
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
                }
                durum = false;
            }
            
            if(durum==true)
            {
                if (txt_tc.Text == TC)
                {
                    string kisisel = "Select id from musteri_kisisel where TC=@tc";
                    SqlCommand cmd_kisisel = new SqlCommand(kisisel, baglanti);
                    baglanti.Open();
                    cmd_kisisel.Parameters.AddWithValue("@tc", txt_tc.Text);
                    deger = Convert.ToInt32(cmd_kisisel.ExecuteScalar());
                    baglanti.Close();





                    string kimlik = "Insert into musteri_kimlik(kimlik_id,TcNo,NufusCuzdanıNo,Baba_Adi,Ana_Adi,Dogum_Yeri,Dogum_Tarihi,Medeni_Hali,Dini,il,ilce,Mahalle,Cilt_No,AileSiraNo,Verildigi_Yer,Verilis_Nedeni,Verilis_Tarihi) Values (@kimlikid,@tcno,@nfs,@baba,@ana,@dgmyer,@dgmtarih,@medeni,@din,@il,@ilce,@mahalle,@cilt,@aile,@veryer,@verneden,@vertarih)";
                    SqlCommand cmd_kimlik = new SqlCommand(kimlik, baglanti);
                    cmd_kimlik.Parameters.AddWithValue("@kimlikid", deger);
                    cmd_kimlik.Parameters.AddWithValue("@tcno", txt_tc.Text);
                    cmd_kimlik.Parameters.AddWithValue("@nfs", txt_nufusno.Text);
                    cmd_kimlik.Parameters.AddWithValue("@baba", txt_baba.Text);
                    cmd_kimlik.Parameters.AddWithValue("@ana", txt_ana.Text);
                    cmd_kimlik.Parameters.AddWithValue("@dgmyer", txt_dgmyer.Text);
                    cmd_kimlik.Parameters.AddWithValue("@dgmtarih", dt_dgmtarih.Text);
                    cmd_kimlik.Parameters.AddWithValue("@medeni", txt_medenihal.Text);
                    cmd_kimlik.Parameters.AddWithValue("@din", txt_din.Text);
                    cmd_kimlik.Parameters.AddWithValue("@il", txt_il.Text);
                    cmd_kimlik.Parameters.AddWithValue("@ilce", txt_ilce.Text);
                    cmd_kimlik.Parameters.AddWithValue("@mahalle", txt_mahalle.Text);
                    cmd_kimlik.Parameters.AddWithValue("@cilt", txt_ciltno.Text);
                    cmd_kimlik.Parameters.AddWithValue("@aile", txt_aileno.Text);
                    cmd_kimlik.Parameters.AddWithValue("@veryer", txt_vrldgyer.Text);
                    cmd_kimlik.Parameters.AddWithValue("@verneden", txt_vrlsneden.Text);
                    cmd_kimlik.Parameters.AddWithValue("@vertarih", dt_vrldgzaman.Text);
                    baglanti.Open();
                    cmd_kimlik.ExecuteNonQuery();
                    baglanti.Close();


                    Form ileri = new MusteriEhliyet(deger);
                    ileri.ShowDialog();
                    this.Hide();
                }
                else
                    MessageBox.Show("Lütfen Doğru TC Kimlik Numarasını Girin.");
                
            }

            
        }

        private void MusteriKimlik_Load(object sender, EventArgs e)
        {
            txt_tc.Text = TC;
            dt_dgmtarih.Text= DateTime.Now.ToShortDateString();
            dt_vrldgzaman.Text= DateTime.Now.ToShortDateString();
        }
    }
}