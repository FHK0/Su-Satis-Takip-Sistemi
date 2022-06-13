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

namespace SuSatisTakipSistemi
{
    public partial class RaporForm : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public int erikliSatisAdet = 0;
        public int damlaSatisAdet = 0;
        public int sirmaSatisAdet = 0;
        public int nestleSatisAdet = 0;
        public int hayatSatisAdet = 0;
        public int erikliFiyat = 0;
        public int damlaFiyat = 0;
        public int sirmaFiyat = 0;
        public int nestleFiyat = 0;
        public int hayatFiyat = 0;



        int ciro;

        SiparisEkleForm siparisEkleForm = new SiparisEkleForm();


        public RaporForm()
        {
            InitializeComponent();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            fiyatlarıGetir();
            sonSiparisleriGetir();
            ciroHesapla();
            fiyatHesapla();
            adetHesapla();
        }
        
       /* public void stokDegisikligi()
        {
            lblErikliSatisAdet.Text = erikliSatisAdet.ToString();
            lblDamlaSatisAdet.Text = damlaSatisAdet.ToString();
            lblSirmaSatisAdet.Text = sirmaSatisAdet.ToString();
            lblNestleSatisAdet.Text = nestleSatisAdet.ToString();
            lblHayatSatisAdet.Text = hayatSatisAdet.ToString();
            if (siparisEkleForm.Marka.Equals("Erikli"))
            {
                int erikliAdet = Int32.Parse(siparisEkleForm.Adet);
                erikliSatisAdet += erikliAdet;
            }
            if (siparisEkleForm.Marka.Equals("Damla"))
            {
                int damlaAdet = Int32.Parse(siparisEkleForm.Adet);
                damlaSatisAdet += damlaAdet;
            }
            if (siparisEkleForm.Marka.Equals("Sırma"))
            {
                int sirmaAdet = Int32.Parse(siparisEkleForm.Adet);
                sirmaSatisAdet += sirmaAdet;
            }
            if (siparisEkleForm.Marka.Equals("Nestle"))
            {
                int nestleAdet = Int32.Parse(siparisEkleForm.Adet);
                nestleSatisAdet += nestleAdet;
            }
            if (siparisEkleForm.Marka.Equals("Hayat"))
            {
                int hayatAdet = Int32.Parse(siparisEkleForm.Adet);
                hayatSatisAdet += hayatAdet;
            }

        }*/

        public void ciroHesapla()
        {
            for(int i = 0; i < dataGridViewSiparisler.Rows.Count - 1; i++)
            {
                int tutar = Int32.Parse(dataGridViewSiparisler.Rows[i].Cells[6].Value.ToString());
                ciro += tutar;
            }
            lblCiro.Text = ciro.ToString() + " ₺";
        }

        public void fiyatHesapla()
        {
            for(int i = 0; i < dataGridViewFiyatListesi.Rows.Count - 1; i++)
            {
                if (dataGridViewFiyatListesi.Rows[i].Cells[1].Value.Equals("Erikli"))
                {
                    erikliFiyat = Int32.Parse(dataGridViewFiyatListesi.Rows[i].Cells[2].Value.ToString());
                }
                if (dataGridViewFiyatListesi.Rows[i].Cells[1].Value.Equals("Damla"))
                {
                    damlaFiyat = Int32.Parse(dataGridViewFiyatListesi.Rows[i].Cells[2].Value.ToString());
                }
                if (dataGridViewFiyatListesi.Rows[i].Cells[1].Value.Equals("Sırma"))
                {
                    sirmaFiyat = Int32.Parse(dataGridViewFiyatListesi.Rows[i].Cells[2].Value.ToString());
                }
                if (dataGridViewFiyatListesi.Rows[i].Cells[1].Value.Equals("Nestle"))
                {
                    nestleFiyat = Int32.Parse(dataGridViewFiyatListesi.Rows[i].Cells[2].Value.ToString());
                }
                if (dataGridViewFiyatListesi.Rows[i].Cells[1].Value.Equals("Hayat"))
                {
                    hayatFiyat = Int32.Parse(dataGridViewFiyatListesi.Rows[i].Cells[2].Value.ToString());
                }
            }
        
        }

        public void adetHesapla()
        {
            for (int i = 0; i < dataGridViewSiparisler.Rows.Count - 1; i++)
            {
                if (dataGridViewSiparisler.Rows[i].Cells[5].Value.Equals("Erikli"))
                {
                    int tutar = Int32.Parse(dataGridViewSiparisler.Rows[i].Cells[6].Value.ToString());
                    erikliSatisAdet += (tutar / erikliFiyat);
                }
                if (dataGridViewSiparisler.Rows[i].Cells[5].Value.Equals("Damla"))
                {
                    int tutar = Int32.Parse(dataGridViewSiparisler.Rows[i].Cells[6].Value.ToString());
                    damlaSatisAdet += (tutar / damlaFiyat);

                }
                if (dataGridViewSiparisler.Rows[i].Cells[5].Value.Equals("Sırma"))
                {
                    int tutar = Int32.Parse(dataGridViewSiparisler.Rows[i].Cells[6].Value.ToString());
                    sirmaSatisAdet += (tutar / sirmaFiyat);

                }
                if (dataGridViewSiparisler.Rows[i].Cells[5].Value.Equals("Nestle"))
                {
                    int tutar = Int32.Parse(dataGridViewSiparisler.Rows[i].Cells[6].Value.ToString());
                    nestleSatisAdet += (tutar / nestleFiyat);

                }
                if (dataGridViewSiparisler.Rows[i].Cells[5].Value.Equals("Hayat"))
                {
                    int tutar = Int32.Parse(dataGridViewSiparisler.Rows[i].Cells[6].Value.ToString());
                    hayatSatisAdet += (tutar / hayatFiyat);
                }
            }

            lblErikliSatisAdet.Text = erikliSatisAdet.ToString();
            lblDamlaSatisAdet.Text = damlaSatisAdet.ToString();
            lblSirmaSatisAdet.Text = sirmaSatisAdet.ToString();
            lblNestleSatisAdet.Text = nestleSatisAdet.ToString();
            lblHayatSatisAdet.Text = hayatSatisAdet.ToString();

            grafik.Series["Series1"].Points.AddXY("Erikli", erikliSatisAdet);
            grafik.Series["Series1"].Points.AddXY("Damla", damlaSatisAdet);
            grafik.Series["Series1"].Points.AddXY("Sırma", sirmaSatisAdet);
            grafik.Series["Series1"].Points.AddXY("Nestle", nestleSatisAdet);
            grafik.Series["Series1"].Points.AddXY("Hayat", hayatSatisAdet);
            grafik.Series["Series1"].IsValueShownAsLabel = true;
        }
      
        public void sonSiparisleriGetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-RV1ITGE\\SQLEXPRESS;Initial Catalog=suSatis;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM siparisTable", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewSiparisler.DataSource = tablo;
            baglanti.Close();
        }

        public void fiyatlarıGetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-RV1ITGE\\SQLEXPRESS;Initial Catalog=suSatis;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM fiyatListesiTable", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewFiyatListesi.DataSource = tablo;
            baglanti.Close();
        }
    }
}
