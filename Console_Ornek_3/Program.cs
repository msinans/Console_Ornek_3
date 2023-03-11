using System;

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

            // Klavyeden girileceki isim on kere yazdırılır
            Kisiler ks = new Kisiler();
            string ads;
            Console.Write("Bİr isim giriniz!: ");
            ads = Console.ReadLine();
            ks.kisilistesi(ads);
            Console.Read();
        }
    }
}
