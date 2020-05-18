namespace MiniKütüphanem
{
    partial class Add
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
            this.btn_ResimEkle = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl_Uyarı = new System.Windows.Forms.Panel();
            this.btn_Hayır = new System.Windows.Forms.Button();
            this.btn_Evet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Yayinevi = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_resimYolu = new System.Windows.Forms.TextBox();
            this.lbl_reseimyolu = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Ozet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sayfa = new System.Windows.Forms.TextBox();
            this.txt_basimyili = new System.Windows.Forms.TextBox();
            this.txt_Yazar = new System.Windows.Forms.TextBox();
            this.txt_kitapadi = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Kapat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbKitapTuru = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl_Uyarı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.btn_ResimEkle);
            this.panel1.Controls.Add(this.btn_duzenle);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_Kapat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 527);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btn_ResimEkle
            // 
            this.btn_ResimEkle.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_ResimEkle.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ResimEkle.Location = new System.Drawing.Point(12, 364);
            this.btn_ResimEkle.Name = "btn_ResimEkle";
            this.btn_ResimEkle.Size = new System.Drawing.Size(157, 58);
            this.btn_ResimEkle.TabIndex = 9;
            this.btn_ResimEkle.Text = "Resim ekle";
            this.btn_ResimEkle.UseVisualStyleBackColor = false;
            this.btn_ResimEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_duzenle.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_duzenle.Location = new System.Drawing.Point(31, 300);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(126, 58);
            this.btn_duzenle.TabIndex = 8;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = false;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbKitapTuru);
            this.groupBox1.Controls.Add(this.pnl_Uyarı);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Yayinevi);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.txt_resimYolu);
            this.groupBox1.Controls.Add(this.lbl_reseimyolu);
            this.groupBox1.Controls.Add(this.btn_Sil);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Ozet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_sayfa);
            this.groupBox1.Controls.Add(this.txt_basimyili);
            this.groupBox1.Controls.Add(this.txt_Yazar);
            this.groupBox1.Controls.Add(this.txt_kitapadi);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(203, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 512);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // pnl_Uyarı
            // 
            this.pnl_Uyarı.Controls.Add(this.btn_Hayır);
            this.pnl_Uyarı.Controls.Add(this.btn_Evet);
            this.pnl_Uyarı.Controls.Add(this.label8);
            this.pnl_Uyarı.Location = new System.Drawing.Point(340, 177);
            this.pnl_Uyarı.Name = "pnl_Uyarı";
            this.pnl_Uyarı.Size = new System.Drawing.Size(524, 223);
            this.pnl_Uyarı.TabIndex = 22;
            this.pnl_Uyarı.Visible = false;
            // 
            // btn_Hayır
            // 
            this.btn_Hayır.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Hayır.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Hayır.Location = new System.Drawing.Point(324, 120);
            this.btn_Hayır.Name = "btn_Hayır";
            this.btn_Hayır.Size = new System.Drawing.Size(126, 58);
            this.btn_Hayır.TabIndex = 10;
            this.btn_Hayır.Text = "Hayır";
            this.btn_Hayır.UseVisualStyleBackColor = false;
            this.btn_Hayır.Click += new System.EventHandler(this.btn_Hayır_Click);
            // 
            // btn_Evet
            // 
            this.btn_Evet.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Evet.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Evet.Location = new System.Drawing.Point(53, 123);
            this.btn_Evet.Name = "btn_Evet";
            this.btn_Evet.Size = new System.Drawing.Size(126, 58);
            this.btn_Evet.TabIndex = 9;
            this.btn_Evet.Text = "Evet";
            this.btn_Evet.UseVisualStyleBackColor = false;
            this.btn_Evet.Click += new System.EventHandler(this.btn_Evet_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(25, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(473, 190);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kitaplık bölümü güncellenmesi için programı kapatmak ister misiniz?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "Yayınevi:";
            // 
            // txt_Yayinevi
            // 
            this.txt_Yayinevi.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Yayinevi.Location = new System.Drawing.Point(140, 263);
            this.txt_Yayinevi.MaxLength = 20;
            this.txt_Yayinevi.Name = "txt_Yayinevi";
            this.txt_Yayinevi.Size = new System.Drawing.Size(161, 37);
            this.txt_Yayinevi.TabIndex = 20;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_ekle.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(144, 384);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(126, 58);
            this.btn_ekle.TabIndex = 9;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_resimYolu
            // 
            this.txt_resimYolu.Enabled = false;
            this.txt_resimYolu.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_resimYolu.Location = new System.Drawing.Point(140, 220);
            this.txt_resimYolu.MaxLength = 200;
            this.txt_resimYolu.Name = "txt_resimYolu";
            this.txt_resimYolu.Size = new System.Drawing.Size(161, 37);
            this.txt_resimYolu.TabIndex = 19;
            // 
            // lbl_reseimyolu
            // 
            this.lbl_reseimyolu.AutoSize = true;
            this.lbl_reseimyolu.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_reseimyolu.Location = new System.Drawing.Point(7, 227);
            this.lbl_reseimyolu.Name = "lbl_reseimyolu";
            this.lbl_reseimyolu.Size = new System.Drawing.Size(111, 30);
            this.lbl_reseimyolu.TabIndex = 18;
            this.lbl_reseimyolu.Text = "Resim Yolu:";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Sil.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(144, 448);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(126, 58);
            this.btn_Sil.TabIndex = 9;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Visible = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(546, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Özet";
            // 
            // txt_Ozet
            // 
            this.txt_Ozet.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ozet.Location = new System.Drawing.Point(319, 48);
            this.txt_Ozet.MaxLength = 10000;
            this.txt_Ozet.Multiline = true;
            this.txt_Ozet.Name = "txt_Ozet";
            this.txt_Ozet.Size = new System.Drawing.Size(593, 458);
            this.txt_Ozet.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kitap Türü:";
            // 
            // txt_sayfa
            // 
            this.txt_sayfa.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sayfa.Location = new System.Drawing.Point(142, 312);
            this.txt_sayfa.MaxLength = 3;
            this.txt_sayfa.Name = "txt_sayfa";
            this.txt_sayfa.Size = new System.Drawing.Size(85, 37);
            this.txt_sayfa.TabIndex = 13;
            // 
            // txt_basimyili
            // 
            this.txt_basimyili.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_basimyili.Location = new System.Drawing.Point(140, 177);
            this.txt_basimyili.MaxLength = 4;
            this.txt_basimyili.Name = "txt_basimyili";
            this.txt_basimyili.Size = new System.Drawing.Size(161, 37);
            this.txt_basimyili.TabIndex = 12;
            // 
            // txt_Yazar
            // 
            this.txt_Yazar.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Yazar.Location = new System.Drawing.Point(140, 91);
            this.txt_Yazar.MaxLength = 20;
            this.txt_Yazar.Name = "txt_Yazar";
            this.txt_Yazar.Size = new System.Drawing.Size(161, 37);
            this.txt_Yazar.TabIndex = 11;
            // 
            // txt_kitapadi
            // 
            this.txt_kitapadi.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapadi.Location = new System.Drawing.Point(140, 48);
            this.txt_kitapadi.MaxLength = 20;
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Size = new System.Drawing.Size(161, 37);
            this.txt_kitapadi.TabIndex = 10;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_kaydet.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(12, 448);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(126, 58);
            this.btn_kaydet.TabIndex = 9;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Basım Yılı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sayfa:";
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Kapat.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kapat.Location = new System.Drawing.Point(31, 457);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(126, 58);
            this.btn_Kapat.TabIndex = 6;
            this.btn_Kapat.Text = "Kapat";
            this.btn_Kapat.UseVisualStyleBackColor = false;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbKitapTuru
            // 
            this.cmbKitapTuru.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKitapTuru.FormattingEnabled = true;
            this.cmbKitapTuru.Items.AddRange(new object[] {
            "roman",
            "hikaye",
            "kişisel gelişim",
            "polisiye",
            "dünya klasikleri",
            "şiir",
            "türk edebiyatı",
            "makale",
            "anı",
            "deneme",
            "biyografi",
            "mektup"});
            this.cmbKitapTuru.Location = new System.Drawing.Point(140, 134);
            this.cmbKitapTuru.Name = "cmbKitapTuru";
            this.cmbKitapTuru.Size = new System.Drawing.Size(161, 38);
            this.cmbKitapTuru.TabIndex = 23;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 527);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Add_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_Uyarı.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Kapat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sayfa;
        private System.Windows.Forms.TextBox txt_basimyili;
        private System.Windows.Forms.TextBox txt_Yazar;
        private System.Windows.Forms.TextBox txt_kitapadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Ozet;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.TextBox txt_resimYolu;
        private System.Windows.Forms.Label lbl_reseimyolu;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_ResimEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Yayinevi;
        private System.Windows.Forms.Panel pnl_Uyarı;
        private System.Windows.Forms.Button btn_Hayır;
        private System.Windows.Forms.Button btn_Evet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbKitapTuru;
    }
}