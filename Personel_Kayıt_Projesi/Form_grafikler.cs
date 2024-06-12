using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ders_76_92_Personel_Kayıt_Projesi
{
    public partial class Form_grafikler : Form
    {
        public Form_grafikler()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EABSTBN;Initial Catalog=Personel_Veri_Tabanı;Integrated Security=True");


        private void Form_grafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutg1 = new SqlCommand("Select Per_Sehir,Count(*) from Tbl_Personel group by Per_Sehir", baglanti);
            SqlDataReader r1 = komutg1.ExecuteReader();
            while (r1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(r1[0], r1[1]);
            }
            baglanti.Close();

            baglanti.Open();

            SqlCommand komutg2 = new SqlCommand("Select Per_Meslek,Avg(Per_Maas) from Tbl_Personel group by Per_Meslek",baglanti);
            SqlDataReader r2= komutg2.ExecuteReader();
            while (r2.Read())
            {
                chart2.Series["Ortalama Maas"].Points.AddXY(r2[0], r2[1]);
            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Per_Sehir,Avg(Per_Maas) from Tbl_Personel group by Per_Sehir",baglanti);
            SqlDataReader r3 = komut3.ExecuteReader();
            while(r3.Read())
            {
                chart3.Series["Ortalama Maas-Sehir"].Points.AddXY(r3[0], r3[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Per_Sehir,Sum(Per_Maas) from Tbl_Personel group by Per_Sehir", baglanti);
            SqlDataReader r4 = komut4.ExecuteReader();
            while (r4.Read())
            {
                chart4.Series["Maas-Sehir"].Points.AddXY(r4[0], r4[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Per_Sehir,Count(*) from Tbl_Personel Where Per_Durum=1 group by Per_Sehir", baglanti);
            SqlDataReader r5 = komut5.ExecuteReader();
            while (r5.Read())
            {
                chart5.Series["Evli-Sehir"].Points.AddXY(r5[0], r5[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Per_Sehir,Count(*) from Tbl_Personel Where Per_Durum=0 group by Per_Sehir", baglanti);
            SqlDataReader r6 = komut6.ExecuteReader();
            while (r6.Read())
            {
                chart6.Series["Bekar-Sehir"].Points.AddXY(r6[0], r6[1]);
            }
            baglanti.Close();
        }
    }
}
