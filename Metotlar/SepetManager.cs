using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax

        public void Ekle(Urun urun)//c# da bir yerde parantez görüyorsanız metottur.
        {
            Console.WriteLine("Tebrikler ! Sepete Eklendi : "+ urun.Adi);
            //
            //
            //
            //
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler ! Sepete Eklendi : "+urunAdi +" "+ aciklama+" "+fiyat);
        }
    }
}
