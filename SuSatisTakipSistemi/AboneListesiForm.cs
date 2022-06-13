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
    public partial class AboneListesiForm : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public AboneListesiForm()
        {
            InitializeComponent();
        }

        private void AboneListesiForm_Load(object sender, EventArgs e)
        {
            aboneListesiGetir();
            fiyatlarıGetir();
            markaEkle();
        }
        public void aboneListesiGetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-RV1ITGE\\SQLEXPRESS;Initial Catalog=suSatis;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM aboneTable", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewAboneListesi.DataSource = tablo;
            baglanti.Close();
        }

        private void aboneEkleButton_Click(object sender, EventArgs e)
        {
                     
            /*for(int i = 0; i < dataGridViewAboneListesi.Rows.Count - 1; i++)
            {
                if (dataGridViewAboneListesi.Rows[i].Cells["TelefonNo"].Value.ToString().Equals(textBoxTelNo.Text.ToString()))
                {
                    MessageBox.Show("Bu Telefon Numarasına Sahip Müşteri Halihazırda Kayıtlarda Mevcut");
                    goto outside;
                }
                else
                {*/
                    string sorgu = "INSERT INTO aboneTable(AdSoyad, Adres, TelefonNo, TercihEdilenMarka, Borç) VALUES (@AdSoyad, @Adres, @TelefonNo, @TercihEdilenMarka, @Borç)";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@AdSoyad", textBoxAdSoyad.Text);
                    komut.Parameters.AddWithValue("@TelefonNo", textBoxTelNo.Text);
                    komut.Parameters.AddWithValue("@TercihEdilenMarka", textBoxMarka.Text);
                    komut.Parameters.AddWithValue("@Borç", textBoxBorc.Text);
                    komut.Parameters.AddWithValue("@Adres", richTextBoxAdres.Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    aboneListesiGetir();
                //}
            //}
       
            
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE aboneTable SET AdSoyad=@AdSoyad, Adres=@Adres, TelefonNo=@TelefonNo, TercihEdilenMarka = @TercihEdilenMarka, Borç = @Borç  WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@AdSoyad", textBoxAdSoyad.Text);
            komut.Parameters.AddWithValue("@TelefonNo", textBoxTelNo.Text);
            komut.Parameters.AddWithValue("@TercihEdilenMarka", textBoxMarka.Text);
            komut.Parameters.AddWithValue("@Borç", textBoxBorc.Text);
            komut.Parameters.AddWithValue("@Adres", richTextBoxAdres.Text);
            komut.Parameters.AddWithValue("@ID", dataGridViewAboneListesi.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            aboneListesiGetir();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM aboneTable WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", dataGridViewAboneListesi.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            aboneListesiGetir();
        }

        private void dataGridViewAboneListesi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAdSoyad.Text = dataGridViewAboneListesi.CurrentRow.Cells[1].Value.ToString();
            textBoxTelNo.Text = dataGridViewAboneListesi.CurrentRow.Cells[3].Value.ToString();
            textBoxMarka.Text = dataGridViewAboneListesi.CurrentRow.Cells[4].Value.ToString();
            textBoxBorc.Text = dataGridViewAboneListesi.CurrentRow.Cells[5].Value.ToString();
            richTextBoxAdres.Text = dataGridViewAboneListesi.CurrentRow.Cells[2].Value.ToString();
        }

        private void aboneSayisiTimer_Tick(object sender, EventArgs e)
        {
            aboneSayisiText.Text = dataGridViewAboneListesi.Rows.Count.ToString();
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

        public void markaEkle()
        {
            for(int i = 0; i < dataGridViewFiyatListesi.Rows.Count - 1; i++)
            {
                string marka = dataGridViewFiyatListesi.Rows[i].Cells["Marka"].Value.ToString();
                textBoxMarka.Items.Add(marka);
            }
        }
    }
}
