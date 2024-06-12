using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_76_92_Personel_Kayıt_Projesi
{
    public partial class Form_giris : Form
    {
        public Form_giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EABSTBN;Initial Catalog=Personel_Veri_Tabanı;Integrated Security=True");

        sbyte hak = 5;

        private void button_sifreGoster_Click(object sender, EventArgs e)
        {
            if (textBox_sifre.UseSystemPasswordChar==true)
            {
                textBox_sifre.UseSystemPasswordChar = false;
                button_sifreGoster.Text = "Şifreyi Sakla";
            }
            else
            {
                textBox_sifre.UseSystemPasswordChar = true;
                button_sifreGoster.Text = "Şifreyi Göster";
            }
        }

        
        private void button_giris_Click(object sender, EventArgs e)
        {
            if (hak > 0)
            {


                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select * From Tbl_Yonetici where Kullanici_Adi=@a1 and Sifre=@a2", baglanti);
                cmd.Parameters.AddWithValue("@a1", textBox_kullaiciadi.Text);
                cmd.Parameters.AddWithValue("@a2", textBox_sifre.Text);
                SqlDataReader r1 = cmd.ExecuteReader();

                if (r1.Read())
                {
                    Form_Ana frm = new Form_Ana();
                    frm.Show();
                    this.Hide();
                }

                else
                {
                    //  MessageBox.Show("Giriş bilgileri yanlış", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    --hak;
                    label_hak.Visible = true;
                    label_hak.Text = "Kalan Deneme Hakkınız: " + hak;

                }
                baglanti.Close();
            }

            else
            {
                label_hak.Text = "Giriş Hakkınız Bitmiştir";
            }
        }

      
    }
}
