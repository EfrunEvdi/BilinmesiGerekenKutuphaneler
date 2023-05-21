using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcYildizlari.CSharp.Model
{
    internal partial class Cari
    {
        public int id { get; set; }
        public string CariNo { get; set; }

        public override string ToString()
        {
            return $"{id} {CariNo}";
        }
    }
}
