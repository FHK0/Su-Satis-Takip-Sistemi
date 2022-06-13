
namespace SuSatisTakipSistemi
{
    partial class AboneListesiForm
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
            this.dataGridViewAboneListesi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.richTextBoxAdres = new System.Windows.Forms.RichTextBox();
            this.aboneEkleButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxBorc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.silButton = new System.Windows.Forms.Button();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.aboneSayisiText = new System.Windows.Forms.Label();
            this.aboneSayisiTimer = new System.Windows.Forms.Timer(this.components);
            this.textBoxTelNo = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewFiyatListesi = new System.Windows.Forms.DataGridView();
            this.textBoxMarka = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAboneListesi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiyatListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAboneListesi
            // 
            this.dataGridViewAboneListesi.AllowUserToAddRows = false;
            this.dataGridViewAboneListesi.AllowUserToDeleteRows = false;
            this.dataGridViewAboneListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAboneListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAboneListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAboneListesi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAboneListesi.Name = "dataGridViewAboneListesi";
            this.dataGridViewAboneListesi.ReadOnly = true;
            this.dataGridViewAboneListesi.Size = new System.Drawing.Size(995, 346);
            this.dataGridViewAboneListesi.TabIndex = 0;
            this.dataGridViewAboneListesi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAboneListesi_CellEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewAboneListesi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 346);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tercih Edilen Marka :";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(243, 15);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(309, 20);
            this.textBoxAdSoyad.TabIndex = 6;
            // 
            // richTextBoxAdres
            // 
            this.richTextBoxAdres.Location = new System.Drawing.Point(84, 137);
            this.richTextBoxAdres.Name = "richTextBoxAdres";
            this.richTextBoxAdres.Size = new System.Drawing.Size(468, 96);
            this.richTextBoxAdres.TabIndex = 9;
            this.richTextBoxAdres.Text = "";
            // 
            // aboneEkleButton
            // 
            this.aboneEkleButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboneEkleButton.ForeColor = System.Drawing.Color.Black;
            this.aboneEkleButton.Location = new System.Drawing.Point(8, 239);
            this.aboneEkleButton.Name = "aboneEkleButton";
            this.aboneEkleButton.Size = new System.Drawing.Size(173, 42);
            this.aboneEkleButton.TabIndex = 12;
            this.aboneEkleButton.Text = "Ekle";
            this.aboneEkleButton.UseVisualStyleBackColor = true;
            this.aboneEkleButton.Click += new System.EventHandler(this.aboneEkleButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBoxMarka);
            this.panel2.Controls.Add(this.textBoxTelNo);
            this.panel2.Controls.Add(this.textBoxBorc);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.silButton);
            this.panel2.Controls.Add(this.guncelleButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.aboneEkleButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.richTextBoxAdres);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxAdSoyad);
            this.panel2.Location = new System.Drawing.Point(12, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 288);
            this.panel2.TabIndex = 13;
            // 
            // textBoxBorc
            // 
            this.textBoxBorc.Location = new System.Drawing.Point(243, 111);
            this.textBoxBorc.Name = "textBoxBorc";
            this.textBoxBorc.Size = new System.Drawing.Size(309, 20);
            this.textBoxBorc.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Borç :";
            // 
            // silButton
            // 
            this.silButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silButton.ForeColor = System.Drawing.Color.Black;
            this.silButton.Location = new System.Drawing.Point(384, 239);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(173, 42);
            this.silButton.TabIndex = 14;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // guncelleButton
            // 
            this.guncelleButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelleButton.ForeColor = System.Drawing.Color.Black;
            this.guncelleButton.Location = new System.Drawing.Point(196, 239);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(173, 42);
            this.guncelleButton.TabIndex = 13;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(654, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 50);
            this.label5.TabIndex = 14;
            this.label5.Text = "Abone Sayısı : ";
            // 
            // aboneSayisiText
            // 
            this.aboneSayisiText.AutoSize = true;
            this.aboneSayisiText.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboneSayisiText.Location = new System.Drawing.Point(775, 503);
            this.aboneSayisiText.Name = "aboneSayisiText";
            this.aboneSayisiText.Size = new System.Drawing.Size(202, 50);
            this.aboneSayisiText.TabIndex = 15;
            this.aboneSayisiText.Text = "_____";
            // 
            // aboneSayisiTimer
            // 
            this.aboneSayisiTimer.Enabled = true;
            this.aboneSayisiTimer.Tick += new System.EventHandler(this.aboneSayisiTimer_Tick);
            // 
            // textBoxTelNo
            // 
            this.textBoxTelNo.BeepOnError = true;
            this.textBoxTelNo.Location = new System.Drawing.Point(243, 48);
            this.textBoxTelNo.Mask = "000000";
            this.textBoxTelNo.Name = "textBoxTelNo";
            this.textBoxTelNo.Size = new System.Drawing.Size(309, 20);
            this.textBoxTelNo.TabIndex = 18;
            // 
            // dataGridViewFiyatListesi
            // 
            this.dataGridViewFiyatListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiyatListesi.Location = new System.Drawing.Point(983, 631);
            this.dataGridViewFiyatListesi.Name = "dataGridViewFiyatListesi";
            this.dataGridViewFiyatListesi.Size = new System.Drawing.Size(24, 21);
            this.dataGridViewFiyatListesi.TabIndex = 16;
            this.dataGridViewFiyatListesi.Visible = false;
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBoxMarka.FormattingEnabled = true;
            this.textBoxMarka.Location = new System.Drawing.Point(243, 79);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(309, 21);
            this.textBoxMarka.TabIndex = 17;
            // 
            // AboneListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 664);
            this.Controls.Add(this.dataGridViewFiyatListesi);
            this.Controls.Add(this.aboneSayisiText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AboneListesiForm";
            this.Text = "AboneListesiForm";
            this.Load += new System.EventHandler(this.AboneListesiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAboneListesi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiyatListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAboneListesi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.RichTextBox richTextBoxAdres;
        private System.Windows.Forms.Button aboneEkleButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label aboneSayisiText;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.TextBox textBoxBorc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer aboneSayisiTimer;
        private System.Windows.Forms.MaskedTextBox textBoxTelNo;
        private System.Windows.Forms.DataGridView dataGridViewFiyatListesi;
        private System.Windows.Forms.ComboBox textBoxMarka;
    }
}