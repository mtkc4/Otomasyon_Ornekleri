namespace MiniKütüphanem
{
    partial class frm_Analiz
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_yazar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_soz = new System.Windows.Forms.Label();
            this.Yil = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Kitapturu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_kitapadi = new System.Windows.Forms.Label();
            this.lbl_Baslik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Kapat = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kitapturu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Yil, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Kitapturu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1124, 604);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.lbl_yazar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_soz);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(565, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 304);
            this.panel2.TabIndex = 3;
            // 
            // lbl_yazar
            // 
            this.lbl_yazar.AutoSize = true;
            this.lbl_yazar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazar.Location = new System.Drawing.Point(283, 251);
            this.lbl_yazar.Name = "lbl_yazar";
            this.lbl_yazar.Size = new System.Drawing.Size(121, 35);
            this.lbl_yazar.TabIndex = 4;
            this.lbl_yazar.Text = "Günü Sözü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(189, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Günü Sözü";
            // 
            // lbl_soz
            // 
            this.lbl_soz.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soz.Location = new System.Drawing.Point(39, 72);
            this.lbl_soz.Name = "lbl_soz";
            this.lbl_soz.Size = new System.Drawing.Size(462, 179);
            this.lbl_soz.TabIndex = 2;
            this.lbl_soz.Text = "Sevgi... Allah tarafından insana verilen büyük bir nimettir. Kiminin elinde heba," +
    " kiminin elinde vefa olur.";
            // 
            // Yil
            // 
            this.Yil.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Name = "YillikKitap";
            this.Yil.ChartAreas.Add(chartArea3);
            legendItem2.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Marker;
            legend3.CustomItems.Add(legendItem2);
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            legend3.Title = "2020";
            this.Yil.Legends.Add(legend3);
            this.Yil.Location = new System.Drawing.Point(3, 3);
            this.Yil.Name = "Yil";
            this.Yil.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "YillikKitap";
            series3.Legend = "Legend1";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star6;
            series3.Name = "Yıllık Okuma";
            this.Yil.Series.Add(series3);
            this.Yil.Size = new System.Drawing.Size(556, 288);
            this.Yil.TabIndex = 0;
            this.Yil.Text = "KitapTuru";
            // 
            // Kitapturu
            // 
            chartArea4.Name = "ChartArea1";
            this.Kitapturu.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Kitapturu.Legends.Add(legend4);
            this.Kitapturu.Location = new System.Drawing.Point(3, 297);
            this.Kitapturu.Name = "Kitapturu";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Kitapturu";
            series4.YValuesPerPoint = 2;
            this.Kitapturu.Series.Add(series4);
            this.Kitapturu.Size = new System.Drawing.Size(556, 304);
            this.Kitapturu.TabIndex = 1;
            this.Kitapturu.Text = "Yıllık Kitap Okuma";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_kitapadi);
            this.panel1.Controls.Add(this.lbl_Baslik);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(565, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 288);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(299, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 102);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kitabın bilgilerini görmek için lütfen resmi tıklayınız ☻";
            // 
            // lbl_kitapadi
            // 
            this.lbl_kitapadi.AutoSize = true;
            this.lbl_kitapadi.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitapadi.Location = new System.Drawing.Point(260, 55);
            this.lbl_kitapadi.Name = "lbl_kitapadi";
            this.lbl_kitapadi.Size = new System.Drawing.Size(65, 30);
            this.lbl_kitapadi.TabIndex = 2;
            this.lbl_kitapadi.Text = "Kitap:";
            // 
            // lbl_Baslik
            // 
            this.lbl_Baslik.AutoSize = true;
            this.lbl_Baslik.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Baslik.Location = new System.Drawing.Point(299, 15);
            this.lbl_Baslik.Name = "lbl_Baslik";
            this.lbl_Baslik.Size = new System.Drawing.Size(202, 30);
            this.lbl_Baslik.TabIndex = 1;
            this.lbl_Baslik.Text = "En Son Okunan Kitap";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Kapat.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kapat.Location = new System.Drawing.Point(1142, 15);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(126, 58);
            this.btn_Kapat.TabIndex = 9;
            this.btn_Kapat.Text = "Kapat";
            this.btn_Kapat.UseVisualStyleBackColor = false;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // frm_Analiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1289, 628);
            this.Controls.Add(this.btn_Kapat);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Analiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Analiz";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Analiz_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_Analiz_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kitapturu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Yil;
        private System.Windows.Forms.DataVisualization.Charting.Chart Kitapturu;
        private System.Windows.Forms.Button btn_Kapat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_soz;
        private System.Windows.Forms.Label lbl_kitapadi;
        private System.Windows.Forms.Label lbl_Baslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_yazar;
    }
}