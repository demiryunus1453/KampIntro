using Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class SepetManager// operasyo0n tutucu bir sınıftır bu içerisinde bir takım iş yapıcı özelliker barındırır.
    {
        public void Ekle(Product product) /// Buradan paramaetre ekleme işlemlerini gerçekleştiriyoruz..
        {
            Console.WriteLine("Tebrikler ürün sepete başarıyla eklendi..." + product.StokMiktari);
        }
        public void Ekle2(string urunAdi , string aciklama , Double fiyat ,int stokMiktari)
        {
            Console.WriteLine ("tebrikler sepete eklendi :" + urunAdi); 
        }
    }
}
