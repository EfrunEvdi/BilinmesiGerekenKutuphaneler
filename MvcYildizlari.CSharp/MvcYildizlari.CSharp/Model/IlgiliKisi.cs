using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcYildizlari.CSharp.Model
{
    internal class IlgiliKisi : TemelOzellikler
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string EpostaAdresi { get; set; }

        public IlgiliKisi() : base(Guid.NewGuid())
        {
            OlusturmaTarihi = DateTime.Now;
            Console.WriteLine("İlgili kişi sınıfının yapıcı metodu");
        }
    }
}

/*
 * id
 * isim
 * soyisim
 * eposta
 * olusturmatarihi
 * olusturankullanici
 * degistirmetarihi
 * degistirenkullanici
 */
