using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kargo.ORM.Entity
{
    public class Musteri
    {

        public int MusteriID { get; set; }
        public string MusteriAdSoyadı { get; set; }
        public string Adres { get; set; }
        public int Telefon { get; set; }
        public string Mail { get; set; }
        public string ÖdemeDurumu { get; set; }
        public int ŞubeID { get; set; }
        public int SevkiyatID { get; set; }
    }
}
