namespace Ders_76_92_Personel_Kayıt_Projesi
{
    partial class Form_rapor
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_Veri_TabanıDataSet2 = new Ders_76_92_Personel_Kayıt_Projesi.Personel_Veri_TabanıDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_PersonelTableAdapter = new Ders_76_92_Personel_Kayıt_Projesi.Personel_Veri_TabanıDataSet2TableAdapters.Tbl_PersonelTableAdapter();
            this.personel_Veri_TabanıDataSet1 = new Ders_76_92_Personel_Kayıt_Projesi.Personel_Veri_TabanıDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabanıDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabanıDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personel_Veri_TabanıDataSet2;
            // 
            // personel_Veri_TabanıDataSet2
            // 
            this.personel_Veri_TabanıDataSet2.DataSetName = "Personel_Veri_TabanıDataSet2";
            this.personel_Veri_TabanıDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblPersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ders_76_92_Personel_Kayıt_Projesi.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(600, 366);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // personel_Veri_TabanıDataSet1
            // 
            this.personel_Veri_TabanıDataSet1.DataSetName = "Personel_Veri_TabanıDataSet";
            this.personel_Veri_TabanıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form_rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form_rapor";
            this.Text = "Tüm Kayıtlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabanıDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabanıDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Personel_Veri_TabanıDataSet2 personel_Veri_TabanıDataSet2;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private Personel_Veri_TabanıDataSet2TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private Personel_Veri_TabanıDataSet personel_Veri_TabanıDataSet1;
    }
}