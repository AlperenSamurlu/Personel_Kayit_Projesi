namespace Ders_76_92_Personel_Kayıt_Projesi
{
    partial class Form_Ana
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_bekar = new System.Windows.Forms.RadioButton();
            this.cmb_sehir = new System.Windows.Forms.ComboBox();
            this.rdb_evli = new System.Windows.Forms.RadioButton();
            this.msktxt_maas = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_meslek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_rapor = new System.Windows.Forms.Button();
            this.button_cıkıs = new System.Windows.Forms.Button();
            this.btn_grafikler = new System.Windows.Forms.Button();
            this.btn_istatistik = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Per_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personel_Veri_TabanıDataSet1 = new Ders_76_92_Personel_Kayıt_Projesi.Personel_Veri_TabanıDataSet1();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_Veri_TabaniDataSet = new Ders_76_92_Personel_Kayıt_Projesi.Personel_Veri_TabaniDataSet();
            this.tbl_PersonelTableAdapter = new Ders_76_92_Personel_Kayıt_Projesi.Personel_Veri_TabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.tbl_PersonelTableAdapter1 = new Ders_76_92_Personel_Kayıt_Projesi.Personel_Veri_TabanıDataSet1TableAdapters.Tbl_PersonelTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabanıDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_bekar);
            this.groupBox1.Controls.Add(this.cmb_sehir);
            this.groupBox1.Controls.Add(this.rdb_evli);
            this.groupBox1.Controls.Add(this.msktxt_maas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_meslek);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(258, 336);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // rdb_bekar
            // 
            this.rdb_bekar.AutoSize = true;
            this.rdb_bekar.Location = new System.Drawing.Point(89, 154);
            this.rdb_bekar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_bekar.Name = "rdb_bekar";
            this.rdb_bekar.Size = new System.Drawing.Size(53, 17);
            this.rdb_bekar.TabIndex = 6;
            this.rdb_bekar.TabStop = true;
            this.rdb_bekar.Text = "Bekar";
            this.rdb_bekar.UseVisualStyleBackColor = true;
            this.rdb_bekar.CheckedChanged += new System.EventHandler(this.rdb_bekar_CheckedChanged);
            // 
            // cmb_sehir
            // 
            this.cmb_sehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sehir.FormattingEnabled = true;
            this.cmb_sehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cmb_sehir.Location = new System.Drawing.Point(89, 216);
            this.cmb_sehir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_sehir.Name = "cmb_sehir";
            this.cmb_sehir.Size = new System.Drawing.Size(85, 21);
            this.cmb_sehir.TabIndex = 8;
            // 
            // rdb_evli
            // 
            this.rdb_evli.AutoSize = true;
            this.rdb_evli.Location = new System.Drawing.Point(89, 132);
            this.rdb_evli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_evli.Name = "rdb_evli";
            this.rdb_evli.Size = new System.Drawing.Size(42, 17);
            this.rdb_evli.TabIndex = 5;
            this.rdb_evli.TabStop = true;
            this.rdb_evli.Text = "Evli";
            this.rdb_evli.UseVisualStyleBackColor = true;
            this.rdb_evli.CheckedChanged += new System.EventHandler(this.rdb_evli_CheckedChanged);
            // 
            // msktxt_maas
            // 
            this.msktxt_maas.Location = new System.Drawing.Point(89, 249);
            this.msktxt_maas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msktxt_maas.Mask = "00000";
            this.msktxt_maas.Name = "msktxt_maas";
            this.msktxt_maas.Size = new System.Drawing.Size(85, 20);
            this.msktxt_maas.TabIndex = 9;
            this.msktxt_maas.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "MAAŞ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(89, 39);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(85, 20);
            this.txt_id.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ŞEHİR";
            // 
            // txt_meslek
            // 
            this.txt_meslek.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_meslek.Location = new System.Drawing.Point(89, 182);
            this.txt_meslek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_meslek.Name = "txt_meslek";
            this.txt_meslek.Size = new System.Drawing.Size(85, 20);
            this.txt_meslek.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MESLEK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DURUM";
            // 
            // txt_soyad
            // 
            this.txt_soyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_soyad.Location = new System.Drawing.Point(89, 106);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(85, 20);
            this.txt_soyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOYAD";
            // 
            // txt_ad
            // 
            this.txt_ad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ad.Location = new System.Drawing.Point(89, 73);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(85, 20);
            this.txt_ad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_rapor);
            this.groupBox2.Controls.Add(this.button_cıkıs);
            this.groupBox2.Controls.Add(this.btn_grafikler);
            this.groupBox2.Controls.Add(this.btn_istatistik);
            this.groupBox2.Controls.Add(this.btn_temizle);
            this.groupBox2.Controls.Add(this.btn_guncelle);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.btn_kaydet);
            this.groupBox2.Controls.Add(this.btn_listele);
            this.groupBox2.Location = new System.Drawing.Point(280, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(155, 336);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // button_rapor
            // 
            this.button_rapor.Location = new System.Drawing.Point(18, 265);
            this.button_rapor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_rapor.Name = "button_rapor";
            this.button_rapor.Size = new System.Drawing.Size(108, 26);
            this.button_rapor.TabIndex = 19;
            this.button_rapor.Text = "Raporlar";
            this.button_rapor.UseVisualStyleBackColor = true;
            this.button_rapor.Click += new System.EventHandler(this.button_rapor_Click);
            // 
            // button_cıkıs
            // 
            this.button_cıkıs.Location = new System.Drawing.Point(18, 300);
            this.button_cıkıs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_cıkıs.Name = "button_cıkıs";
            this.button_cıkıs.Size = new System.Drawing.Size(108, 26);
            this.button_cıkıs.TabIndex = 18;
            this.button_cıkıs.Text = "Çıkış";
            this.button_cıkıs.UseVisualStyleBackColor = true;
            this.button_cıkıs.Click += new System.EventHandler(this.button_cıkıs_Click);
            // 
            // btn_grafikler
            // 
            this.btn_grafikler.Location = new System.Drawing.Point(18, 230);
            this.btn_grafikler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_grafikler.Name = "btn_grafikler";
            this.btn_grafikler.Size = new System.Drawing.Size(108, 26);
            this.btn_grafikler.TabIndex = 17;
            this.btn_grafikler.Text = "Grafikler";
            this.btn_grafikler.UseVisualStyleBackColor = true;
            this.btn_grafikler.Click += new System.EventHandler(this.btn_grafikler_Click);
            // 
            // btn_istatistik
            // 
            this.btn_istatistik.Location = new System.Drawing.Point(18, 195);
            this.btn_istatistik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_istatistik.Name = "btn_istatistik";
            this.btn_istatistik.Size = new System.Drawing.Size(108, 26);
            this.btn_istatistik.TabIndex = 16;
            this.btn_istatistik.Text = "İstatistik";
            this.btn_istatistik.UseVisualStyleBackColor = true;
            this.btn_istatistik.Click += new System.EventHandler(this.btn_istatistik_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(18, 160);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(108, 26);
            this.btn_temizle.TabIndex = 15;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(18, 125);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(108, 26);
            this.btn_guncelle.TabIndex = 14;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(18, 90);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(108, 26);
            this.btn_sil.TabIndex = 13;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(18, 55);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(108, 26);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(18, 20);
            this.btn_listele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(108, 26);
            this.btn_listele.TabIndex = 11;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(9, 351);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(934, 202);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Per_Id,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Per_Id
            // 
            this.Per_Id.DataPropertyName = "Per_Id";
            this.Per_Id.HeaderText = "Per_Id";
            this.Per_Id.MinimumWidth = 6;
            this.Per_Id.Name = "Per_Id";
            this.Per_Id.ReadOnly = true;
            this.Per_Id.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "Per_Ad";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "Per_Ad";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyDataGridViewTextBoxColumn
            // 
            this.perSoyDataGridViewTextBoxColumn.DataPropertyName = "Per_Soy";
            this.perSoyDataGridViewTextBoxColumn.HeaderText = "Per_Soy";
            this.perSoyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyDataGridViewTextBoxColumn.Name = "perSoyDataGridViewTextBoxColumn";
            this.perSoyDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "Per_Sehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "Per_Sehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "Per_Maas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "Per_Maas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "Per_Durum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "Per_Durum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "Per_Meslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "Per_Meslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource1
            // 
            this.tblPersonelBindingSource1.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource1.DataSource = this.personel_Veri_TabanıDataSet1;
            // 
            // personel_Veri_TabanıDataSet1
            // 
            this.personel_Veri_TabanıDataSet1.DataSetName = "Personel_Veri_TabanıDataSet1";
            this.personel_Veri_TabanıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personel_Veri_TabaniDataSet;
            // 
            // personel_Veri_TabaniDataSet
            // 
            this.personel_Veri_TabaniDataSet.DataSetName = "Personel_Veri_TabaniDataSet";
            this.personel_Veri_TabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_PersonelTableAdapter1
            // 
            this.tbl_PersonelTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_Ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1018, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form_Ana";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabanıDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabaniDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_meslek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msktxt_maas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdb_bekar;
        private System.Windows.Forms.ComboBox cmb_sehir;
        private System.Windows.Forms.RadioButton rdb_evli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_grafikler;
        private System.Windows.Forms.Button btn_istatistik;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.GroupBox groupBox3;
        private Personel_Veri_TabaniDataSet personel_Veri_TabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private Personel_Veri_TabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Personel_Veri_TabanıDataSet1 personel_Veri_TabanıDataSet1;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource1;
        private Personel_Veri_TabanıDataSet1TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Per_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_cıkıs;
        private System.Windows.Forms.Button button_rapor;
    }
}

