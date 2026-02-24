using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Urun
    {
        public string Ad { get; set; }
        public string Kategori { get; set; }
        public int Stok { get; set; }
        public decimal AlisFiyat { get; set; }
        public List<SatisKaydi> Hareketler { get; set; } = new List<SatisKaydi>();
    }
}
