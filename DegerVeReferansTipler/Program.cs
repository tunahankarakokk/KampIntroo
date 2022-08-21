using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int,decmal,float,double,bool=deger tip
            //array,class,interface = referans tip
            //stack heap
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //sayi1 ?? = 30

            int[] sayilar1 = new[] { 10, 20, 30 };
            int[] sayilar2 = new[] { 100,200,300 };
            sayilar1= sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999

            Console.ReadKey();
        }
    }
}
