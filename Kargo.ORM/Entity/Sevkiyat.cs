using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kargo.ORM.Entity
{
   public class Sevkiyat
    {
        public int SevkiyatID { get; set; }
        public string SAdı { get; set; }
        public string SAlınanNokta { get; set; }
        public string SUlaşılacakNokta { get; set; }
        public int Mesafe { get; set; }
        public decimal MesafeTutarı { get; set; }
        public string SevkiyatTarihi { get; set; }
        public int AraçID { get; set; }


    }
}
