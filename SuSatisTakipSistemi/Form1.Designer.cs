
namespace SuSatisTakipSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.saatText = new System.Windows.Forms.Label();
            this.tarihText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sirketAdi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fiyatListesiButton = new System.Windows.Forms.Button();
            this.stokDurumuButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.raporlarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aboneListesiButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewSiparisler = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.siparişSilButton = new System.Windows.Forms.Button();
            this.siparişEkleButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.saatTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.saatText);
            this.panel1.Controls.Add(this.tarihText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.sirketAdi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1560, 112);
            this.panel1.TabIndex = 0;
            // 
            // saatText
            // 
            this.saatText.AutoSize = true;
            this.saatText.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saatText.Location = new System.Drawing.Point(1366, 52);
            this.saatText.Name = "saatText";
            this.saatText.Size = new System.Drawing.Size(66, 24);
            this.saatText.TabIndex = 2;
            this.saatText.Text = "SAAT";
            // 
            // tarihText
            // 
            this.tarihText.AutoSize = true;
            this.tarihText.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarihText.Location = new System.Drawing.Point(1297, 26);
            this.tarihText.Name = "tarihText";
            this.tarihText.Size = new System.Drawing.Size(79, 24);
            this.tarihText.TabIndex = 1;
            this.tarihText.Text = "TARİH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sirketAdi
            // 
            this.sirketAdi.AutoSize = true;
            this.sirketAdi.Font = new System.Drawing.Font("Modern No. 20", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sirketAdi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sirketAdi.Location = new System.Drawing.Point(233, 9);
            this.sirketAdi.Name = "sirketAdi";
            this.sirketAdi.Size = new System.Drawing.Size(595, 78);
            this.sirketAdi.TabIndex = 0;
            this.sirketAdi.Text = "KAPLAN Ticaret";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Location = new System.Drawing.Point(12, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 621);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fiyatListesiButton);
            this.groupBox3.Controls.Add(this.stokDurumuButton);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 511);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 103);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün";
            // 
            // fiyatListesiButton
            // 
            this.fiyatListesiButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiyatListesiButton.ForeColor = System.Drawing.Color.Black;
            this.fiyatListesiButton.Location = new System.Drawing.Point(6, 63);
            this.fiyatListesiButton.Name = "fiyatListesiButton";
            this.fiyatListesiButton.Size = new System.Drawing.Size(212, 34);
            this.fiyatListesiButton.TabIndex = 5;
            this.fiyatListesiButton.Text = "Fiyat Listesi";
            this.fiyatListesiButton.UseVisualStyleBackColor = true;
            this.fiyatListesiButton.Click += new System.EventHandler(this.fiyatListesiButton_Click);
            // 
            // stokDurumuButton
            // 
            this.stokDurumuButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokDurumuButton.ForeColor = System.Drawing.Color.Black;
            this.stokDurumuButton.Location = new System.Drawing.Point(7, 24);
            this.stokDurumuButton.Name = "stokDurumuButton";
            this.stokDurumuButton.Size = new System.Drawing.Size(212, 34);
            this.stokDurumuButton.TabIndex = 4;
            this.stokDurumuButton.Text = "Stok Durumu";
            this.stokDurumuButton.UseVisualStyleBackColor = true;
            this.stokDurumuButton.Click += new System.EventHandler(this.stokDurumuButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.raporlarButton);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 158);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genel Rapor";
            // 
            // raporlarButton
            // 
            this.raporlarButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raporlarButton.ForeColor = System.Drawing.Color.Black;
            this.raporlarButton.Location = new System.Drawing.Point(7, 24);
            this.raporlarButton.Name = "raporlarButton";
            this.raporlarButton.Size = new System.Drawing.Size(212, 128);
            this.raporlarButton.TabIndex = 4;
            this.raporlarButton.Text = "Rapor";
            this.raporlarButton.UseVisualStyleBackColor = true;
            this.raporlarButton.Click += new System.EventHandler(this.raporlarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aboneListesiButton);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 177);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abone İşlemleri";
            // 
            // aboneListesiButton
            // 
            this.aboneListesiButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboneListesiButton.ForeColor = System.Drawing.Color.Black;
            this.aboneListesiButton.Location = new System.Drawing.Point(7, 24);
            this.aboneListesiButton.Name = "aboneListesiButton";
            this.aboneListesiButton.Size = new System.Drawing.Size(212, 147);
            this.aboneListesiButton.TabIndex = 4;
            this.aboneListesiButton.Text = "Abone Listesi";
            this.aboneListesiButton.UseVisualStyleBackColor = true;
            this.aboneListesiButton.Click += new System.EventHandler(this.aboneListesiButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(2, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewSiparisler);
            this.panel3.Location = new System.Drawing.Point(260, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1312, 560);
            this.panel3.TabIndex = 2;
            // 
            // dataGridViewSiparisler
            // 
            this.dataGridViewSiparisler.AllowUserToAddRows = false;
            this.dataGridViewSiparisler.AllowUserToDeleteRows = false;
            this.dataGridViewSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSiparisler.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSiparisler.Name = "dataGridViewSiparisler";
            this.dataGridViewSiparisler.ReadOnly = true;
            this.dataGridViewSiparisler.Size = new System.Drawing.Size(1312, 560);
            this.dataGridViewSiparisler.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.siparişSilButton);
            this.panel4.Controls.Add(this.siparişEkleButton);
            this.panel4.Location = new System.Drawing.Point(260, 696);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1312, 55);
            this.panel4.TabIndex = 0;
            // 
            // siparişSilButton
            // 
            this.siparişSilButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siparişSilButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.siparişSilButton.Location = new System.Drawing.Point(224, 3);
            this.siparişSilButton.Name = "siparişSilButton";
            this.siparişSilButton.Size = new System.Drawing.Size(220, 45);
            this.siparişSilButton.TabIndex = 1;
            this.siparişSilButton.Text = "Siparişi Sil";
            this.siparişSilButton.UseVisualStyleBackColor = true;
            this.siparişSilButton.Click += new System.EventHandler(this.siparişSilButton_Click);
            // 
            // siparişEkleButton
            // 
            this.siparişEkleButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siparişEkleButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.siparişEkleButton.Location = new System.Drawing.Point(3, 3);
            this.siparişEkleButton.Name = "siparişEkleButton";
            this.siparişEkleButton.Size = new System.Drawing.Size(215, 45);
            this.siparişEkleButton.TabIndex = 0;
            this.siparişEkleButton.Text = "Sipariş Ekle";
            this.siparişEkleButton.UseVisualStyleBackColor = true;
            this.siparişEkleButton.Click += new System.EventHandler(this.siparişEkleButton_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(12, 752);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1560, 24);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fırat Hilmi KAPLAN - 05170000082";
            // 
            // saatTimer
            // 
            this.saatTimer.Interval = 1000;
            this.saatTimer.Tick += new System.EventHandler(this.saatTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1577, 786);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tarihText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sirketAdi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewSiparisler;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label saatText;
        private System.Windows.Forms.Timer saatTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button siparişEkleButton;
        private System.Windows.Forms.Button siparişSilButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button stokDurumuButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button raporlarButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button aboneListesiButton;
        private System.Windows.Forms.Button fiyatListesiButton;
        private System.Windows.Forms.Timer timer1;
    }
}

