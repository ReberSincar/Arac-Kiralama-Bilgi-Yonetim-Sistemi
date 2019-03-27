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
    public partial class MusteriTuru : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        public MusteriTuru(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M2E5NSL\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
            string text;
            string sorgu = "Update musteri_kisisel Set Tur=@tur where id=@id";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);

            

            if(radioButton1.Checked)
            {
                text = radioButton1.Text;
            }
            else if (radio.Checked)
            {
                text = radio.Text;
            }
            else if (radioButton3.Checked)
            {
                text = radioButton3.Text;
            }
            else
            {
                text = radioButton4.Text;
            }

            komut.Parameters.AddWithValue("@id", id);
            komut.Parameters.AddWithValue("@tur", text);
            
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Türü Güncellendi.");
            Close();
        }
    }
}