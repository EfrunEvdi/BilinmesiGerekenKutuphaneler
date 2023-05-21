using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcYildizlari.CSharp
{
    public class Musteri
    {
        public Guid ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Tamisim { get; set; }
        public string TelefonNumarasi { get; set; }
        public DateTime OluşturmaTarihi { get; set; }

        public Musteri()
        {
            ID = Guid.NewGuid();
            OluşturmaTarihi = DateTime.Now;
            Console.WriteLine("Ben yapıcı metot olarak çalıştım.");
        }

        public Musteri(string isim)
        {
            this.Isim = isim;
        }

        public Musteri(string isim, string soyisim)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
        }

        public void EkranaYaz()
        {
            Console.WriteLine(this.Isim);
            Console.WriteLine(this.OluşturmaTarihi);
        }

        private void MusteriAdiBirleştir()
        {
            this.Tamisim = $"{this.Isim} {this.Soyisim}";
        }
    }
}
