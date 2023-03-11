using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Ornek_3
{
    internal class Program
    {
        static void Main(string[] args)
        { // Aşağıdaki isimler on kere yazdırılır
            /* Kisiler ks = new Kisiler();
               ks.kisilistesi("Murat Sadi");
               ks.kisilistesi("Ali Alper");
               Console.Read(); */

            Kisiler ks = new Kisiler();
            string ads;
            Console.Write("Bİr isim giriniz!: ");
            ads = Console.ReadLine();
            ks.kisilistesi(ads);
            Console.Read();
        }
    }
}
