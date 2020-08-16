using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Kargo.ORM.Entity;


namespace Kargo.ORM.Facade
{
    public class Şubeler
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("ŞubeListele", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }
        public static bool Ekle(Şube nesne)
        {
            SqlCommand kaydet = new SqlCommand("ŞubeEkle", Tools.Baglanti);
            kaydet.CommandType = CommandType.StoredProcedure;
            kaydet.Parameters.AddWithValue("@ŞubeAdı", nesne.ŞubeAdı);
            kaydet.Parameters.AddWithValue("@Şubeİl", nesne.Şubeİl);
            kaydet.Parameters.AddWithValue("@Şubeİlçe",nesne.Şubeİlçe);
            kaydet.Parameters.AddWithValue("@TeslimDurumu", nesne.TeslimDurumu);
            return Tools.ExecuteNonQuery(kaydet);
        }
        public static bool Sil(Şube nesne)
        {
            SqlCommand sil = new SqlCommand("ŞubeSil", Tools.Baglanti);
            sil.CommandType = CommandType.StoredProcedure;
            sil.Parameters.AddWithValue("@ŞubeID", nesne.ŞubeID);
            return Tools.ExecuteNonQuery(sil);
        }
        public static bool Güncelle(Şube nesne)
        {
            SqlCommand yenile = new SqlCommand("ŞubeGüncelle", Tools.Baglanti);
            
            yenile.CommandType = CommandType.StoredProcedure;
            yenile.Parameters.AddWithValue("ŞubeID", nesne.ŞubeID);
            yenile.Parameters.AddWithValue("@ŞubeAdı", nesne.ŞubeAdı);
            yenile.Parameters.AddWithValue("@Şubeİl", nesne.Şubeİl);
            yenile.Parameters.AddWithValue("@Şubeİlçe", nesne.Şubeİlçe);
            yenile.Parameters.AddWithValue("@TeslimDurumu", nesne.TeslimDurumu);
            return Tools.ExecuteNonQuery(yenile);

        }
    }
}
