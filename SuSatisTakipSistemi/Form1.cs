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
    public partial class Form1 : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        private int telNo1;
        RaporForm rf = new RaporForm();

        public int GettelNo()
        {
            return telNo1;
        }

        public void SettelNo(int value)
        {
            telNo1 = value;
        }

        AboneListesiForm aboneListesiForm = new AboneListesiForm();

        public Form1()
        {
            InitializeComponent();
            saatTimer.Start();
        }

        private void saatTimer_Tick(object sender, EventArgs e)
        {
            tarihText.Text = DateTime.Now.ToLongDateString();
            saatText.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sonSiparisleriGetir();
            
        }

        private void aboneListesiButton_Click(object sender, EventArgs e)
        {
            AboneListesiForm aboneListesiForm = new AboneListesiForm();
            aboneListesiForm.Show();
        }

        private void stokDurumuButton_Click(object sender, EventArgs e)
        {
            StokDurumuForm stokDurumuForm = new StokDurumuForm();
            stokDurumuForm.Show();
        }

        private void fiyatListesiButton_Click(object sender, EventArgs e)
        {
            FiyatListesiForm fiyatListesiForm = new FiyatListesiForm();
            fiyatListesiForm.Show();
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

        private void borcluAbonelerButton_Click(object sender, EventArgs e)
        {
            BorcluAbonelerForm borcluAbonelerForm = new BorcluAbonelerForm();
            borcluAbonelerForm.Show();
        }

        private void siparişEkleButton_Click(object sender, EventArgs e)
        {
            SiparisEkleForm siparisEkleForm = new SiparisEkleForm();
            siparisEkleForm.Show();
        }

        private void siparişSilButton_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM siparisTable WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", dataGridViewSiparisler.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            sonSiparisleriGetir();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            sonSiparisleriGetir();            
        }

        private void aboneBilgileriButton_Click(object sender, EventArgs e)
        {
            string telNumSTR = dataGridViewSiparisler.CurrentRow.Cells[3].Value.ToString();
            int num = Int32.Parse(telNumSTR);
            SettelNo(num);
            aboneListesiForm.Show();
            //AboneListesiForm.dataGridViewAboneListesi.Rows[3].Selected = true;                     
        }

       

        private void raporlarButton_Click(object sender, EventArgs e)
        {
            rf.Show();
        }
    }
}
