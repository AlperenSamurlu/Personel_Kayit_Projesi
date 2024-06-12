namespace Ders_76_92_Personel_Kayıt_Projesi
{
    partial class Form_giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_sifreGoster = new System.Windows.Forms.Button();
            this.textBox_kullaiciadi = new System.Windows.Forms.TextBox();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.button_giris = new System.Windows.Forms.Button();
            this.label_hak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, -2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(534, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Takip Sistemi Giriş Paneli";
            // 
            // button_sifreGoster
            // 
            this.button_sifreGoster.Location = new System.Drawing.Point(334, 126);
            this.button_sifreGoster.Margin = new System.Windows.Forms.Padding(2);
            this.button_sifreGoster.Name = "button_sifreGoster";
            this.button_sifreGoster.Size = new System.Drawing.Size(86, 24);
            this.button_sifreGoster.TabIndex = 3;
            this.button_sifreGoster.Text = "Şifreyi Göster";
            this.button_sifreGoster.UseVisualStyleBackColor = true;
            this.button_sifreGoster.Click += new System.EventHandler(this.button_sifreGoster_Click);
            // 
            // textBox_kullaiciadi
            // 
            this.textBox_kullaiciadi.Location = new System.Drawing.Point(200, 103);
            this.textBox_kullaiciadi.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_kullaiciadi.Name = "textBox_kullaiciadi";
            this.textBox_kullaiciadi.Size = new System.Drawing.Size(130, 20);
            this.textBox_kullaiciadi.TabIndex = 4;
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(200, 128);
            this.textBox_sifre.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(130, 20);
            this.textBox_sifre.TabIndex = 5;
            this.textBox_sifre.UseSystemPasswordChar = true;
            // 
            // button_giris
            // 
            this.button_giris.Location = new System.Drawing.Point(229, 152);
            this.button_giris.Margin = new System.Windows.Forms.Padding(2);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(74, 28);
            this.button_giris.TabIndex = 6;
            this.button_giris.Text = "Giriş";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // label_hak
            // 
            this.label_hak.AutoSize = true;
            this.label_hak.Location = new System.Drawing.Point(198, 76);
            this.label_hak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hak.Name = "label_hak";
            this.label_hak.Size = new System.Drawing.Size(114, 13);
            this.label_hak.TabIndex = 7;
            this.label_hak.Text = "Kalan Deneme Hakkı: ";
            this.label_hak.Visible = false;
            // 
            // Form_giris
            // 
            this.AcceptButton = this.button_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label_hak);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.textBox_kullaiciadi);
            this.Controls.Add(this.button_sifreGoster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form_giris";
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_sifreGoster;
        private System.Windows.Forms.TextBox textBox_kullaiciadi;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.Label label_hak;
    }
}