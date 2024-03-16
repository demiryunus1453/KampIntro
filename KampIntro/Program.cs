using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kategoriEtiketi = "Kategoriler"; // değişkenler değer tutucudur.
            //int  ogrenciSayisi = 0;
            //double faizOrani = 1.34;
            //bool sistemeGirisYapmismi = false; // programın dallanmasını sağlar normalde ***sistemeGirisYapmismiBak(); gibi kullanılır.
            //double dolarDun = 7.35;
            //double dolarBugun = 7.55;

            //if (dolarDun>dolarBugun)
            //{
            //    Console.WriteLine("Azalıs oku");
            //}
            //else if (dolarDun > dolarBugun)
            //{
            //    Console.WriteLine("Artis oku");
            //}

            //if (sistemeGirisYapmismi == true)
            //{
            //    Console.WriteLine("kullanıcı ayarları butonu"); // Normal programda böyle yazılmaz, consol yerine imaş koyulur
            //}
            //else
            //{
            //    Console.WriteLine("Giriş yap butonu");
            //}
            Dersler dersler1 = new Dersler();
            dersler1.MyProperty = 5;
            dersler1.MyProperty2 = 10;
            dersler1.MyProperty3 = 20;

            Dersler dersler2 = new Dersler();
            dersler2.MyProperty = 53;
            dersler2.MyProperty2 = 30;
            dersler2.MyProperty3 = 220;


            Dersler dersler3 = new Dersler();
            dersler3.MyProperty = 533;
            dersler3.MyProperty2 = 330;
            dersler3.MyProperty3 = 2230;

            Dersler[] dersler = new Dersler[] { dersler1, dersler2 , dersler3 };

            foreach (var ders in dersler)
            {
                Console.WriteLine(ders.MyProperty);
            }


            Console.ReadLine();


        }
    }

    class Dersler
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set;}
        public int MyProperty3 { get; set;}
    }
}
