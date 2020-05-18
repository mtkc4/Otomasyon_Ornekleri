using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniKütüphanem
{
    public partial class Add : Form
    {
        Form1 form;
        Point Tasima;
        public bool ekle;
        public string[] veri;
        public Add()
        {
            InitializeComponent();
            GC.Collect();
            GC.Collect(2, GCCollectionMode.Optimized);
            GC.SuppressFinalize(this);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            form = new Form1();
            form.Show();
            this.Close();
            GC.Collect();
            GC.Collect(2, GCCollectionMode.Optimized);
            GC.SuppressFinalize(this);
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            btn_duzenle.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_basimyili.Text.Equals("") || txt_kitapadi.Text.Equals("") || cmbKitapTuru.Text.Equals("") || txt_resimYolu.Text.Equals("") || txt_sayfa.Text.Equals("") || txt_Yayinevi.Text.Equals("") || txt_Yazar.Text.Equals(""))
            {
                MessageBox.Show("lütfen boş bırakmayınız ☻");
            }
            else
            {
                VeriTabani.KitapGuncelle(txt_kitapadi.Text, txt_Yazar.Text, txt_basimyili.Text, txt_Yayinevi.Text, cmbKitapTuru.Text, txt_sayfa.Text, txt_resimYolu.Text, txt_Ozet.Text);
                pnl_Uyarı.Visible = true;

            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Tasima = e.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(e.X + this.Location.X - Tasima.X, e.Y + this.Location.Y - Tasima.Y);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                VeriTabani.Sil("");
                pnl_Uyarı.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Silme işleminde Hatanız var lütfen yeniden başlatın ☻");
            }
            
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_basimyili.Text.Equals("") || txt_kitapadi.Text.Equals("") || cmbKitapTuru.Text.Equals("") ||  txt_resimYolu.Text.Equals("")||txt_sayfa.Text.Equals("")||txt_Yayinevi.Text.Equals("")||txt_Yazar.Text.Equals(""))
            {
                MessageBox.Show("lütfen boş bırakmayınız ☻");
            }
            else
            {
                VeriTabani.KitapEkle(txt_kitapadi.Text, txt_Yazar.Text, txt_basimyili.Text, txt_Yayinevi.Text, cmbKitapTuru.Text, txt_sayfa.Text, txt_resimYolu.Text,txt_Ozet.Text);
                pnl_Uyarı.Visible = true;
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {
            if (ekle)
            {
                btn_duzenle.Visible = btn_kaydet.Visible = btn_Sil.Visible = false;
                groupBox1.Enabled = true;

            }
            else
            {
                veri = new string[VeriTabani.istenilen.Length];
                for(int i = 0; i < veri.Length; i++)
                {
                    veri[i] = VeriTabani.istenilen[i];
                }
                btn_duzenle.Visible = btn_kaydet.Visible = btn_Sil.Visible = true;
                btn_ekle.Visible = false;
                txt_kitapadi.Text = veri[0];
                txt_Yazar.Text = veri[1];
                txt_basimyili.Text = veri[2];
                txt_Yayinevi.Text = veri[3];
                cmbKitapTuru.Text = veri[4];
                txt_sayfa.Text = veri[5];
                txt_resimYolu.Text = veri[6];
                txt_Ozet.Text = veri[7];
                pictureBox1.Image = Image.FromFile(txt_resimYolu.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.ShowDialog();
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                txt_resimYolu.Text = openFile.FileName;
            }
            catch (Exception)
            {
                MessageBox.Show("Resim uzantı hatası ☻");
            }
            
        }

        private void btn_Evet_Click(object sender, EventArgs e)
        {
            Application.Exit();
            btn_ResimEkle.Enabled = btn_Kapat.Enabled = btn_ekle.Enabled = false;
        }

        private void btn_Hayır_Click(object sender, EventArgs e)
        {
            form = new Form1();
            form.Show();
            this.Close();
            GC.Collect();
            GC.Collect(2, GCCollectionMode.Optimized);
            GC.SuppressFinalize(this);
        }
    }
}
