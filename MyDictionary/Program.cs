using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sayilar = new Dictionary<int, string>();
            sayilar.Add(5,"Beş");
            Console.WriteLine(sayilar[5]);
            Console.WriteLine(sayilar.Count);




            MyDictionary<int, string> sayilar2 = new MyDictionary<int, string>();
            sayilar2.Add(1,"Bir");
            sayilar2.Add(2,"İki");
            sayilar2.Add(3,"Üç");
            sayilar2.Add(4, "Dört");
            sayilar2.Add(5, "Beş");
            sayilar2.Add(6, "Altı");
            sayilar2.Add(7, "Yedi");
            sayilar2.Add(8, "Sekiz");
            sayilar2.Add(9, "Dokuz");

            Console.WriteLine(sayilar2.Count);
            sayilar2.Show();




            Console.ReadLine();
        }
        class MyDictionary<T,A>
        {
            T[] keys;
            A[] values;
            T[] tempKeys;
            A[] tempValues;

            public MyDictionary()
            {
                keys=new T[0];
                values=new A[0];
            }
            public void Add(T key,A value)
            {
                tempKeys = keys;
                keys = new T[keys.Length + 1];
                tempValues = values;
                values = new A[values.Length + 1];
                for (int i = 0; i < tempKeys.Length; i++)
                {
                    keys[i] = tempKeys[i];
                    
                }
                keys[keys.Length - 1] = key;
                for (int j = 0; j < tempValues.Length; j++)
                {
                    values[j] = tempValues[j];
                }
                values[values.Length - 1] = value;
                
                
            }
            public void Show()
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    Console.WriteLine("Sayıyla :" + keys[i] + "Yazıyla : " + values[i]);
                }
            }

            public int Count
            {
                get { return keys.Length; }
            }
        }
    }
}
