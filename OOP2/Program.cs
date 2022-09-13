using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 =new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";



           //                      Referans No
            Musteri musteri3 = new GercekMusteri();//ebeveyn olan miras bırakan musteri ikisinide tutabiliyor
            Musteri musteri4 = new TuzelMusteri();


            //temel sınıfın onu inherite eden gerçek ve tüzel müşteriyi tutabilmesidir
            MusteriManager musteriManager=new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);






            //Gerçek Müşteri -Tüzel Müşteri
            //SOLID
        }
    }
}
