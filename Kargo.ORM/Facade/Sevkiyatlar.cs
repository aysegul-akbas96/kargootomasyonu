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
  public  class Sevkiyatlar
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SevkiyatListele", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }
        public static bool Ekle(Sevkiyat nesne)
        {
            SqlCommand kaydet = new SqlCommand("SevkiyatEkle", Tools.Baglanti);
            kaydet.CommandType = CommandType.StoredProcedure;
            kaydet.Parameters.AddWithValue("@SAdı", nesne.SAdı);
            kaydet.Parameters.AddWithValue("@SAlınanNokta", nesne.SAlınanNokta);
            kaydet.Parameters.AddWithValue("@SUlaşılacakNokta", nesne.SUlaşılacakNokta);
            kaydet.Parameters.AddWithValue("@Mesafe", nesne.Mesafe);
            kaydet.Parameters.AddWithValue("@MesafeTutarı", nesne.MesafeTutarı);
            kaydet.Parameters.AddWithValue("@SevkiyatTarihi", nesne.SevkiyatTarihi);
            kaydet.Parameters.AddWithValue("@AraçID", nesne.AraçID);
            


            return Tools.ExecuteNonQuery(kaydet);
        }
        public static bool Sil(Sevkiyat nesne)
        {
            SqlCommand sil = new SqlCommand("Sevkiyatsil", Tools.Baglanti);
            sil.CommandType = CommandType.StoredProcedure;
            sil.Parameters.AddWithValue("@SevkiyatID", nesne.SevkiyatID);
            return Tools.ExecuteNonQuery(sil);
        }
        public static bool Güncelle(Sevkiyat nesne)
        {

            SqlCommand yenile = new SqlCommand("SevkiyatGüncelle", Tools.Baglanti);
            yenile.CommandType = CommandType.StoredProcedure;
            yenile.Parameters.AddWithValue("@SevkiyatID", nesne.SevkiyatID);
            yenile.Parameters.AddWithValue("@SAdı", nesne.SAdı);
            yenile.Parameters.AddWithValue("@SAlınanNokta", nesne.SAlınanNokta);
            yenile.Parameters.AddWithValue("@SUlaşılacakNokta", nesne.SUlaşılacakNokta);
            yenile.Parameters.AddWithValue("@Mesafe", nesne.Mesafe);
            yenile.Parameters.AddWithValue("@MesafeTutarı", nesne.MesafeTutarı);
            yenile.Parameters.AddWithValue("@SevkiyatTarihi", nesne.SevkiyatTarihi);
            yenile.Parameters.AddWithValue("@AraçID", nesne.AraçID);

            return Tools.ExecuteNonQuery(yenile);
        }
    }
}
