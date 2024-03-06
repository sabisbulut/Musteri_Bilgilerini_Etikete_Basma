using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AnaForm : DevExpress.XtraEditors.XtraForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_sifre_ac_Click(object sender, EventArgs e)
        {
            txt_sifre.Properties.UseSystemPasswordChar = false;
        }

        string kullaniciadi = "yilkar16";
        string sifre = "ylkr1616";
        private void btn_giris_yap_Click(object sender, EventArgs e)
        {
            if( txt_kullanci_adi.Text == kullaniciadi && txt_sifre.Text ==sifre )
            {
                YazdırmaEkranı yazdırmaEkranı = new YazdırmaEkranı();
                yazdırmaEkranı.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı adı veya Şifre girdiniz", "Giriş Sorunu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            txt_kullanci_adi.Text = kullaniciadi;
        }
    }
}