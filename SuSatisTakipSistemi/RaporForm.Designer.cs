
namespace SuSatisTakipSistemi
{
    partial class RaporForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHayatSatisAdet = new System.Windows.Forms.Label();
            this.lblNestleSatisAdet = new System.Windows.Forms.Label();
            this.lblSirmaSatisAdet = new System.Windows.Forms.Label();
            this.lblDamlaSatisAdet = new System.Windows.Forms.Label();
            this.lblErikliSatisAdet = new System.Windows.Forms.Label();
            this.dataGridViewSiparisler = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCiro = new System.Windows.Forms.Label();
            this.dataGridViewFiyatListesi = new System.Windows.Forms.DataGridView();
            this.grafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiyatListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridViewSiparisler);
            this.panel1.Controls.Add(this.dataGridViewFiyatListesi);
            this.panel1.Controls.Add(this.lblCiro);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(14, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 53);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Erikli :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Damla :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sırma : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nestle :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 29);
            this.label8.TabIndex = 27;
            this.label8.Text = "Hayat : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grafik);
            this.groupBox1.Controls.Add(this.lblHayatSatisAdet);
            this.groupBox1.Controls.Add(this.lblNestleSatisAdet);
            this.groupBox1.Controls.Add(this.lblSirmaSatisAdet);
            this.groupBox1.Controls.Add(this.lblDamlaSatisAdet);
            this.groupBox1.Controls.Add(this.lblErikliSatisAdet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 273);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Markaya Göre Satış Adet";
            // 
            // lblHayatSatisAdet
            // 
            this.lblHayatSatisAdet.AutoSize = true;
            this.lblHayatSatisAdet.Location = new System.Drawing.Point(132, 229);
            this.lblHayatSatisAdet.Name = "lblHayatSatisAdet";
            this.lblHayatSatisAdet.Size = new System.Drawing.Size(73, 21);
            this.lblHayatSatisAdet.TabIndex = 32;
            this.lblHayatSatisAdet.Text = "label12";
            // 
            // lblNestleSatisAdet
            // 
            this.lblNestleSatisAdet.AutoSize = true;
            this.lblNestleSatisAdet.Location = new System.Drawing.Point(132, 186);
            this.lblNestleSatisAdet.Name = "lblNestleSatisAdet";
            this.lblNestleSatisAdet.Size = new System.Drawing.Size(73, 21);
            this.lblNestleSatisAdet.TabIndex = 31;
            this.lblNestleSatisAdet.Text = "label11";
            // 
            // lblSirmaSatisAdet
            // 
            this.lblSirmaSatisAdet.AutoSize = true;
            this.lblSirmaSatisAdet.Location = new System.Drawing.Point(132, 142);
            this.lblSirmaSatisAdet.Name = "lblSirmaSatisAdet";
            this.lblSirmaSatisAdet.Size = new System.Drawing.Size(73, 21);
            this.lblSirmaSatisAdet.TabIndex = 30;
            this.lblSirmaSatisAdet.Text = "label10";
            // 
            // lblDamlaSatisAdet
            // 
            this.lblDamlaSatisAdet.AutoSize = true;
            this.lblDamlaSatisAdet.Location = new System.Drawing.Point(132, 101);
            this.lblDamlaSatisAdet.Name = "lblDamlaSatisAdet";
            this.lblDamlaSatisAdet.Size = new System.Drawing.Size(63, 21);
            this.lblDamlaSatisAdet.TabIndex = 29;
            this.lblDamlaSatisAdet.Text = "label9";
            // 
            // lblErikliSatisAdet
            // 
            this.lblErikliSatisAdet.AutoSize = true;
            this.lblErikliSatisAdet.Location = new System.Drawing.Point(132, 56);
            this.lblErikliSatisAdet.Name = "lblErikliSatisAdet";
            this.lblErikliSatisAdet.Size = new System.Drawing.Size(63, 21);
            this.lblErikliSatisAdet.TabIndex = 28;
            this.lblErikliSatisAdet.Text = "label9";
            // 
            // dataGridViewSiparisler
            // 
            this.dataGridViewSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparisler.Location = new System.Drawing.Point(833, 16);
            this.dataGridViewSiparisler.Name = "dataGridViewSiparisler";
            this.dataGridViewSiparisler.Size = new System.Drawing.Size(16, 19);
            this.dataGridViewSiparisler.TabIndex = 33;
            this.dataGridViewSiparisler.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ciro : ";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiro.ForeColor = System.Drawing.Color.Red;
            this.lblCiro.Location = new System.Drawing.Point(107, 11);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(34, 29);
            this.lblCiro.TabIndex = 24;
            this.lblCiro.Text = "X";
            // 
            // dataGridViewFiyatListesi
            // 
            this.dataGridViewFiyatListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiyatListesi.Location = new System.Drawing.Point(811, 16);
            this.dataGridViewFiyatListesi.Name = "dataGridViewFiyatListesi";
            this.dataGridViewFiyatListesi.Size = new System.Drawing.Size(16, 19);
            this.dataGridViewFiyatListesi.TabIndex = 25;
            this.dataGridViewFiyatListesi.Visible = false;
            // 
            // grafik
            // 
            chartArea1.Name = "ChartArea1";
            this.grafik.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafik.Legends.Add(legend1);
            this.grafik.Location = new System.Drawing.Point(388, 27);
            this.grafik.Name = "grafik";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafik.Series.Add(series1);
            this.grafik.Size = new System.Drawing.Size(480, 235);
            this.grafik.TabIndex = 33;
            this.grafik.Text = "chart1";
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "RaporForm";
            this.Text = "RaporForm";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiyatListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHayatSatisAdet;
        private System.Windows.Forms.Label lblNestleSatisAdet;
        private System.Windows.Forms.Label lblSirmaSatisAdet;
        private System.Windows.Forms.Label lblDamlaSatisAdet;
        private System.Windows.Forms.Label lblErikliSatisAdet;
        private System.Windows.Forms.DataGridView dataGridViewSiparisler;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewFiyatListesi;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafik;
    }
}