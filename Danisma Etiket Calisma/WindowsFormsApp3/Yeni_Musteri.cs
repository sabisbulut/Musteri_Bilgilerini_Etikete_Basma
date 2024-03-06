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
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Yeni_Musteri : DevExpress.XtraEditors.XtraForm
    {
        public Yeni_Musteri()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into anl_RaskarCustomerDetail(Customer, Adress) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("p1", txt_musteri_adi.Text);
            komut.Parameters.AddWithValue("@p2", rich_alici_adres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Müşteri Eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Yeni_Musteri_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                YazdırmaEkranı yazdırmaEkranı = Application.OpenForms["YazdırmaEkranı"] as YazdırmaEkranı;
                if (yazdırmaEkranı!=null)
                {
                    yazdırmaEkranı.raskar_alici();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}