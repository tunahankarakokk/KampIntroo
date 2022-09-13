using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager//interface şablon görevi görüyor
                           //interfaceler okunurluğu arttırmak için I harfiyle isimlendr
                           //biribirinin alternatifi olan ama kod içerikleri farklı olan 
                           //durumlar için kullanırız
    {
        void Hesapla();
        void BiseyYap();

    }
}
