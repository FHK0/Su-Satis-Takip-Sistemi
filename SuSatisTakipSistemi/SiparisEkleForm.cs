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
    public partial class SiparisEkleForm : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        //RaporForm raporForm = new RaporForm();
        private string marka;
        private string adet;

       /* public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string Adet
        {
            get { return adet; }
            set { adet = value; }
        }*/

       

        public SiparisEkleForm()
        {
            InitializeComponent();
        }

        private void SiparisEkleForm_Load(object sender, EventArgs e)
        {
            aboneListesiGetir();
            fiyatlarıGetir();
            stokDurumunuGetir();
            dateTimePickerTeslimatTarihi.MinDate = DateTime.Today;
            dateTimePickerTeslimatTarihi.Value = DateTime.Now;
        }

        private void teslimatTarihi_Tick(object sender, EventArgs e)
        {
            //dateTimePickerTeslimatTarihi.Value = DateTime.Now;

            string telNoStr = maskedTextBoxTelNo.Text.ToString();
            if(telNoStr.Length == 6)
            {
                //int telNo = Int32.Parse(telNoStr);
                adAdresTutar.Enabled = true;
                //MessageBox.Show("AdAdresTutar Çalıştı");
            }
            
        }

        public void stokDurumunuGetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-RV1ITGE\\SQLEXPRESS;Initial Catalog=suSatis;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM stokTable", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewStokDurumu.DataSource = tablo;
            baglanti.Close();
        }


        public void aboneListesiGetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-RV1ITGE\\SQLEXPRESS;Initial Catalog=suSatis;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM aboneTable", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewAbone.DataSource = tablo;
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

        private void adAdresTutar_Tick(object sender, EventArgs e)
        {
            string telNoStr = maskedTextBoxTelNo.Text;
            //int telNo = Int32.Parse(telNoStr);

            for (int i = 0; i < dataGridViewAbone.Rows.Count - 1; i++)
            {
                if (dataGridViewAbone.Rows[i].Cells[3].Value.ToString().Equals(telNoStr))
                {
                    string ad = dataGridViewAbone.Rows[i].Cells["AdSoyad"].Value.ToString();
                    textBoxAboneAdi.Text = ad;
                    richTextBoxAdres.Text = dataGridViewAbone.Rows[i].Cells["Adres"].Value.ToString();
                    TextBoxSuMarkasi.Text = dataGridViewAbone.Rows[i].Cells[4].Value.ToString();
                }
            }

            for(int i = 0; i < dataGridViewFiyatListesi.Rows.Count - 1; i++)
            {
                if (dataGridViewFiyatListesi.Rows[i].Cells[1].Value.ToString().Equals(TextBoxSuMarkasi.Text))
                {
                    int fiyat = Int32.Parse(dataGridViewFiyatListesi.Rows[i].Cells[2].Value.ToString());                
                    int adet = Int32.Parse(numericUpDownAdet.Value.ToString());
                    int tutar = fiyat * adet;
                    labelTutar.Text = tutar.ToString();
                }
            }

             //adAdresTutar.Enabled = false;
                          
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            string istenilenMarka = TextBoxSuMarkasi.Text;
            for(int i = 0; i < dataGridViewStokDurumu.Rows.Count - 1; i++)
            {
                if (dataGridViewStokDurumu.Rows[i].Cells["Marka"].Value.ToString().Equals(istenilenMarka))
                {
                    if(Int32.Parse(dataGridViewStokDurumu.Rows[i].Cells["Adet"].Value.ToString()) <= 0 || Int32.Parse(dataGridViewStokDurumu.Rows[i].Cells["Adet"].Value.ToString()) < numericUpDownAdet.Value)
                    {
                        MessageBox.Show("Yeterli Stok Yok");
                    }
                    else
                    {
                        string sorgu = "INSERT INTO siparisTable(TeslimatTarihi, AboneAdı, TelefonNo, Adres, SuMarkası, Tutar) VALUES (@TeslimatTarihi, @AboneAdı, @TelefonNo, @Adres, @SuMarkası, @Tutar)";
                        komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@TeslimatTarihi", dateTimePickerTeslimatTarihi.Value);
                        komut.Parameters.AddWithValue("@AboneAdı", textBoxAboneAdi.Text);
                        komut.Parameters.AddWithValue("@TelefonNo", maskedTextBoxTelNo.Text);
                        komut.Parameters.AddWithValue("@Adres", richTextBoxAdres.Text);
                        komut.Parameters.AddWithValue("@SuMarkası", TextBoxSuMarkasi.Text);
                        komut.Parameters.AddWithValue("@Tutar", labelTutar.Text);
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        int adet = (int)numericUpDownAdet.Value;

                        for(int j = 0; j < dataGridViewStokDurumu.Rows.Count - 1; j++)
                        {
                            if (dataGridViewStokDurumu.Rows[j].Cells["Marka"].Value.Equals(TextBoxSuMarkasi.Text))
                            {
                                int stok = Int32.Parse(dataGridViewStokDurumu.Rows[j].Cells["Adet"].Value.ToString());
                                stok -= adet;
                                dataGridViewStokDurumu.Rows[j].Cells["Adet"].Value = stok.ToString();
                                string sorgu2 = "UPDATE stokTable SET Adet=@Adet WHERE Marka=@Marka";
                                komut = new SqlCommand(sorgu2, baglanti);
                                komut.Parameters.AddWithValue("@Adet", stok);
                                komut.Parameters.AddWithValue("@Marka", TextBoxSuMarkasi.Text);
                                baglanti.Open();
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                            }
                        }

                        //marka = TextBoxSuMarkasi.Text;
                        //adet = numericUpDownAdet.Value.ToString();
                    }
                }
            }
          
            //form1.sonSiparisleriGetir();
            
        }
    }
}
