using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortislem = new DortIslem();
            dortislem.Topla(5,6);
            dortislem.Topla(6,9);
        
        Console.ReadKey();
        }

        
    }
}
