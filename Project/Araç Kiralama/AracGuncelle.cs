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
    public partial class AracGuncelle : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
        private object Marka;
        private string Model;
        private string Plaka;
        private string Yil;
        private string Motor;
        private string Renk;
        private string Yakit;
        private string Ucret;
        private string Durum;
        public AracGuncelle(string Marka, string Model,string Plaka, string Yil, string Renk, string Motor, string Yakit, string Ucret, string Durum)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.Plaka = Plaka;
            this.Yil = Yil;
            this.Motor = Motor;
            this.Renk = Renk;
            this.Yakit = Yakit;
            this.Ucret = Ucret;
            this.Durum = Durum;


            InitializeComponent();      
            
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_marka.Text = "";
            txt_model.Text = "";
            txt_plaka.Text = "";
            txt_Yil.Text = "";
            txt_Motor.Text = "";
            txt_renk.Text = "";
            cmb_yakit.SelectedText = "";
            txt_ucret.Text = "";
        }

        private void btn_aracguncelle_Click(object sender, EventArgs e)
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


            if (cmb_durum.Text == "" || cmb_yakit.Text == "")
            {
                if (durum == true)
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
                }
                durum = false;
            }

            if (durum == true)
            {
                string sorgu = "Update Araclar Set Marka=@marka,Model=@model,plaka=@plaka,Yil=@yil,Motor=@motor,Renk=@renk,Yakit=@yakit,Ucret=@ucret,Durum=@durum Where id=@id";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                komut.Parameters.AddWithValue("@id", Araclar.id);
                komut.Parameters.AddWithValue("@marka", txt_marka.Text);
                komut.Parameters.AddWithValue("@model", txt_model.Text);
                komut.Parameters.AddWithValue("@plaka", txt_plaka.Text);
                komut.Parameters.AddWithValue("@yil", txt_Yil.Text);
                komut.Parameters.AddWithValue("@motor", txt_Motor.Text);
                komut.Parameters.AddWithValue("@renk", txt_renk.Text);
                komut.Parameters.AddWithValue("@yakit", cmb_yakit.SelectedItem);
                komut.Parameters.AddWithValue("@ucret", txt_ucret.Text);
                komut.Parameters.AddWithValue("@durum", cmb_durum.SelectedItem);
                komut.ExecuteNonQuery();

                string kiralar = "Update Kiralar Set Plaka=@plaka,Marka=@marka,Model=@model where Plaka=@yplaka";
                SqlCommand cmd_kira = new SqlCommand(kiralar, baglanti);
                cmd_kira.Parameters.AddWithValue("@yplaka", Plaka);
                cmd_kira.Parameters.AddWithValue("@plaka", txt_plaka.Text);
                cmd_kira.Parameters.AddWithValue("@marka", txt_marka.Text);
                cmd_kira.Parameters.AddWithValue("@model", txt_model.Text);
                cmd_kira.ExecuteNonQuery();

                string bakimlar = "Update Bakimlar Set Plaka=@plaka where Plaka=@yplaka";
                SqlCommand cmd_bakim = new SqlCommand(bakimlar, baglanti);
                cmd_bakim.Parameters.AddWithValue("@yplaka", Plaka);
                cmd_bakim.Parameters.AddWithValue("@plaka", txt_plaka.Text);
                cmd_bakim.ExecuteNonQuery();

                sorgu = "Update Rezervasyonlar Set Plaka=@plaka,Marka=@marka,Model=@model where Plaka=@NP";
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@NP", Plaka);
                cmd.Parameters.AddWithValue("@plaka", txt_plaka.Text);
                cmd.Parameters.AddWithValue("@marka", txt_marka.Text);
                cmd.Parameters.AddWithValue("@model", txt_model.Text);
                cmd.ExecuteNonQuery();
                



                baglanti.Close();
                MessageBox.Show("Araç Güncellendi.");
                Close();
            }
        }

        private void AracGuncelle_Load(object sender, EventArgs e)
        {
            txt_marka.Text = Convert.ToString(Marka);
            txt_model.Text = Convert.ToString(Model);
            txt_plaka.Text = Convert.ToString(Plaka);
            txt_Yil.Text = Convert.ToString(Yil);
            txt_Motor.Text = Convert.ToString(Motor);
            txt_renk.Text = Convert.ToString(Renk);
            cmb_yakit.SelectedText = Convert.ToString(Yakit);
            txt_ucret.Text = Convert.ToString(Ucret);
            cmb_durum.Text = Convert.ToString(Durum);
        }
    }
}