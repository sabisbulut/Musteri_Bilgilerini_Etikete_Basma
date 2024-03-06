using DevExpress.XtraEditors;
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

namespace WindowsFormsApp3
{
    public partial class Yeni_Alici : DevExpress.XtraEditors.XtraForm
    {
        public Yeni_Alici()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_kaydet_kapat_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into anl_KargoAliciListe(Gonderen, Alici,IlgiliKisi, Telefon, KargoUcret, AliciAdres) values ('YILKAR',@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txt_alici_adi.Text);
            komut.Parameters.AddWithValue("@p3", txt_ilgili_kisi.Text);
            komut.Parameters.AddWithValue("@p4", txt_telefon_no.Text);
            komut.Parameters.AddWithValue("@p5", cmb_ucret_tipi.Text);
            komut.Parameters.AddWithValue("@p6", rich_alici_adres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Alıcı Eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Yeni_Alici_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select distinct KargoUcret from anl_KargoAliciListe ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmb_ucret_tipi.Properties.Items.Add(dr["KargoUcret"]);
            }
        }

        private void Yeni_Alici_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                YazdırmaEkranı yazdırmaEkranı = Application.OpenForms["YazdırmaEkranı"] as YazdırmaEkranı;
                if (yazdırmaEkranı != null)
                {
                    yazdırmaEkranı.yilkar_alici();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}