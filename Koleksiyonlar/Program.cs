using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // steak             //heap     //değerler
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //toplu comment alma ctrl+k-ctrl+c geri alma ctrl+k-ctrl+u
            List<string> isimler2 = new List<string> {"Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            
        





            Console.ReadLine();
        }
    }
}
