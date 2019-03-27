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
    public partial class MusteriGuncelle : DevExpress.XtraEditors.XtraForm
    {
        private string Ad,Soyad,TC,Telefon,Adres,Mail,EkBilgi,Tur;
        private int id;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {
            txt_ad.Text = Ad;
            txt_soyad.Text = Soyad;
            textEdit1.Text = TC;
            txt_tc.Text = TC;
            txt_tel.Text = Telefon;
            txt_mail.Text = Mail;
            txt_adres.Text = Adres;
            txt_ekbilgi.Text = EkBilgi;
            cmb_tur.SelectedText = Tur;


            string deger = "Select NufusCuzdanıNo from musteri_kimlik where TcNo=@tc";
            SqlCommand cmdnufus = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdnufus.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmdnufus.ExecuteScalar());
            baglanti.Close();
            txt_nufusno.Text = deger;

            deger = "Select Baba_Adi from musteri_kimlik where TcNo=@tc";
            SqlCommand cmdbaba = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdbaba.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmdbaba.ExecuteScalar());
            baglanti.Close();
            txt_baba.Text = deger;

            deger = "Select Ana_Adi from musteri_kimlik where TcNo=@tc";
            SqlCommand cmdana = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdana.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmdana.ExecuteScalar());
            baglanti.Close();
            txt_ana.Text = deger;

            deger = "Select Dogum_Yeri from musteri_kimlik where TcNo=@tc";
            SqlCommand cmddgmyer = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmddgmyer.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmddgmyer.ExecuteScalar());
            baglanti.Close();
            txt_dgmyer.Text = deger;

            deger = "Select Dogum_Tarihi from musteri_kimlik where TcNo=@tc";
            SqlCommand cmddgmtar = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmddgmtar.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmddgmtar.ExecuteScalar());
            baglanti.Close();
            dt_dgmtarih.Text = deger;

            deger = "Select Medeni_Hali from musteri_kimlik where TcNo=@tc";
            SqlCommand cmdmedeni = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdmedeni.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmdmedeni.ExecuteScalar());
            baglanti.Close();
            txt_medenihal.Text = deger;

            deger = "Select Dini from musteri_kimlik where TcNo=@tc";
            SqlCommand cmddin = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmddin.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmddin.ExecuteScalar());
            baglanti.Close();
            txt_din.Text = deger;

            deger = "Select il from musteri_kimlik where TcNo=@tc";
            SqlCommand cmdil = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdil.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmdil.ExecuteScalar());
            baglanti.Close();
            txt_il.Text = deger;

            deger = "Select ilce from musteri_kimlik where TcNo=@tc";
            SqlCommand cmdilce = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdilce.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmdilce.ExecuteScalar());
            baglanti.Close();
            txt_ilce.Text = deger;

            deger = "Select Mahalle from musteri_kimlik where TcNo=@tc";
            SqlCommand cmdmah = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdmah.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmdmah.ExecuteScalar());
            baglanti.Close();
            txt_mahalle.Text = deger;

            deger = "Select Cilt_No from musteri_kimlik where TcNo=@tc";
            SqlCommand cmdcilt = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdcilt.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmdcilt.ExecuteScalar());
            baglanti.Close();
            txt_ciltno.Text = deger;

            deger = "Select AileSiraNo from musteri_kimlik where TcNo=@tc";
            SqlCommand cmdaile = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdaile.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmdaile.ExecuteScalar());
            baglanti.Close();
            txt_aileno.Text = deger;

            deger = "Select Verildigi_Yer from musteri_kimlik where TcNo=@tc";
            SqlCommand cmdvyer = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdvyer.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmdvyer.ExecuteScalar());
            baglanti.Close();
            txt_vrldgyer.Text = deger;

            deger = "Select Verilis_Nedeni from musteri_kimlik where TcNo=@tc";
            cmdcilt = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdcilt.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmdcilt.ExecuteScalar());
            baglanti.Close();
            txt_vrlsneden.Text = deger;

            deger = "Select Verilis_Tarihi from musteri_kimlik where TcNo=@tc";
            cmdcilt = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdcilt.Parameters.AddWithValue("@tc", TC);
            deger = Convert.ToString(cmdcilt.ExecuteScalar());
            baglanti.Close();
            dt_vrldgzaman.Text = deger;

            deger = "Select kimlik_id from musteri_kimlik where TcNo=@tc";
            cmdcilt = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdcilt.Parameters.AddWithValue("@tc", TC);
            int id = Convert.ToInt32(cmdcilt.ExecuteScalar());
            baglanti.Close();
            this.id = id;





            deger = "Select il from musteri_ehliyet where ehliyet_id=@id";
            cmdcilt = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdcilt.Parameters.AddWithValue("@id", id);
            deger = Convert.ToString(cmdcilt.ExecuteScalar());
            baglanti.Close();
            txt_ehliyetil.Text = deger;

            deger = "Select ilce from musteri_ehliyet where ehliyet_id=@id";
            cmdcilt = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdcilt.Parameters.AddWithValue("@id", id);
            deger = Convert.ToString(cmdcilt.ExecuteScalar());
            baglanti.Close();
            txt_ehliyetilce.Text = deger;

            deger = "Select belgeno from musteri_ehliyet where ehliyet_id=@id";
            cmdcilt = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdcilt.Parameters.AddWithValue("@id", id);
            deger = Convert.ToString(cmdcilt.ExecuteScalar());
            baglanti.Close();
            txt_ehliyetbelge.Text = deger;

            deger = "Select verilistarihi from musteri_ehliyet where ehliyet_id=@id";
            cmdcilt = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdcilt.Parameters.AddWithValue("@id", id);
            deger = Convert.ToString(cmdcilt.ExecuteScalar());
            baglanti.Close();
            dt_ehliyetverilistarih.Text = deger;

            deger = "Select kul_cihazlar from musteri_ehliyet where ehliyet_id=@id";
            cmdcilt = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdcilt.Parameters.AddWithValue("@id", id);
            deger = Convert.ToString(cmdcilt.ExecuteScalar());
            baglanti.Close();
            txt_cihazlar.Text = deger;

            deger = "Select duzenleyen from musteri_ehliyet where ehliyet_id=@id";
            cmdcilt = new SqlCommand(deger, baglanti);
            baglanti.Open();
            cmdcilt.Parameters.AddWithValue("@id", id);
            deger = Convert.ToString(cmdcilt.ExecuteScalar());
            baglanti.Close();
            txt_duzenleyen.Text = deger;
        }

        public MusteriGuncelle(string Ad, string Soyad, string TC, string Telefon, string Adres, string Mail, string EkBilgi, string Tur, string tc, string nfs, string baba, string ana, string dgmyer, string dgmtarih, string medeni, string din, string il, string ilce, string mahalle, string cilt, string aile, string veryer, string verneden, string vertarih, string eil, string eilce, string ebelge, string evertarih, string ecihaz, string eduz)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.TC = TC;
            this.Telefon = Telefon;
            this.Adres = Adres;
            this.Mail = Mail;
            this.EkBilgi = EkBilgi;
            this.Tur=Tur;
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
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

            foreach (Control ctl in this.Controls)
            {
                if (ctl is DateEdit)
                {
                    if (ctl.Text == String.Empty)
                    {
                        if(durum==true)
                        {
                            MessageBox.Show("Lütfen Tüm Alanları Doldurun!");                            
                        }
                        durum = false;
                        break;
                    }
                }
            }
            if (cmb_tur.Text == "")
            {
                if (durum == true)
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
                }
                durum = false;
            }
            if(txt_tc.Text==textEdit1.Text)
            {
                if (durum == true)
                {
                    string ehliyet = "Update musteri_ehliyet Set il=@eil,ilce=@eilce,belgeno=@ebelge,verilistarihi=@evertarih,kul_cihazlar=@ecihaz,duzenleyen=@eduz Where ehliyet_id=@id";
                    string kimlik = "Update musteri_kimlik Set TcNo=@tc,NufusCuzdanıNo=@nfs,Baba_Adi=@baba,Ana_Adi=@ana,Dogum_Yeri=@dgmyer,Dogum_Tarihi=@dgmtarih,Medeni_Hali=@medeni,Dini=@din,il=@il,ilce=@ilce,Mahalle=@mahalle,Cilt_No=@cilt,AileSiraNo=@aile,Verildigi_Yer=@veryer,Verilis_Nedeni=@verneden,Verilis_Tarihi=@vertarih Where kimlik_id=@id";
                    string kisisel = "Update musteri_kisisel Set Ad=@ad,Soyad=@soyad,TC=@tc,Telefon=@tel,Adres=@adres,Mail=@mail,EkBilgi=@ekbilgi,Tur=@tur Where id=@id";


                    baglanti.Open();
                    SqlCommand cmd_kisisel = new SqlCommand(kisisel, baglanti);
                    cmd_kisisel.Parameters.AddWithValue("@id", id);
                    cmd_kisisel.Parameters.AddWithValue("@ad", txt_ad.Text);
                    cmd_kisisel.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                    cmd_kisisel.Parameters.AddWithValue("@tc", textEdit1.Text);
                    cmd_kisisel.Parameters.AddWithValue("@tel", txt_tel.Text);
                    cmd_kisisel.Parameters.AddWithValue("@adres", txt_adres.Text);
                    cmd_kisisel.Parameters.AddWithValue("@mail", txt_mail.Text);
                    cmd_kisisel.Parameters.AddWithValue("@ekbilgi", txt_ekbilgi.Text);
                    cmd_kisisel.Parameters.AddWithValue("@tur", cmb_tur.SelectedItem);
                    cmd_kisisel.ExecuteNonQuery();


                    SqlCommand cmd_kimlik = new SqlCommand(kimlik, baglanti);
                    cmd_kimlik.Parameters.AddWithValue("@id", id);
                    cmd_kimlik.Parameters.AddWithValue("@tc", txt_tc.Text);
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
                    cmd_kimlik.ExecuteNonQuery();



                    SqlCommand cmd_ehliyet = new SqlCommand(ehliyet, baglanti);
                    cmd_ehliyet.Parameters.AddWithValue("@id", id);
                    cmd_ehliyet.Parameters.AddWithValue("@eil", txt_ehliyetil.Text);
                    cmd_ehliyet.Parameters.AddWithValue("@eilce", txt_ehliyetilce.Text);
                    cmd_ehliyet.Parameters.AddWithValue("@ebelge", txt_ehliyetbelge.Text);
                    cmd_ehliyet.Parameters.AddWithValue("@evertarih", dt_ehliyetverilistarih.Text);
                    cmd_ehliyet.Parameters.AddWithValue("@ecihaz", txt_cihazlar.Text);
                    cmd_ehliyet.Parameters.AddWithValue("@eduz", txt_duzenleyen.Text);
                    cmd_ehliyet.ExecuteNonQuery();

                    string kiralar = "Update Kiralar Set Ad=@ad,Soyad=@soyad,TC=@tc where TC=@KTC";
                    SqlCommand cmd_kira = new SqlCommand(kiralar, baglanti);
                    cmd_kira.Parameters.AddWithValue("@KTC", TC);
                    cmd_kira.Parameters.AddWithValue("@ad", txt_ad.Text);
                    cmd_kira.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                    cmd_kira.Parameters.AddWithValue("@tc", txt_tc.Text);
                    cmd_kira.ExecuteNonQuery();

                    string rezervasonlar = "Update Rezervasyonlar Set Ad=@ad,Soyad=@soyad,TC=@tc where TC=@KTC";
                    SqlCommand cmd_rezervasyon = new SqlCommand(rezervasonlar, baglanti);
                    cmd_rezervasyon.Parameters.AddWithValue("@KTC", TC);
                    cmd_rezervasyon.Parameters.AddWithValue("@ad", txt_ad.Text);
                    cmd_rezervasyon.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                    cmd_rezervasyon.Parameters.AddWithValue("@tc", txt_tc.Text);
                    cmd_rezervasyon.ExecuteNonQuery();

                    baglanti.Close();
                    MessageBox.Show("Müşteri Güncellendi.");
                    Close();
                }
            
            
            } 
            else
            {
                MessageBox.Show("Girdiğiniz TC Kimlik Numaraları Aynı Olmalı!");
            }
            
        }
    }
}