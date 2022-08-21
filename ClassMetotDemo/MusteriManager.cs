using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(string Ad,string Soyad)
        {
            Console.WriteLine(Ad+" "+Soyad+" isimli müşteri Eklendi !");
            Console.WriteLine("------------------");

        }
        public void Sil(string Ad,string Soyad)
        {
            Console.WriteLine(Ad+" "+Soyad+" isimli müşteri silindi !");
            Console.WriteLine("------------------");

        }
        public void listele(Musteri musteri,Musteri musteri2)
        {
            Musteri[] customers = new Musteri[]{musteri,musteri2};
            Console.WriteLine("----Listeleme Başladı ! ---");
            foreach (Musteri m in customers)
            {
                
                Console.WriteLine(m.Adi);
                Console.WriteLine(m.Soyadi);
                Console.WriteLine(m.HesapBakiyesi);
                Console.WriteLine(m.BorcMiktari);
                Console.WriteLine("------------------");

            }

        }
    }
}
