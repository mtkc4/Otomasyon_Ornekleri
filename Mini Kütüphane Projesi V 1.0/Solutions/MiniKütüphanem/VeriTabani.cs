using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MiniKütüphanem
{
    public static class VeriTabani
    {
        public static SqlConnection con;
        public static  string[] veri;
        public static string[] istenilen = new string[8];
        static int sayac;
        public static string deger;
        public static string[] tur;
        public static string[] Yil;
        static int t;
        static int y;
        public static string gununsozu;
        public static string yazar;
        public static int kontol;

        
        static VeriTabani()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=MiniKutuphanem;Integrated Security=True");
            kontol = 0;
        }
        public static void KitapSayisi()
        {
            sayac = 0;
            con.Open();
            SqlCommand com = new SqlCommand("Select *from Kitaplik", con);
            SqlDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                deger = rd["KitapID"].ToString();
                sayac += 8;
            }
            
            veri = new string[sayac];
            sayac /=8;
            Yil = new string[sayac];
            tur = new string[sayac];
            con.Close();
            KitaplariDoldur();
         
        }
        public static void KitaplariDoldur()
        {
            sayac = -1;
            t = y=0;
            con.Open();
            SqlCommand com = new SqlCommand("Select* from Kitaplik", con);
            SqlDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                sayac++;
                veri[sayac] = rd["KitapAdi"].ToString().Trim();
                sayac++;
                veri[sayac] = rd["YazarAdi"].ToString().Trim();
                sayac++;
                veri[sayac] = rd["BasimYili"].ToString().Trim();
                sayac++;
                veri[sayac] = rd["Yayinevi"].ToString().Trim();
                tur[t] = rd["KitapTuru"].ToString().Trim();
                Yil[y] = rd["EklenmeAy"].ToString().Trim();
                sayac++;
                veri[sayac] = rd["KitapTuru"].ToString().Trim();
                sayac++;
                veri[sayac] = rd["Sayfa"].ToString().Trim();
                sayac++;
                veri[sayac] = rd["ResimYolu"].ToString().Trim();
                t++;
                y++;
            }
            con.Close();
        }
        public static void KitapDuzenle(string name)
        {
            sayac = -1;
            con.Open();
            SqlCommand com = new SqlCommand("Select *from Kitaplik where KitapAdi=@p1",con);
            com.Parameters.AddWithValue("@p1", name);
            SqlDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                sayac++;
                istenilen[sayac] = rd["KitapAdi"].ToString().Trim();
                sayac++;
                istenilen[sayac] = rd["YazarAdi"].ToString().Trim();
                sayac++;
                istenilen[sayac] = rd["BasimYili"].ToString().Trim();
                sayac++;
                istenilen[sayac] = rd["Yayinevi"].ToString().Trim();
                sayac++;
                istenilen[sayac] = rd["KitapTuru"].ToString().Trim();
                sayac++;
                istenilen[sayac] = rd["Sayfa"].ToString().Trim();
                sayac++;
                istenilen[sayac] = rd["ResimYolu"].ToString().Trim();
                sayac++;
                istenilen[sayac] = rd["Ozet"].ToString().Trim();

            }
            con.Close();

        }

        public static void KitapEkle(string KitapAdi ,string YazarAdi,string BasimYili,string Yayinevi,string KitapTuru,string Sayfa,string ResimYolu,string Ozet)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Insert into Kitaplik(KitapAdi,YazarAdi,BasimYili,Yayinevi,KitapTuru,Sayfa,ResimYolu,Ozet,EklenmeAy,EklenmeGun)Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", con);
            com.Parameters.AddWithValue("@p1",KitapAdi.Trim());
            com.Parameters.AddWithValue("@p2",YazarAdi.Trim());
            com.Parameters.AddWithValue("@p3",BasimYili.Trim());
            com.Parameters.AddWithValue("@p4",Yayinevi.Trim());
            com.Parameters.AddWithValue("@p5",KitapTuru.Trim());
            com.Parameters.AddWithValue("@p6",Sayfa.Trim());
            com.Parameters.AddWithValue("@p7",ResimYolu.Trim());
            com.Parameters.AddWithValue("@p8",Ozet.Trim());
            com.Parameters.AddWithValue("@p9",DateTime.Now.Month);
            com.Parameters.AddWithValue("@p10", DateTime.Now.Day);
            com.ExecuteNonQuery();
            con.Close();


        }
        public static void KitapGuncelle(string KitapAdi, string YazarAdi, string BasimYili, string Yayinevi, string KitapTuru, string Sayfa, string ResimYolu, string Ozet)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Update Kitaplik set KitapAdi=@p1 ,YazarAdi=@p2,BasimYili=@p3,Yayinevi=@p4,KitapTuru=@p5,Sayfa=@p6, ResimYolu=@p7,Ozet=@p8 where KitapAdi=@p9", con);
            com.Parameters.AddWithValue("@p1", KitapAdi);
            com.Parameters.AddWithValue("@p2", YazarAdi);
            com.Parameters.AddWithValue("@p3", BasimYili);
            com.Parameters.AddWithValue("@p4", Yayinevi);
            com.Parameters.AddWithValue("@p5", KitapTuru);
            com.Parameters.AddWithValue("@p6", Sayfa);
            com.Parameters.AddWithValue("@p7", ResimYolu);
            com.Parameters.AddWithValue("@p8", Ozet);
            com.Parameters.AddWithValue("@p9", istenilen[0]);
            com.ExecuteNonQuery();
            con.Close();


        }
        public static void Sil(string name)
            
        {
            if (!name.Equals(""))
            {
                istenilen[0] = name;

            }
            con.Open();
            SqlCommand com = new SqlCommand("Delete from Kitaplik where KitapAdi=@p1", con);
            com.Parameters.AddWithValue("@p1", istenilen[0]);
            com.ExecuteNonQuery();
            con.Close();


        }
        public static void GununSozu()
        {
            con.Open();
            SqlCommand com = new SqlCommand("Select *from GununSozu where GununSozuID=@p1",con);
            com.Parameters.AddWithValue("@p1",DateTime.Now.Day);
            SqlDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                gununsozu = rd["GununSozu"].ToString();
                yazar = rd["GununYazarı"].ToString();

            }
            con.Close();
        }
    




    }
}
