using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Kargo.ORM.Entity;


namespace Kargo.ORM.Facade
{
   public class Araçlar
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("AracListele", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }
        public static bool Ekle(Arac nesne)
        {
            SqlCommand kaydet = new SqlCommand("AracEkle", Tools.Baglanti);
            kaydet.CommandType = CommandType.StoredProcedure;
            kaydet.Parameters.AddWithValue("@AraçTürü", nesne.AraçTürü);
            kaydet.Parameters.AddWithValue("@AraçKapasitesi", nesne.AraçKapasitesi);
            kaydet.Parameters.AddWithValue("@AraçŞoförü", nesne.AraçŞoförü);
            return Tools.ExecuteNonQuery(kaydet);
        }
        public static bool Sil(Arac nesne)
        {
            SqlCommand sil = new SqlCommand("AracSil", Tools.Baglanti);
            sil.CommandType = CommandType.StoredProcedure;
            sil.Parameters.AddWithValue("@AraçID", nesne.AraçID);
            return Tools.ExecuteNonQuery(sil);
        }
        public static bool Güncelle(Arac nesne)
        {
            SqlCommand yenile = new SqlCommand("AracGüncelle", Tools.Baglanti);
            
            yenile.CommandType = CommandType.StoredProcedure;
            yenile.Parameters.AddWithValue("@AraçID",nesne.AraçID);
            yenile.Parameters.AddWithValue("@AraçTürü", nesne.AraçTürü);
            yenile.Parameters.AddWithValue("@AraçKapasitesi", nesne.AraçKapasitesi);
            yenile.Parameters.AddWithValue("@AraçŞoförü", nesne.AraçŞoförü);
            return Tools.ExecuteNonQuery(yenile);
        }
    }
}
