
namespace SuSatisTakipSistemi
{
    partial class StokDurumuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewStokDurumu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.stokEkleButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.adetTextBox = new System.Windows.Forms.TextBox();
            this.markaTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stokFiyatlandırmayıSilButton = new System.Windows.Forms.Button();
            this.stokGuncelleButton = new System.Windows.Forms.Button();
            this.adetTextBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.markaAdiLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStokDurumu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewStokDurumu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 456);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewStokDurumu
            // 
            this.dataGridViewStokDurumu.AllowUserToAddRows = false;
            this.dataGridViewStokDurumu.AllowUserToDeleteRows = false;
            this.dataGridViewStokDurumu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStokDurumu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStokDurumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStokDurumu.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStokDurumu.Name = "dataGridViewStokDurumu";
            this.dataGridViewStokDurumu.ReadOnly = true;
            this.dataGridViewStokDurumu.Size = new System.Drawing.Size(966, 456);
            this.dataGridViewStokDurumu.TabIndex = 0;
            this.dataGridViewStokDurumu.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStokDurumu_CellEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Marka :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.stokEkleButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.adetTextBox);
            this.panel2.Controls.Add(this.markaTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 474);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 146);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka :";
            // 
            // stokEkleButton
            // 
            this.stokEkleButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokEkleButton.ForeColor = System.Drawing.Color.Black;
            this.stokEkleButton.Location = new System.Drawing.Point(135, 82);
            this.stokEkleButton.Name = "stokEkleButton";
            this.stokEkleButton.Size = new System.Drawing.Size(234, 51);
            this.stokEkleButton.TabIndex = 12;
            this.stokEkleButton.Text = "Ekle";
            this.stokEkleButton.UseVisualStyleBackColor = true;
            this.stokEkleButton.Click += new System.EventHandler(this.stokEkleButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adet :";
            // 
            // adetTextBox
            // 
            this.adetTextBox.Location = new System.Drawing.Point(135, 46);
            this.adetTextBox.Name = "adetTextBox";
            this.adetTextBox.Size = new System.Drawing.Size(234, 20);
            this.adetTextBox.TabIndex = 7;
            // 
            // markaTextBox
            // 
            this.markaTextBox.Location = new System.Drawing.Point(135, 10);
            this.markaTextBox.Name = "markaTextBox";
            this.markaTextBox.Size = new System.Drawing.Size(234, 20);
            this.markaTextBox.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.stokFiyatlandırmayıSilButton);
            this.panel3.Controls.Add(this.stokGuncelleButton);
            this.panel3.Controls.Add(this.adetTextBox2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.markaAdiLabel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(425, 474);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 146);
            this.panel3.TabIndex = 16;
            // 
            // stokFiyatlandırmayıSilButton
            // 
            this.stokFiyatlandırmayıSilButton.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokFiyatlandırmayıSilButton.ForeColor = System.Drawing.Color.Black;
            this.stokFiyatlandırmayıSilButton.Location = new System.Drawing.Point(334, 82);
            this.stokFiyatlandırmayıSilButton.Name = "stokFiyatlandırmayıSilButton";
            this.stokFiyatlandırmayıSilButton.Size = new System.Drawing.Size(207, 51);
            this.stokFiyatlandırmayıSilButton.TabIndex = 19;
            this.stokFiyatlandırmayıSilButton.Text = "Stok Bilgisini Sil";
            this.stokFiyatlandırmayıSilButton.UseVisualStyleBackColor = true;
            this.stokFiyatlandırmayıSilButton.Click += new System.EventHandler(this.stokFiyatlandırmayıSilButton_Click);
            // 
            // stokGuncelleButton
            // 
            this.stokGuncelleButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokGuncelleButton.ForeColor = System.Drawing.Color.Black;
            this.stokGuncelleButton.Location = new System.Drawing.Point(334, 15);
            this.stokGuncelleButton.Name = "stokGuncelleButton";
            this.stokGuncelleButton.Size = new System.Drawing.Size(207, 51);
            this.stokGuncelleButton.TabIndex = 13;
            this.stokGuncelleButton.Text = "Güncelle";
            this.stokGuncelleButton.UseVisualStyleBackColor = true;
            this.stokGuncelleButton.Click += new System.EventHandler(this.stokGuncelleButton_Click);
            // 
            // adetTextBox2
            // 
            this.adetTextBox2.Location = new System.Drawing.Point(123, 46);
            this.adetTextBox2.Name = "adetTextBox2";
            this.adetTextBox2.Size = new System.Drawing.Size(178, 20);
            this.adetTextBox2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Adet :";
            // 
            // markaAdiLabel
            // 
            this.markaAdiLabel.AutoSize = true;
            this.markaAdiLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markaAdiLabel.Location = new System.Drawing.Point(119, 10);
            this.markaAdiLabel.Name = "markaAdiLabel";
            this.markaAdiLabel.Size = new System.Drawing.Size(182, 24);
            this.markaAdiLabel.TabIndex = 18;
            this.markaAdiLabel.Text = "MARKANIN ADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Marka :";
            // 
            // StokDurumuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 630);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StokDurumuForm";
            this.Text = "StokDurumuForm";
            this.Load += new System.EventHandler(this.StokDurumuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStokDurumu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewStokDurumu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stokEkleButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adetTextBox;
        private System.Windows.Forms.TextBox markaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox adetTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label markaAdiLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stokGuncelleButton;
        private System.Windows.Forms.Button stokFiyatlandırmayıSilButton;
    }
}