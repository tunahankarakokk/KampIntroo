using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfacelerde o classı inherite eden classın referansını tutabiliyor
            IKrediManager ihtiyacKrediManager=new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService FileloggerService = new FileLoggerService();
            ILoggerService SmsloggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),SmsloggerService);//yukarıda newlenenlerden birini göndeririz

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnbilgilendirmesiYap(krediler);

            Console.ReadLine();
        }
    }
}
