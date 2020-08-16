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
   public class Musteriler
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("MusteriListele", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }
        public static bool Ekle(Musteri nesne)
        {
            SqlCommand kaydet = new SqlCommand("MusteriEkle", Tools.Baglanti);
            kaydet.CommandType = CommandType.StoredProcedure;
            kaydet.Parameters.AddWithValue("@MusteriAdSoyadı", nesne.MusteriAdSoyadı);
            kaydet.Parameters.AddWithValue("@Adres", nesne.Adres);
            kaydet.Parameters.AddWithValue("@Telefon", nesne.Telefon);
            kaydet.Parameters.AddWithValue("@Mail", nesne.Mail);
            kaydet.Parameters.AddWithValue("@ÖdemeDurumu", nesne.ÖdemeDurumu);
            kaydet.Parameters.AddWithValue("@ŞubeID", nesne.ŞubeID);
            kaydet.Parameters.AddWithValue("@SevkiyatID", nesne.SevkiyatID);



            return Tools.ExecuteNonQuery(kaydet);
        }
        public static bool Güncelle(Musteri nesne)
        {
            SqlCommand kaydet = new SqlCommand("MusteriGüncelle", Tools.Baglanti);
            kaydet.CommandType = CommandType.StoredProcedure;
            kaydet.Parameters.AddWithValue("@MusteriID", nesne.MusteriID);
            kaydet.Parameters.AddWithValue("@MusteriAdSoyadı", nesne.MusteriAdSoyadı);
            kaydet.Parameters.AddWithValue("@Adres", nesne.Adres);
            kaydet.Parameters.AddWithValue("@Telefon", nesne.Telefon);
            kaydet.Parameters.AddWithValue("@Mail", nesne.Mail);
            kaydet.Parameters.AddWithValue("@ÖdemeDurumu", nesne.ÖdemeDurumu);
            kaydet.Parameters.AddWithValue("@ŞubeID", nesne.ŞubeID);
            kaydet.Parameters.AddWithValue("@SevkiyatID", nesne.SevkiyatID);



            return Tools.ExecuteNonQuery(kaydet);
        }
        public static bool Sil(Musteri nesne)
        {
            SqlCommand sil = new SqlCommand("MüsteriSil", Tools.Baglanti);
            sil.CommandType = CommandType.StoredProcedure;
            sil.Parameters.AddWithValue("@MusteriID", nesne.MusteriID);
            return Tools.ExecuteNonQuery(sil);
        }
    }
}
