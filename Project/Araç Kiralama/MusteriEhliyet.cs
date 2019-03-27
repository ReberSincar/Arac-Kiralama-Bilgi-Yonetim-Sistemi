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
    public partial class MusteriEhliyet : DevExpress.XtraEditors.XtraForm
    {
        private int deger;
        public MusteriEhliyet(int deger)
        {
            this.deger = deger;
            InitializeComponent();
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

            if (dt_ehliyetverilistarih.Text=="")
            {
                if (durum == true)
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun!");
                }
                durum = false;
            }
            if(durum==true)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
                string ehliyet = "Insert into musteri_ehliyet(ehliyet_id,il,ilce,belgeno,verilistarihi,kul_cihazlar,duzenleyen) Values(@ehliyetid,@eil,@eilce,@belge,@evertarih,@ecihazlar,@eduzenleyen)";
                baglanti.Open();
                SqlCommand cmd_ehliyet = new SqlCommand(ehliyet, baglanti);
                cmd_ehliyet.Parameters.AddWithValue("@ehliyetid", deger);
                cmd_ehliyet.Parameters.AddWithValue("@eil", txt_ehliyetil.Text);
                cmd_ehliyet.Parameters.AddWithValue("@eilce", txt_ehliyetilce.Text);
                cmd_ehliyet.Parameters.AddWithValue("@belge", txt_ehliyetbelge.Text);
                cmd_ehliyet.Parameters.AddWithValue("@evertarih", dt_ehliyetverilistarih.Text);
                cmd_ehliyet.Parameters.AddWithValue("@ecihazlar", txt_cihazlar.Text);
                cmd_ehliyet.Parameters.AddWithValue("@eduzenleyen", txt_duzenleyen.Text);
                cmd_ehliyet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Eklendi");
                Close();
            }
        }

        private void MusteriEhliyet_Load(object sender, EventArgs e)
        {
            dt_ehliyetverilistarih.Text= DateTime.Now.ToShortDateString(); ;
        }
    }
}