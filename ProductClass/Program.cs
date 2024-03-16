using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Kazak";
            urun1.UrunRengi = "Mavi";
            urun1.UrunBedeni = 'S';
            urun1.UrunStogu = 10;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Pantolon";
            urun2.UrunRengi = "Siyah";
            urun2.UrunBedeni = 'M';
            urun2.UrunStogu = 5;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Ceket";
            urun3.UrunRengi = "Kırmızı";
            urun3.UrunBedeni = 'L';
            urun3.UrunStogu = 2;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + ", " + urun.UrunRengi + ", " + urun.UrunBedeni + ", " + urun.UrunStogu);
            }

            Console.ReadLine();
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public string UrunRengi { get; set; }
        public char UrunBedeni { get; set; }
        public int UrunStogu { get; set; }
    }
}
