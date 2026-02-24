using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class DepoVeri
    {
        public static Dictionary<string, List<Urun>> KategoriliUrunler = new Dictionary<string, List<Urun>>();

        static DepoVeri()
        {
            KategoriliUrunler["Kategori Seçin"] = new List<Urun>
        {
            
        };
            KategoriliUrunler["Meyve"] = new List<Urun>
        {
            new Urun { Ad = "Elma", Stok = 100, AlisFiyat = 20 },
            new Urun { Ad = "Armut", Stok = 150, AlisFiyat = 25 },
            new Urun { Ad = "Portakal", Stok = 200, AlisFiyat = 30 }
        };

            KategoriliUrunler["Sebze"] = new List<Urun>
        {
            new Urun { Ad = "Domates", Stok = 75, AlisFiyat = 40 },
            new Urun { Ad = "Salatalık", Stok = 50, AlisFiyat = 10 },
            new Urun { Ad = "Biber", Stok = 100, AlisFiyat = 35 }
        };

            KategoriliUrunler["İçecek"] = new List<Urun>
        {
            new Urun { Ad = "Su", Stok = 1000, AlisFiyat = 3 },
            new Urun { Ad = "Kola", Stok = 200, AlisFiyat = 15 },
            new Urun { Ad = "Ayran", Stok = 500, AlisFiyat = 5 }
        };
        }
    }
}
