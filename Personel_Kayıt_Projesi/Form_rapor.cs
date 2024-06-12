using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_76_92_Personel_Kayıt_Projesi
{
    public partial class Form_rapor : Form
    {
        public Form_rapor()
        {
            InitializeComponent();
        }

        private void Form_rapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personel_Veri_TabanıDataSet2.Tbl_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PersonelTableAdapter.Fill(this.personel_Veri_TabanıDataSet2.Tbl_Personel);

            this.reportViewer1.RefreshReport();
        }
    }
}
