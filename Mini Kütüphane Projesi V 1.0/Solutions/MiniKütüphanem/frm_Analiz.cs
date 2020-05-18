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
    public partial class frm_Analiz : Form
    {

        public string[] aylar = {"ocak","şubat","mart","nisan","mayıs","haziran","temmuz","ağustos","eylül","ekim","kasım","aralık" };
        public string[] turler = {"roman","hikaye","kişisel gelişim","polisiye","dünya klasikleri","şiir","türk edebiyatı","makale","anı","deneme","biyografi","mektup" };
        public int sayac;
        Point Tasima;
        PictureBox boxs;
        Add add;
        public int sayac2;
        Form1 form;
        public frm_Analiz()
        {
            InitializeComponent();
            GC.Collect();
            GC.Collect(2, GCCollectionMode.Optimized);
            GC.SuppressFinalize(this);
            lbl_soz.Text = VeriTabani.gununsozu;
            lbl_yazar.Text = VeriTabani.yazar;
            sayac = 0;
            sayac2 = 0;
            int i = 0;
            while (i < 12)
            {
                int j = 0;
                while (j < (VeriTabani.Yil.Length))
                {
                    if (int.Parse(VeriTabani.Yil[j]) == i)
                    {
                        sayac++;
                    }
                    if (turler[i] == VeriTabani.tur[j])
                    {
                        sayac2++;
                    }


                    j++;
                }
                if (sayac > 0)
                {
                    Yil.Series["Yıllık Okuma"].Points.AddXY(aylar[i], sayac);

                }
                if (sayac2 > 0)
                {
                    Kitapturu.Series["Kitapturu"].Points.AddXY(turler[i], sayac2);

                }
                sayac2 = 0;
                sayac = 0;
                i++;
            }
            lbl_kitapadi.Text += VeriTabani.istenilen[0];
            pictureBox1.Image = Image.FromFile(VeriTabani.istenilen[6]);
        }
        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            form = new Form1();
            this.Close();
            form.Show();
            GC.Collect();
            GC.Collect(2, GCCollectionMode.Optimized);
            GC.SuppressFinalize(this);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            boxs = sender as PictureBox;
            add = new Add();
            VeriTabani.KitapDuzenle(VeriTabani.istenilen[0]);
            add.ekle = false;
            this.Hide();
            add.Show();
            GC.Collect();
            GC.Collect(2, GCCollectionMode.Optimized);
            GC.SuppressFinalize(this);
        }
        private void frm_Analiz_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Tasima = e.Location;
            }
        }
        private void frm_Analiz_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(e.X + this.Location.X - Tasima.X, e.Y + this.Location.Y - Tasima.Y);
            }
        }
    }
}
