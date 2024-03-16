
using Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods // methodlar bizim için tekrar tekrar kullanılamayı sağlayan kod bloklarıdır.
    // clean code , best practice(dıoğru uygulama teknikleri) 
{
    class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "elma";
            int Fiyati = 75;
            string Aciklama = "amasya elması";

            Product product1 = new Product(); // class örneği deniliyor.

            product1.Adi = "elma";
            product1.Fiyati = 25;
            product1.Aciklama = "amasya elması";

            Product product2 = new Product(); // class örneği deniliyor.

            product2.Adi = "karpuz";
            product2.Fiyati = 50;
            product2.Aciklama = "diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 }; // diziler istediğim kadar datayı içinde tutan yapılardır.

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("****************");
            }
            
            Console.WriteLine("*******METHODLAR********"); 
            
            SepetManager sepetManager = new SepetManager();  /// class örneğini buraya tanımladık.

            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("armut", "yeşil armut", 8, 9);
            sepetManager.Ekle2("lahana", "kara lahana", 9 ,8);
            sepetManager.Ekle2("muz", "olgun muz", 25, 9);




            Console.ReadLine(); 
        }
    }
}
