using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        /*
         git ekle git sil git güncelle söyledikten sonra emiri bitirdikten sonra işlem sonucunda ekstra bilgiye ihtiyaç yoksa 
        void tanımlanır git yap bitir
         */

        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
      
    }
}
