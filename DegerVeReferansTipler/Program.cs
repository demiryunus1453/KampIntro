using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler // ***Değer ve referans tipler***
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 20;
            int sayi2 = 10;  

            sayi1 = sayi2;

            sayi2 = 65;

            Console.WriteLine(sayi1); // sayi1 =10
            Console.WriteLine(sayi2);   // sayi2 = 65

            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;

            sayilar1[0] = 999;

            Console.WriteLine(sayilar1[0]);

            Console.ReadLine();

            //Not:Değer tiplerde değeri, referans tiplerde ise adresi atammış oluyoruz. yani değer tip sadece değeri alıyor referans tip ise sadece adres numarasını kendine referans olaraka alıyor.


        }
    }
}
