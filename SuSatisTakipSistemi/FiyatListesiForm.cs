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
    public partial class FiyatListesiForm : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;


        public FiyatListesiForm()
        {
            InitializeComponent();
        }

        private void FiyatListesiForm_Load(object sender, EventArgs e)
        {
            fiyatlarıGetir();
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

        private void dataGridViewFiyatListesi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            markaTextBox.Text = dataGridViewFiyatListesi.CurrentRow.Cells[1].Value.ToString();
            fiyatTextBox.Text = dataGridViewFiyatListesi.CurrentRow.Cells[2].Value.ToString();
            labelMarkaAdi.Text = dataGridViewFiyatListesi.CurrentRow.Cells[1].Value.ToString();
            fiyatTextBox2.Text = dataGridViewFiyatListesi.CurrentRow.Cells[2].Value.ToString();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO fiyatListesiTable(Marka, Fiyat) VALUES (@Marka, @Fiyat)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Marka", markaTextBox.Text);
            komut.Parameters.AddWithValue("@Fiyat", fiyatTextBox.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            fiyatlarıGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM fiyatListesiTable WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", dataGridViewFiyatListesi.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            fiyatlarıGetir();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE fiyatListesiTable SET Fiyat=@Fiyat WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Fiyat", fiyatTextBox2.Text);
            komut.Parameters.AddWithValue("@ID", dataGridViewFiyatListesi.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            fiyatlarıGetir();
        }
    }
}
