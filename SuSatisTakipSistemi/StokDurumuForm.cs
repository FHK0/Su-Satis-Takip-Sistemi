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
    public partial class StokDurumuForm : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public StokDurumuForm()
        {
            InitializeComponent();
        }

        private void StokDurumuForm_Load(object sender, EventArgs e)
        {
            stokDurumunuGetir();
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

        private void dataGridViewStokDurumu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            markaTextBox.Text = dataGridViewStokDurumu.CurrentRow.Cells[1].Value.ToString();
            adetTextBox.Text = dataGridViewStokDurumu.CurrentRow.Cells[2].Value.ToString();
            markaAdiLabel.Text = dataGridViewStokDurumu.CurrentRow.Cells[1].Value.ToString();
            adetTextBox2.Text = dataGridViewStokDurumu.CurrentRow.Cells[2].Value.ToString();
        }

        private void stokEkleButton_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO stokTable(Marka, Adet) VALUES (@Marka, @Adet)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Marka", markaTextBox.Text);
            komut.Parameters.AddWithValue("@Adet", adetTextBox.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            stokDurumunuGetir();
        }

        private void stokGuncelleButton_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE stokTable SET Adet=@Adet WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Adet", adetTextBox2.Text);
            komut.Parameters.AddWithValue("@ID", dataGridViewStokDurumu.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            stokDurumunuGetir();
        }

        private void stokFiyatlandırmayıSilButton_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM stokTable WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", dataGridViewStokDurumu.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            stokDurumunuGetir();
        }
    }
}
