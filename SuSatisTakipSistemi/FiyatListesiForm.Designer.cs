
namespace SuSatisTakipSistemi
{
    partial class FiyatListesiForm
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
            this.dataGridViewFiyatListesi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ekleButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.markaTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.fiyatTextBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMarkaAdi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiyatListesi)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewFiyatListesi);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 419);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewFiyatListesi
            // 
            this.dataGridViewFiyatListesi.AllowUserToAddRows = false;
            this.dataGridViewFiyatListesi.AllowUserToDeleteRows = false;
            this.dataGridViewFiyatListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFiyatListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiyatListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFiyatListesi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFiyatListesi.Name = "dataGridViewFiyatListesi";
            this.dataGridViewFiyatListesi.ReadOnly = true;
            this.dataGridViewFiyatListesi.Size = new System.Drawing.Size(971, 419);
            this.dataGridViewFiyatListesi.TabIndex = 0;
            this.dataGridViewFiyatListesi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFiyatListesi_CellEnter);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ekleButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.fiyatTextBox);
            this.panel2.Controls.Add(this.markaTextBox);
            this.panel2.Location = new System.Drawing.Point(13, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 146);
            this.panel2.TabIndex = 15;
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
            // ekleButton
            // 
            this.ekleButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleButton.ForeColor = System.Drawing.Color.Black;
            this.ekleButton.Location = new System.Drawing.Point(135, 82);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(234, 51);
            this.ekleButton.TabIndex = 12;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fiyat :";
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.Location = new System.Drawing.Point(135, 46);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(234, 20);
            this.fiyatTextBox.TabIndex = 7;
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
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.guncelleButton);
            this.panel3.Controls.Add(this.fiyatTextBox2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.labelMarkaAdi);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(431, 438);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 146);
            this.panel3.TabIndex = 17;
            // 
            // guncelleButton
            // 
            this.guncelleButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelleButton.ForeColor = System.Drawing.Color.Black;
            this.guncelleButton.Location = new System.Drawing.Point(334, 15);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(207, 51);
            this.guncelleButton.TabIndex = 13;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // fiyatTextBox2
            // 
            this.fiyatTextBox2.Location = new System.Drawing.Point(123, 46);
            this.fiyatTextBox2.Name = "fiyatTextBox2";
            this.fiyatTextBox2.Size = new System.Drawing.Size(178, 20);
            this.fiyatTextBox2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fiyat : ";
            // 
            // labelMarkaAdi
            // 
            this.labelMarkaAdi.AutoSize = true;
            this.labelMarkaAdi.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarkaAdi.Location = new System.Drawing.Point(119, 10);
            this.labelMarkaAdi.Name = "labelMarkaAdi";
            this.labelMarkaAdi.Size = new System.Drawing.Size(182, 24);
            this.labelMarkaAdi.TabIndex = 18;
            this.labelMarkaAdi.Text = "MARKANIN ADI";
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(334, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 51);
            this.button2.TabIndex = 20;
            this.button2.Text = "Kaydı Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FiyatListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 594);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FiyatListesiForm";
            this.Text = "FiyatListesiForm";
            this.Load += new System.EventHandler(this.FiyatListesiForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiyatListesi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewFiyatListesi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fiyatTextBox;
        private System.Windows.Forms.TextBox markaTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.TextBox fiyatTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMarkaAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}