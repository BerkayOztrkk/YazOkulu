using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using dene;
using EntityBasvuru;




namespace DataAccesLayer
{
    public class DALDers
    {
        public static List<EntityDersler> DersListesi()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();
            SqlCommand komuto = new SqlCommand("select*from TBLDersler", Baglantı.bgl);
            if (komuto.Connection.State!=ConnectionState.Open)
            {
                komuto.Connection.Open();
            }
            SqlDataReader dr = komuto.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler ent = new EntityDersler();
                ent.Id=Convert.ToInt32(dr["Dersid"].ToString());
                ent.Dersad=dr["Dersad"].ToString();
                ent.Min=int.Parse(dr["Derskontenjanmin"].ToString());
                ent.Max= int.Parse(dr["Derskontenjanmax"].ToString());
                ent.Fotograf=dr["Ogrencifoto"].ToString();
                ent.Sifre=dr["Ogrencisifre"].ToString();
                ent.Bakiye=Convert.ToDouble(dr["Ogrencibakiye"].ToString());
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;

        }
    }
}
