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
    
    public partial class Form1 : Form
    {
        Point Tasima;
        //
        public Label[] lb;
        public PictureBox[] box;
        public Panel[] pnl;
        //
        public string[] veri;
        int l = -1;
        int b = -1;
        int p = -1;
        int i;
        int k = 0;
        Add add;
        frm_Analiz frm_Analiz;
        PictureBox boxs;
        public string control;
        public Form1()
        {
            i = 0;
            InitializeComponent();
            
            VeriTabani.KitapSayisi();
            veri = new string[VeriTabani.veri.Length];
            while (i < VeriTabani.veri.Length)
            {
                veri[i] = VeriTabani.veri[i];
                i++;
            }
            
            pnl = new Panel[veri.Length/8];
            lb = new Label[pnl.Length*6];
            box = new PictureBox[pnl.Length];
            Doldur();
            VeriTabani.GununSozu();
            GC.Collect();
            GC.Collect(2,GCCollectionMode.Optimized);
            GC.SuppressFinalize(this);
            
        }
        public void Doldur()
        {
            i = 0;
            k = -1;
            while (i < pnl.Length)
            {
                cmb_kitaplar.Visible = true;
                btn_Search.Visible = true;
                btn_Analiz.Visible = true;
                k++;
                p++;
                pnl[p] = new Panel();
                pnl[p].Name = veri[k];
                pnl[p].Size = new Size(325,200);
                pnl[p].BackColor = Color.Orange;

                l++;
                lb[l] = new Label();
                control = veri[k];
                lb[l].Text = $"Kitap:{veri[k]}";
                lb[l].Location = new Point(152,17);
                pnl[p].Controls.Add(lb[l]);
                cmb_kitaplar.Items.Add(veri[k]);
                

                l++;
                k++;
                lb[l] = new Label();
                lb[l].Text = $"Yazar:{veri[k]}";
                lb[l].Location = new Point(152, 47);
                pnl[p].Controls.Add(lb[l]);

                l++;
                k++;
                lb[l] = new Label();
                lb[l].Text = $"Basım Yılı:{veri[k]}";
                lb[l].Location = new Point(152, 77);
                pnl[p].Controls.Add(lb[l]);

                l++;
                k++;
                lb[l] = new Label();
                lb[l].Text = $"Yayın:{veri[k]}";
                lb[l].Location = new Point(152, 107);
                pnl[p].Controls.Add(lb[l]);

                l++;
                k++;
                lb[l] = new Label();
                lb[l].Text = $"Türü:{veri[k]}";
                lb[l].Location = new Point(152, 167);
                pnl[p].Controls.Add(lb[l]);

                l++;
                k++;
                lb[l] = new Label();
                lb[l].Text = $"Sayfa:{veri[k]}";
                lb[l].Location = new Point(152, 137);
                pnl[p].Controls.Add(lb[l]);
                b++;
                k++;
                try
                {
                    box[b] = new PictureBox();
                    box[b].Name = pnl[p].Name;
                    box[b].MouseDown += Form1_MouseDown;
                    box[b].Size = new Size(140, 196);
                    box[b].Location = new Point(0, 2);
                    box[b].SizeMode = PictureBoxSizeMode.StretchImage;
                    box[b].Image = Image.FromFile(veri[k]);
                    pnl[p].Controls.Add(box[b]);
                    kitapliste.Controls.Add(pnl[p]);
                }
                catch (Exception)
                {
                    lbl_Sonuc.Text = "Sistem güncellenmesinden dolayı lütfen yeniden başlatınız!";
                    btn_no.Visible = false;
                    btn_Yes.Text = "Tamam";
                    btn_Yes.Location = new Point(175, 133);
                    pnl_Uyarı.Visible = true;
                    VeriTabani.Sil(control);
                }

                i++;
                
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            boxs= sender as PictureBox;
            add = new Add();
            VeriTabani.KitapDuzenle(boxs.Name);
            add.ekle = false;
            this.Hide();
            add.Show();
            GC.Collect();
            GC.Collect(2, GCCollectionMode.Optimized);
            GC.SuppressFinalize(this);

        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            pnl_Uyarı.Visible = true;
            btn_add.Enabled = btn_Analiz.Enabled = btn_Search.Enabled =kitapliste.Enabled= false;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            add = new Add();
            this.Hide();
            add.ekle = true;
            add.Show();
            GC.Collect();
            GC.Collect(2, GCCollectionMode.Optimized);
            GC.SuppressFinalize(this);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Tasima = e.Location;
            }
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(e.X + this.Location.X - Tasima.X, e.Y + this.Location.Y - Tasima.Y);
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_kitaplar.Text.Equals(null)|| cmb_kitaplar.Text.Equals(""))
                {
                    MessageBox.Show("lütfen aramak istediğiniz bilgiyi doldurunuz ☻");

                }
                else
                {
                    
                    add = new Add();
                    VeriTabani.KitapDuzenle(cmb_kitaplar.Text);
                    add.ekle = false;
                    add.Show();
                    this.Hide();
                    GC.Collect();
                    GC.Collect(2, GCCollectionMode.Optimized);
                    GC.SuppressFinalize(this);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("lütfen aramak istediğiniz bilgiyi doldurunuz ☻");
            }
        }
        private void btn_Analiz_Click(object sender, EventArgs e)
        {
           
            VeriTabani.KitapDuzenle(control);
            frm_Analiz= new frm_Analiz();
            this.Hide();
            frm_Analiz.Show();
        }
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_no_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = btn_Analiz.Enabled = btn_Search.Enabled =kitapliste.Enabled= true;
            pnl_Uyarı.Visible = false;
        }
    }
}
