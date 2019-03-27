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
    public partial class AracEkle : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
        SqlCommand cmd;

        
        public AracEkle()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool durum=true;
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

            if(cmb_durum.Text=="" || cmb_yakit.Text=="")
            {
                if (durum == true)
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
                }
                durum = false;
            }

            string sorgu = "Select Plaka From Araclar";
            cmd = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<string> Plaka = new List<string>();
            int i = 0;
            while (dr.Read())
            {
                Plaka.Add(Convert.ToString(dr["Plaka"]).ToUpper());
                i = i + 1;

            }
            baglanti.Close();
            dr.Close();

            for (int j = 0; j < i; j++)
            {
                if (Plaka[j] == txt_plaka.Text.ToUpper())
                {
                    durum = false;
                    MessageBox.Show("Bu Plaka Başka Araç Tarafından Kullanılıyor!");
                    break;
                }
            }

            if (durum == true)
            {
                
                sorgu = "Insert into Araclar(Marka,Model,Plaka,Yil,Motor,Renk,Yakit,Ucret,Durum) values (@marka,@model,@plaka,@yil,@motor,@renk,@yakit,@ucret,@durum)";
                cmd = new SqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@marka", txt_marka.Text);
                cmd.Parameters.AddWithValue("@model", txt_model.Text);
                cmd.Parameters.AddWithValue("@plaka", txt_plaka.Text.ToUpper());
                cmd.Parameters.AddWithValue("@yil", txt_Yil.Text);
                cmd.Parameters.AddWithValue("@motor", txt_Motor.Text);
                cmd.Parameters.AddWithValue("@renk", txt_renk.Text);
                cmd.Parameters.AddWithValue("@yakit", cmb_yakit.SelectedItem);
                cmd.Parameters.AddWithValue("@ucret", txt_ucret.Text);
                cmd.Parameters.AddWithValue("@durum", cmb_durum.SelectedItem);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Araç Eklendi.");
                Close();
            }
                


            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
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
    }
}