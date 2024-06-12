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
    public partial class Form_Ana : Form
    {
        public Form_Ana()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EABSTBN;Initial Catalog=Personel_Veri_Tabanı;Integrated Security=True");

        string durum;
       

        void temizle()
        {
            txt_ad.Text= string.Empty;
            txt_soyad.Text = string.Empty;
            txt_meslek.Text = string.Empty;
            cmb_sehir.Text = string.Empty;
            rdb_bekar.Checked = false;
            rdb_evli.Checked = false;
            msktxt_maas.Text = string.Empty;
            txt_id.Text = string.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personel_Veri_TabanıDataSet1.Tbl_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PersonelTableAdapter1.Fill(this.personel_Veri_TabanıDataSet1.Tbl_Personel);
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter1.Fill(this.personel_Veri_TabanıDataSet1.Tbl_Personel);
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ad.Text) || string.IsNullOrEmpty(txt_soyad.Text) || string.IsNullOrEmpty(cmb_sehir.Text) || string.IsNullOrEmpty(msktxt_maas.Text) || string.IsNullOrEmpty(txt_meslek.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (Per_Ad,Per_Soy,Per_Sehir,Per_Maas,Per_Meslek,Per_Durum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1",txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", cmb_sehir.Text);
            komut.Parameters.AddWithValue("@p4",msktxt_maas.Text);
            komut.Parameters.AddWithValue("@p5", txt_meslek.Text);
            komut.Parameters.AddWithValue("@p6", durum);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void rdb_evli_CheckedChanged(object sender, EventArgs e)
        {
            durum = "True";
        }

        private void rdb_bekar_CheckedChanged(object sender, EventArgs e)
        {
            durum = "False";
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Personel where Per_Id=@s1",baglanti);
            komutsil.Parameters.AddWithValue("@s1",txt_id.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ad.Text) || string.IsNullOrEmpty(txt_soyad.Text) || string.IsNullOrEmpty(cmb_sehir.Text) || string.IsNullOrEmpty(msktxt_maas.Text) || string.IsNullOrEmpty(txt_meslek.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel set  Per_Ad=@g1,Per_Soy=@g2,Per_Sehir=@g3,Per_Maas=@g4,Per_Meslek=@g5,Per_Durum=@g6 where Per_Id=@g7", baglanti);
            komutguncelle.Parameters.AddWithValue("@g1", txt_ad.Text);
            komutguncelle.Parameters.AddWithValue("@g2", txt_soyad.Text);
            komutguncelle.Parameters.AddWithValue("@g3", cmb_sehir.Text);
            komutguncelle.Parameters.AddWithValue("@g4", msktxt_maas.Text);
            komutguncelle.Parameters.AddWithValue("@g5", txt_meslek.Text);
            komutguncelle.Parameters.AddWithValue("@g6", durum);
            komutguncelle.Parameters.AddWithValue("@g7", txt_id.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close() ;
            btn_listele_Click(sender, e);
        }

        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;  // satır bilgisini aldık

            txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); // aldığımız satırın 0.sütunu aldık
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_meslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            msktxt_maas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmb_sehir.SelectedItem = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

           durum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
           
            if(durum=="True")
            {
                rdb_evli.Checked = true;
            }
            if (durum == "False")
            {
                rdb_bekar.Checked = true;
            }


        }

        private void btn_istatistik_Click(object sender, EventArgs e)
        {
            Form_istatistik frm_ist =new Form_istatistik();
            frm_ist.Show();
        }

        private void btn_grafikler_Click(object sender, EventArgs e)
        {
            Form_grafikler grf = new Form_grafikler();
            grf.Show();
        }

        private void button_cıkıs_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button_rapor_Click(object sender, EventArgs e)
        {
            Form_rapor rpr = new Form_rapor();
            rpr.Show();
        }
    }
}
