using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcYildizlari.CSharp.Model
{
    internal class Urun
    {
        public Guid urunId { get; set; }
        public string urunAdi { get; set; }
        public decimal UrunFiyat { get; set; }

        public static decimal VergiOrani { get; set; }

        public Urun()
        {
            Console.WriteLine("Ben bir yapıcı metodum.");
        }

        static Urun()
        {
            Console.WriteLine("Bende static yapıcı metodum.");
            VergiOrani = 20;
        }

        public static void Karsilama()
        {
            Console.WriteLine("Static Karşılama");
        }
    }
}
