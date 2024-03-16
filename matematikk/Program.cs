using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematikk
{
    class Program
    {
        static void Main(string[] args)
        {
            Dortislem dortislem = new Dortislem();

            dortislem.Topla(2, 3);
            dortislem.Topla(3, 3);
            dortislem.Topla(4, 3);
            dortislem.Topla(5, 3);
            dortislem.Topla(9, 3);
            dortislem.Topla(8, 3);

            Console.ReadLine();
        }
    
    }
}
