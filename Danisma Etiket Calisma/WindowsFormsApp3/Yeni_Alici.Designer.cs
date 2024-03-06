namespace WindowsFormsApp3
{
    partial class Yeni_Alici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yeni_Alici));
            this.rich_alici_adres = new System.Windows.Forms.RichTextBox();
            this.cmb_ucret_tipi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_telefon_no = new DevExpress.XtraEditors.TextEdit();
            this.txt_ilgili_kisi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_alici_adi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_kaydet_kapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ucret_tipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_telefon_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ilgili_kisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_alici_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rich_alici_adres
            // 
            this.rich_alici_adres.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.rich_alici_adres.Location = new System.Drawing.Point(20, 284);
            this.rich_alici_adres.Name = "rich_alici_adres";
            this.rich_alici_adres.Size = new System.Drawing.Size(415, 142);
            this.rich_alici_adres.TabIndex = 5;
            this.rich_alici_adres.Text = "";
            // 
            // cmb_ucret_tipi
            // 
            this.cmb_ucret_tipi.Location = new System.Drawing.Point(216, 195);
            this.cmb_ucret_tipi.Name = "cmb_ucret_tipi";
            this.cmb_ucret_tipi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_ucret_tipi.Properties.Appearance.Options.UseFont = true;
            this.cmb_ucret_tipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ucret_tipi.Size = new System.Drawing.Size(219, 32);
            this.cmb_ucret_tipi.TabIndex = 4;
            // 
            // txt_telefon_no
            // 
            this.txt_telefon_no.Location = new System.Drawing.Point(174, 146);
            this.txt_telefon_no.Name = "txt_telefon_no";
            this.txt_telefon_no.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.txt_telefon_no.Properties.Appearance.Options.UseFont = true;
            this.txt_telefon_no.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.txt_telefon_no.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txt_telefon_no.Properties.MaskSettings.Set("mask", "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d");
            this.txt_telefon_no.Size = new System.Drawing.Size(261, 32);
            this.txt_telefon_no.TabIndex = 3;
            // 
            // txt_ilgili_kisi
            // 
            this.txt_ilgili_kisi.Location = new System.Drawing.Point(174, 96);
            this.txt_ilgili_kisi.Name = "txt_ilgili_kisi";
            this.txt_ilgili_kisi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.txt_ilgili_kisi.Properties.Appearance.Options.UseFont = true;
            this.txt_ilgili_kisi.Size = new System.Drawing.Size(261, 32);
            this.txt_ilgili_kisi.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(20, 253);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(131, 25);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "ALICI ADRESİ :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(20, 198);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(183, 25);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "KARGO ÜCRET TİPİ :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(20, 153);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(126, 25);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "TELEFON NO :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(102, 25);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "İLGİLİ KİŞİ :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 25);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "ALICI :";
            // 
            // txt_alici_adi
            // 
            this.txt_alici_adi.Location = new System.Drawing.Point(174, 44);
            this.txt_alici_adi.Name = "txt_alici_adi";
            this.txt_alici_adi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.txt_alici_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_alici_adi.Size = new System.Drawing.Size(261, 32);
            this.txt_alici_adi.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_kaydet_kapat);
            this.groupControl1.Controls.Add(this.txt_alici_adi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.rich_alici_adres);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.cmb_ucret_tipi);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_telefon_no);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txt_ilgili_kisi);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Location = new System.Drawing.Point(22, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(452, 516);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Yeni Alıcı Bilgileri";
            // 
            // btn_kaydet_kapat
            // 
            this.btn_kaydet_kapat.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_kaydet_kapat.Appearance.Options.UseFont = true;
            this.btn_kaydet_kapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet_kapat.ImageOptions.Image")));
            this.btn_kaydet_kapat.Location = new System.Drawing.Point(20, 445);
            this.btn_kaydet_kapat.Name = "btn_kaydet_kapat";
            this.btn_kaydet_kapat.Size = new System.Drawing.Size(415, 45);
            this.btn_kaydet_kapat.TabIndex = 6;
            this.btn_kaydet_kapat.Text = "KAYDET / KAPAT";
            this.btn_kaydet_kapat.Click += new System.EventHandler(this.btn_kaydet_kapat_Click);
            // 
            // Yeni_Alici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 544);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Yeni_Alici.IconOptions.LargeImage")));
            this.Name = "Yeni_Alici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Yeni_Alici_FormClosing);
            this.Load += new System.EventHandler(this.Yeni_Alici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ucret_tipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_telefon_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ilgili_kisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_alici_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rich_alici_adres;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_ucret_tipi;
        private DevExpress.XtraEditors.TextEdit txt_telefon_no;
        private DevExpress.XtraEditors.TextEdit txt_ilgili_kisi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_alici_adi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet_kapat;
    }
}