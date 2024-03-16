using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using dene;

namespace DataAccesLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOgrenciler(Ogrenciad,Ogrencisoyad,Ogrencino,Ogrencifoto,Ogrencisifre) values (@p1,@p2,@p3,@p4,@p5)", Baglantı.bgl);
            if (komut1.Connection.State!=ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ad);
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Numara);
            komut1.Parameters.AddWithValue("@p4", parametre.Fotograf);
            komut1.Parameters.AddWithValue("@p5", parametre.Sifre);
            return komut1.ExecuteNonQuery();


        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komuto = new SqlCommand("select*from TBLOgrenciler", Baglantı.bgl);
            if (komuto.Connection.State!=ConnectionState.Open)
            {
                komuto.Connection.Open();
            }
            SqlDataReader dr = komuto.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id=Convert.ToInt32(dr["Ogrenciid"].ToString());
                ent.Ad=dr["Ogrenciad"].ToString();
                ent.Soyad=dr["Ogrencisoyad"].ToString();
                ent.Numara=dr["Ogrencino"].ToString();
                ent.Fotograf=dr["Ogrencifoto"].ToString();
                ent.Sifre=dr["Ogrencisifre"].ToString();
                ent.Bakiye=Convert.ToDouble(dr["Ogrencibakiye"].ToString());
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;

        }
        public static bool OgrenciSil(int perametre)
        {
            SqlCommand komuts = new SqlCommand("Delete from TBLOgrenciler where Ogrenciid=@p1", Baglantı.bgl);
            if (komuts.Connection.State!=ConnectionState.Open)
            {
                komuts.Connection.Open();
            }
            komuts.Parameters.AddWithValue("@p1", perametre);
            return komuts.ExecuteNonQuery()>0;

        }
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komutd = new SqlCommand("select*from TBLOgrenciler where Ogrenciid=@p1", Baglantı.bgl);
            komutd.Parameters.AddWithValue("@p1", id);
            if (komutd.Connection.State!=ConnectionState.Open)
            {
                komutd.Connection.Open();
            }
            SqlDataReader dr = komutd.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();

                ent.Ad=dr["Ogrenciad"].ToString();
                ent.Soyad=dr["Ogrencisoyad"].ToString();
                ent.Numara=dr["Ogrencino"].ToString();
                ent.Fotograf=dr["Ogrencifoto"].ToString();
                ent.Sifre=dr["Ogrencisifre"].ToString();
                ent.Bakiye=Convert.ToDouble(dr["Ogrencibakiye"].ToString());
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;

        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
          
           SqlCommand komutG = new SqlCommand("update TBLOgrenciler set Ad=@p1,Soyad=@p2,Numara=@p3,Sifre=@p4,Fotograf=@p5 where Id=@p6", Baglantı.bgl);
            if (komutG.Connection.State!=ConnectionState.Open)
            {
                komutG.Connection.Open();
            }
            komutG.Parameters.AddWithValue("@p1",deger.Ad);
            komutG.Parameters.AddWithValue("@p2",deger.Soyad);
            komutG.Parameters.AddWithValue("@p3",deger.Numara);
            komutG.Parameters.AddWithValue("@p4",deger.Sifre);
            komutG.Parameters.AddWithValue("@p5",deger.Fotograf);
            komutG.Parameters.AddWithValue("@p6",deger.Id);
            return komutG.ExecuteNonQuery()>0;
        }

    }
}
