namespace MiniKütüphanem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Analiz = new System.Windows.Forms.Button();
            this.cmb_kitaplar = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.kitapliste = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Uyarı = new System.Windows.Forms.Panel();
            this.lbl_Sonuc = new System.Windows.Forms.Label();
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnl_Uyarı.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.btn_Analiz);
            this.panel2.Controls.Add(this.cmb_kitaplar);
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Controls.Add(this.lbl_Name);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1277, 70);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // btn_Analiz
            // 
            this.btn_Analiz.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Analiz.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Analiz.Location = new System.Drawing.Point(159, 6);
            this.btn_Analiz.Name = "btn_Analiz";
            this.btn_Analiz.Size = new System.Drawing.Size(126, 58);
            this.btn_Analiz.TabIndex = 4;
            this.btn_Analiz.Text = "Analiz";
            this.btn_Analiz.UseVisualStyleBackColor = false;
            this.btn_Analiz.Visible = false;
            this.btn_Analiz.Click += new System.EventHandler(this.btn_Analiz_Click);
            // 
            // cmb_kitaplar
            // 
            this.cmb_kitaplar.FormattingEnabled = true;
            this.cmb_kitaplar.Items.AddRange(new object[] {
            ""});
            this.cmb_kitaplar.Location = new System.Drawing.Point(841, 27);
            this.cmb_kitaplar.Name = "cmb_kitaplar";
            this.cmb_kitaplar.Size = new System.Drawing.Size(159, 24);
            this.cmb_kitaplar.TabIndex = 2;
            this.cmb_kitaplar.Visible = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Search.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Search.Location = new System.Drawing.Point(1006, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(126, 58);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Ara";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Visible = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Name.Location = new System.Drawing.Point(418, 10);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(333, 54);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "MİNİ KÜTÜPHANEM";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_add.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.Location = new System.Drawing.Point(15, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(126, 58);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Ekle";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Close.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Close.Location = new System.Drawing.Point(1138, 6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(126, 58);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Kapat";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // kitapliste
            // 
            this.kitapliste.AutoScroll = true;
            this.kitapliste.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kitapliste.Location = new System.Drawing.Point(12, 88);
            this.kitapliste.Name = "kitapliste";
            this.kitapliste.Size = new System.Drawing.Size(1277, 584);
            this.kitapliste.TabIndex = 2;
            // 
            // pnl_Uyarı
            // 
            this.pnl_Uyarı.Controls.Add(this.lbl_Sonuc);
            this.pnl_Uyarı.Controls.Add(this.btn_no);
            this.pnl_Uyarı.Controls.Add(this.btn_Yes);
            this.pnl_Uyarı.Location = new System.Drawing.Point(388, 231);
            this.pnl_Uyarı.Name = "pnl_Uyarı";
            this.pnl_Uyarı.Size = new System.Drawing.Size(524, 223);
            this.pnl_Uyarı.TabIndex = 23;
            this.pnl_Uyarı.Visible = false;
            // 
            // lbl_Sonuc
            // 
            this.lbl_Sonuc.AutoSize = true;
            this.lbl_Sonuc.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sonuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Sonuc.Location = new System.Drawing.Point(78, 49);
            this.lbl_Sonuc.Name = "lbl_Sonuc";
            this.lbl_Sonuc.Size = new System.Drawing.Size(380, 35);
            this.lbl_Sonuc.TabIndex = 11;
            this.lbl_Sonuc.Text = "Kapatmak istediğinize emin misiniz?";
            // 
            // btn_no
            // 
            this.btn_no.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_no.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_no.Location = new System.Drawing.Point(348, 133);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(126, 58);
            this.btn_no.TabIndex = 10;
            this.btn_no.Text = "Hayır";
            this.btn_no.UseVisualStyleBackColor = false;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_Yes
            // 
            this.btn_Yes.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Yes.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yes.Location = new System.Drawing.Point(51, 133);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(126, 58);
            this.btn_Yes.TabIndex = 9;
            this.btn_Yes.Text = "Evet";
            this.btn_Yes.UseVisualStyleBackColor = false;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1301, 684);
            this.Controls.Add(this.pnl_Uyarı);
            this.Controls.Add(this.kitapliste);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_Uyarı.ResumeLayout(false);
            this.pnl_Uyarı.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel kitapliste;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_kitaplar;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Analiz;
        private System.Windows.Forms.Panel pnl_Uyarı;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Label lbl_Sonuc;
    }
}

