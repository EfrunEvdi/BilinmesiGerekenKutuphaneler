using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcYildizlari.CSharp.Model
{
    internal class Siparis
    {
        public Guid Id { get; set; }
        public DateTime OlusturmaTarihi { get; set; } // ?
        public Urun urun { get; set; }
        public Musteri musteri { get; set; }

        public Siparis()
        {
            urun = new Urun();
            musteri = new Musteri();
        }
    }
}
