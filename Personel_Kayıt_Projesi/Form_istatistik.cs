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
    public partial class Form_istatistik : Form
    {
        public Form_istatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EABSTBN;Initial Catalog=Personel_Veri_Tabanı;Integrated Security=True");

        private void Form_istatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel",baglanti);
            SqlDataReader dr1= komut1.ExecuteReader();

            
            dr1.Read(); 
            label_top_pers.Text = dr1[0].ToString(); // 0 dedik çünkü sql sorgusu yaptığımızda  sonuç ekranında en üstte kaç değer var onun sayısını veriyor ilk satırda 0.endex olduğu için 0 yazdık
            baglanti.Close();


            // EVLİ PERSONEL

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel Where Per_Durum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            dr2.Read();
            label_top_evli.Text = dr2[0].ToString();
            baglanti.Close();

            //BEKAR PERSONEL

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) from Tbl_Personel where Per_Durum=0",baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            dr3.Read();
            label_top_bekar.Text = dr3[0].ToString();
            baglanti.Close();


            //FARKLI ŞEHİR SAYISI

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(Per_Sehir)) from Tbl_Personel",baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            dr4.Read();
            label_sehir.Text = dr4[0].ToString();
            baglanti.Close();


            //TOPLAM MAAŞ

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(Per_Maas) from Tbl_Personel",baglanti); //Sum topla demek
            SqlDataReader dr5= komut5.ExecuteReader();
            dr5.Read();
            label_top_maas.Text = dr5[0].ToString();
            baglanti.Close();

            //ORTALAMA MAAŞ

            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("Select Avg(Per_Maas) from Tbl_Personel",baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            dr6.Read();
            label_top_ort.Text = dr6[0].ToString();

            baglanti.Close();

            
        }

        
    }
}
