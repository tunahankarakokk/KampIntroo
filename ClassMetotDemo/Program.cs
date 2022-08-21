using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Adi= "Bahri";
            musteri.Soyadi = "Karakök";
            musteri.BorcMiktari = 5000;
            musteri.HesapBakiyesi = 10000;

            Musteri musteri2=new Musteri();
            musteri2.Adi = "Ali";
            musteri2.Soyadi = "Kaya";
            musteri2.BorcMiktari = 3000;
            musteri2.HesapBakiyesi = 7000;

            MusteriManager musteriManager=new MusteriManager();
            musteriManager.Ekle(musteri2.Adi,musteri2.Soyadi);
            musteriManager.Sil(musteri.Adi, musteri.Soyadi);
            musteriManager.listele(musteri,musteri2);

            Console.ReadLine();
        }
    }
}
