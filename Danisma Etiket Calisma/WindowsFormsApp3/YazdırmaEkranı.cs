using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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

    public partial class YazdırmaEkranı : DevExpress.XtraEditors.XtraForm
    {
        public YazdırmaEkranı()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Yeni_Alici alici = new Yeni_Alici();
            alici.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Yeni_Musteri musteri = new Yeni_Musteri();
            musteri.ShowDialog();
        }

        private void YazdırmaEkranı_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public void raskar_alici()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from anl_RaskarCustomerDetail", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            lookup_raskar_alici.Properties.ValueMember = "Id";
            lookup_raskar_alici.Properties.DisplayMember = "Customer";
            lookup_raskar_alici.Properties.DataSource = dt;
            lookup_raskar_alici.Properties.NullText = "Alıcı Seçiniz";
        }

        public void yilkar_alici()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from anl_KargoAliciListe", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            lookup_ylkr_alici.Properties.ValueMember = "Id";
            lookup_ylkr_alici.Properties.DisplayMember = "Alici";
            lookup_ylkr_alici.Properties.DataSource = dt;
            lookup_ylkr_alici.Properties.NullText = "Alıcı Seçiniz";
        }
        private void YazdırmaEkranı_Load(object sender, EventArgs e)
        {
            raskar_alici();
            yilkar_alici();
            SqlCommand komut = new SqlCommand("select distinct KargoUcret from anl_KargoAliciListe ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_kargo.Properties.Items.Add(dr["KargoUcret"]);
            }
        }

        private void lookup_raskar_alici_EditValueChanged_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from anl_RaskarCustomerDetail where Id =@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lookup_raskar_alici.EditValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                rich_raskar_alici_adres.Text = dr["Adress"].ToString();
            }
            bgl.baglanti().Close();
        }

        private void lookup_ylkr_alici_EditValueChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from anl_KargoAliciListe where Id =@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lookup_ylkr_alici.EditValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_ilgili_kisi.Text = dr["IlgiliKisi"].ToString();
                txt_phone_no.Text = dr["Telefon"].ToString();
                cmb_kargo.Text = dr["KargoUcret"].ToString();
                rich_ylkr_alici_adres.Text = dr["AliciAdres"].ToString();
            }
            bgl.baglanti().Close();
        }

        void Ryazdir(Etiket reprort)
        {
            using (ReportPrintTool tool = new ReportPrintTool(reprort))
            {
                //tool.ShowPreviewDialog();
                tool.Print();
            }
        }
        void Yyazdir(Yilkar reprort)
        {
            using (ReportPrintTool tool = new ReportPrintTool(reprort))
            {
                tool.ShowPreviewDialog();
                //tool.Print();
            }
        }
        private void btn_raskar_yazdir_Click(object sender, EventArgs e)
        {

            int baslangic = Convert.ToInt16(spin_raskar_adet.Text);
            int bitis = Convert.ToInt16(spinEditbitis.Text) + 1;

            for (int i = baslangic; i < bitis; i++)
            {
                List<Raskar> raskar_list = new List<Raskar>();
                Etiket raskaretiket = new Etiket();


                Raskar raskar = new Raskar();
                raskar.customer = lookup_raskar_alici.Text;
                raskar.adres = rich_raskar_alici_adres.Text;
                raskar.paket_no = i;

                raskar_list.Add(raskar);

                raskaretiket.DataSource = raskar_list;
                Ryazdir(raskaretiket);

            }



        }

        private void btn_ylkr_yazdir_Click(object sender, EventArgs e)
        {
            YilkarEtiketSınıfı etiketSınıfı = new YilkarEtiketSınıfı();
            Yilkar yilkaretiket = new Yilkar();
            List<YilkarEtiketSınıfı> yilkar_list = new List<YilkarEtiketSınıfı>();

            for (int i = 0; i < Convert.ToInt32(spin_ylkr_adet.Text); i++)
            {
                etiketSınıfı.alici = lookup_ylkr_alici.Text;
                etiketSınıfı.ilgili_kisi = txt_ilgili_kisi.Text;
                etiketSınıfı.Telefon = txt_phone_no.Text;
                etiketSınıfı.Kargo = cmb_kargo.Text;
                etiketSınıfı.adres = "Adres: " + rich_ylkr_alici_adres.Text;

                yilkar_list.Add(etiketSınıfı);
                yilkaretiket.DataSource = yilkar_list;
            }

            Yyazdir(yilkaretiket);
        }
    }
}