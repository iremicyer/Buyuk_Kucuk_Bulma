using System;
using System.Transactions;

namespace Kucuk_Buyuk_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sayi3;
            Console.Title = "girilen 3 sayidan en buyugu ve en kucugunu bulma"; // açılacak konsol ekranının başlığını belirledik

            Console.Write("1. sayiyi giriniz:\t");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayiyi giriniz:\t");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("3. sayiyi giriniz:\t");
            sayi3 = Convert.ToDouble(Console.ReadLine());

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                Console.WriteLine("en buyuk sayi: {0}", sayi1);
            }
            if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                Console.WriteLine(" en buyuk sayi: {0}", sayi2);
            }
            if (sayi3 > sayi1 && sayi3 > sayi2)
            {
                Console.WriteLine("en buyuk sayi: {0}", sayi3);
            }
            if (sayi1 < sayi2 && sayi1 < sayi3)
            {
                Console.WriteLine(" en kucuk sayi: {0}", sayi1);
            }
            if (sayi2 < sayi1 && sayi2 < sayi3)
            {
                Console.WriteLine("en kucuk sayi: {0}", sayi2);
            }
            if (sayi3 < sayi1 && sayi3 < sayi2)
            {
                Console.WriteLine("en kucuk sayi: {0}", sayi3);
            }
            Console.ReadKey();
        }
    }
}
