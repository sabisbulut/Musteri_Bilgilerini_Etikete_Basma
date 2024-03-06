namespace WindowsFormsApp3
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.btn_kapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_kullanci_adi = new DevExpress.XtraEditors.TextEdit();
            this.txt_sifre = new DevExpress.XtraEditors.TextEdit();
            this.btn_giris_yap = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.btn_sifre_ac = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanci_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl6
            // 
            this.panelControl6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelControl6.Appearance.Options.UseBackColor = true;
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl6.Controls.Add(this.btn_kapat);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl6.Location = new System.Drawing.Point(0, 0);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(516, 76);
            this.panelControl6.TabIndex = 4;
            // 
            // btn_kapat
            // 
            this.btn_kapat.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btn_kapat.AppearanceDisabled.Options.UseBorderColor = true;
            this.btn_kapat.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent;
            this.btn_kapat.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_kapat.AppearancePressed.BorderColor = System.Drawing.Color.Transparent;
            this.btn_kapat.AppearancePressed.Options.UseBorderColor = true;
            this.btn_kapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kapat.BackgroundImage")));
            this.btn_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_kapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.ImageOptions.Image")));
            this.btn_kapat.Location = new System.Drawing.Point(456, 12);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_kapat.Size = new System.Drawing.Size(57, 49);
            this.btn_kapat.TabIndex = 1;
            this.btn_kapat.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sui Generis Rg", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(116, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(269, 72);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "YILKAR";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 255);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(516, 83);
            this.panelControl1.TabIndex = 5;
            // 
            // txt_kullanci_adi
            // 
            this.txt_kullanci_adi.Location = new System.Drawing.Point(173, 101);
            this.txt_kullanci_adi.Name = "txt_kullanci_adi";
            this.txt_kullanci_adi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_kullanci_adi.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txt_kullanci_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_kullanci_adi.Properties.Appearance.Options.UseForeColor = true;
            this.txt_kullanci_adi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_kullanci_adi.Size = new System.Drawing.Size(198, 28);
            this.txt_kullanci_adi.TabIndex = 6;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(173, 154);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_sifre.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txt_sifre.Properties.Appearance.Options.UseFont = true;
            this.txt_sifre.Properties.Appearance.Options.UseForeColor = true;
            this.txt_sifre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_sifre.Properties.UseSystemPasswordChar = true;
            this.txt_sifre.Size = new System.Drawing.Size(198, 28);
            this.txt_sifre.TabIndex = 7;
            // 
            // btn_giris_yap
            // 
            this.btn_giris_yap.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris_yap.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_giris_yap.Appearance.Options.UseFont = true;
            this.btn_giris_yap.Appearance.Options.UseForeColor = true;
            this.btn_giris_yap.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.btn_giris_yap.AppearanceDisabled.Options.UseBorderColor = true;
            this.btn_giris_yap.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btn_giris_yap.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_giris_yap.AppearancePressed.BorderColor = System.Drawing.Color.White;
            this.btn_giris_yap.AppearancePressed.Options.UseBorderColor = true;
            this.btn_giris_yap.Location = new System.Drawing.Point(173, 214);
            this.btn_giris_yap.Name = "btn_giris_yap";
            this.btn_giris_yap.Size = new System.Drawing.Size(198, 29);
            this.btn_giris_yap.TabIndex = 8;
            this.btn_giris_yap.Text = "Giriş Yap";
            this.btn_giris_yap.Click += new System.EventHandler(this.btn_giris_yap_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(116, 93);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(40, 38);
            this.pictureEdit1.TabIndex = 9;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(116, 154);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit2.Size = new System.Drawing.Size(40, 30);
            this.pictureEdit2.TabIndex = 10;
            // 
            // btn_sifre_ac
            // 
            this.btn_sifre_ac.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_sifre_ac.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_sifre_ac.Appearance.Options.UseBackColor = true;
            this.btn_sifre_ac.Appearance.Options.UseBorderColor = true;
            this.btn_sifre_ac.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.btn_sifre_ac.AppearanceDisabled.Options.UseBorderColor = true;
            this.btn_sifre_ac.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btn_sifre_ac.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_sifre_ac.AppearancePressed.BorderColor = System.Drawing.Color.White;
            this.btn_sifre_ac.AppearancePressed.Options.UseBorderColor = true;
            this.btn_sifre_ac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sifre_ac.ImageOptions.Image")));
            this.btn_sifre_ac.Location = new System.Drawing.Point(384, 157);
            this.btn_sifre_ac.Margin = new System.Windows.Forms.Padding(0);
            this.btn_sifre_ac.Name = "btn_sifre_ac";
            this.btn_sifre_ac.Size = new System.Drawing.Size(43, 29);
            this.btn_sifre_ac.TabIndex = 11;
            this.btn_sifre_ac.Click += new System.EventHandler(this.btn_sifre_ac_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Location = new System.Drawing.Point(173, 137);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(198, 10);
            this.panelControl2.TabIndex = 7;
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Location = new System.Drawing.Point(173, 188);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(198, 10);
            this.panelControl3.TabIndex = 8;
            // 
            // AnaForm
            // 
            this.AcceptButton = this.btn_giris_yap;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 338);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.btn_sifre_ac);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btn_giris_yap);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullanci_adi);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl6);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanci_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_kapat;
        private DevExpress.XtraEditors.TextEdit txt_kullanci_adi;
        private DevExpress.XtraEditors.TextEdit txt_sifre;
        private DevExpress.XtraEditors.SimpleButton btn_giris_yap;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.SimpleButton btn_sifre_ac;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
    }
}