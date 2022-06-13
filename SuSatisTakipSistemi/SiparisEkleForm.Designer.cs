
namespace SuSatisTakipSistemi
{
    partial class SiparisEkleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxAboneAdi = new System.Windows.Forms.TextBox();
            this.dateTimePickerTeslimatTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxSuMarkasi = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelNo = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxAdres = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTutar = new System.Windows.Forms.Label();
            this.ekleButton = new System.Windows.Forms.Button();
            this.teslimatTarihi = new System.Windows.Forms.Timer(this.components);
            this.adAdresTutar = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewAbone = new System.Windows.Forms.DataGridView();
            this.dataGridViewFiyatListesi = new System.Windows.Forms.DataGridView();
            this.dataGridViewStokDurumu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiyatListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStokDurumu)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAboneAdi
            // 
            this.textBoxAboneAdi.Enabled = false;
            this.textBoxAboneAdi.Location = new System.Drawing.Point(173, 41);
            this.textBoxAboneAdi.Name = "textBoxAboneAdi";
            this.textBoxAboneAdi.Size = new System.Drawing.Size(200, 20);
            this.textBoxAboneAdi.TabIndex = 2;
            // 
            // dateTimePickerTeslimatTarihi
            // 
            this.dateTimePickerTeslimatTarihi.Location = new System.Drawing.Point(173, 14);
            this.dateTimePickerTeslimatTarihi.Name = "dateTimePickerTeslimatTarihi";
            this.dateTimePickerTeslimatTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTeslimatTarihi.TabIndex = 5;
            this.dateTimePickerTeslimatTarihi.Value = new System.DateTime(2021, 2, 8, 16, 48, 28, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Teslimat Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Abone Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Su Markası :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TextBoxSuMarkasi);
            this.panel1.Controls.Add(this.maskedTextBoxTelNo);
            this.panel1.Controls.Add(this.numericUpDownAdet);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.richTextBoxAdres);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxAboneAdi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePickerTeslimatTarihi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 265);
            this.panel1.TabIndex = 12;
            // 
            // TextBoxSuMarkasi
            // 
            this.TextBoxSuMarkasi.Enabled = false;
            this.TextBoxSuMarkasi.Location = new System.Drawing.Point(173, 98);
            this.TextBoxSuMarkasi.Name = "TextBoxSuMarkasi";
            this.TextBoxSuMarkasi.Size = new System.Drawing.Size(202, 20);
            this.TextBoxSuMarkasi.TabIndex = 18;
            // 
            // maskedTextBoxTelNo
            // 
            this.maskedTextBoxTelNo.BeepOnError = true;
            this.maskedTextBoxTelNo.Location = new System.Drawing.Point(173, 70);
            this.maskedTextBoxTelNo.Mask = "000000";
            this.maskedTextBoxTelNo.Name = "maskedTextBoxTelNo";
            this.maskedTextBoxTelNo.Size = new System.Drawing.Size(202, 20);
            this.maskedTextBoxTelNo.TabIndex = 17;
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Location = new System.Drawing.Point(173, 124);
            this.numericUpDownAdet.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownAdet.TabIndex = 15;
            this.numericUpDownAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adet :";
            // 
            // richTextBoxAdres
            // 
            this.richTextBoxAdres.Enabled = false;
            this.richTextBoxAdres.Location = new System.Drawing.Point(173, 150);
            this.richTextBoxAdres.Name = "richTextBoxAdres";
            this.richTextBoxAdres.Size = new System.Drawing.Size(200, 103);
            this.richTextBoxAdres.TabIndex = 13;
            this.richTextBoxAdres.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(489, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 34);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tutar :";
            // 
            // labelTutar
            // 
            this.labelTutar.AutoSize = true;
            this.labelTutar.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTutar.Location = new System.Drawing.Point(608, 38);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(31, 34);
            this.labelTutar.TabIndex = 15;
            this.labelTutar.Text = "0";
            // 
            // ekleButton
            // 
            this.ekleButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleButton.ForeColor = System.Drawing.Color.Black;
            this.ekleButton.Location = new System.Drawing.Point(474, 190);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(299, 80);
            this.ekleButton.TabIndex = 16;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // teslimatTarihi
            // 
            this.teslimatTarihi.Enabled = true;
            this.teslimatTarihi.Interval = 1000;
            this.teslimatTarihi.Tick += new System.EventHandler(this.teslimatTarihi_Tick);
            // 
            // adAdresTutar
            // 
            this.adAdresTutar.Tick += new System.EventHandler(this.adAdresTutar_Tick);
            // 
            // dataGridViewAbone
            // 
            this.dataGridViewAbone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbone.Location = new System.Drawing.Point(781, 5);
            this.dataGridViewAbone.Name = "dataGridViewAbone";
            this.dataGridViewAbone.Size = new System.Drawing.Size(15, 18);
            this.dataGridViewAbone.TabIndex = 17;
            this.dataGridViewAbone.Visible = false;
            // 
            // dataGridViewFiyatListesi
            // 
            this.dataGridViewFiyatListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiyatListesi.Location = new System.Drawing.Point(781, 29);
            this.dataGridViewFiyatListesi.Name = "dataGridViewFiyatListesi";
            this.dataGridViewFiyatListesi.Size = new System.Drawing.Size(15, 22);
            this.dataGridViewFiyatListesi.TabIndex = 18;
            this.dataGridViewFiyatListesi.Visible = false;
            // 
            // dataGridViewStokDurumu
            // 
            this.dataGridViewStokDurumu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStokDurumu.Location = new System.Drawing.Point(781, 55);
            this.dataGridViewStokDurumu.Name = "dataGridViewStokDurumu";
            this.dataGridViewStokDurumu.Size = new System.Drawing.Size(15, 13);
            this.dataGridViewStokDurumu.TabIndex = 19;
            this.dataGridViewStokDurumu.Visible = false;
            // 
            // SiparisEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 277);
            this.Controls.Add(this.dataGridViewStokDurumu);
            this.Controls.Add(this.dataGridViewFiyatListesi);
            this.Controls.Add(this.dataGridViewAbone);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.labelTutar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "SiparisEkleForm";
            this.Text = "SiparisEkleForm";
            this.Load += new System.EventHandler(this.SiparisEkleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiyatListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStokDurumu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAboneAdi;
        private System.Windows.Forms.DateTimePicker dateTimePickerTeslimatTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBoxAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Timer teslimatTarihi;
        private System.Windows.Forms.Timer adAdresTutar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelNo;
        private System.Windows.Forms.DataGridView dataGridViewAbone;
        private System.Windows.Forms.DataGridView dataGridViewFiyatListesi;
        private System.Windows.Forms.TextBox TextBoxSuMarkasi;
        private System.Windows.Forms.DataGridView dataGridViewStokDurumu;
    }
}