using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcYildizlari.CSharp.Model
{
    internal class TemelOzellikler
    {
        public Guid id { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public Guid OlusturanKullanici { get; set; }
        public Guid DegistirenKullanici { get; set; }
        public DateTime DegistirmeTarihi { get; set; }

        public TemelOzellikler(Guid Id)
        {
            this.id = Id;
            Console.WriteLine("Temel Özellikler sınıfının yapıcı metodu");
        }

        public void EkranaYazI()
        {
            Console.WriteLine("Ekrana yaz 1.");
        }

        protected void EkranaYazII() // Kalıtıldığı sınıfta kullanılabilir.
        {
            Console.WriteLine("Ekrana yaz 2.");
        }
    }
}
