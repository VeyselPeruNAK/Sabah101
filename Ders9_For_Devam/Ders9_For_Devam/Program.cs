using System;
using System.Collections.Generic;

namespace Ders9_For_Devam
{
    class Program
    {
        static void Main(string[] args)

        // Çarpım tablosu yan yana:



        {
            //Çarpım Tablosu, Yanyana             
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write(j + "x" + i + "=" + (i * j) + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= 20; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            List<string> kitaplar = new List<string>();
            while (true)
            {
                Console.WriteLine("     Menu     ");
                Console.WriteLine("  1)Görüntüle            ");
                Console.WriteLine("  2)Ekle            ");
                Console.WriteLine("  3)Sil            ");
                Console.WriteLine("  4)Çıkış            ");
                Console.WriteLine();
                Console.Write("Seçim:");
                string secim = Console.ReadLine();
                if (secim == "4")
                    break;
                else if (secim == "1")
                {
                    Console.WriteLine("Tanımlı kitaplar:");
                    foreach (var item in kitaplar)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (secim == "2")
                {
                    Console.Write("Kitap adı:");
                    string k = Console.ReadLine();
                    kitaplar.Add(k);
                }
                else if (secim == "3")
                {
                    Console.Write("Silinecek kitap adı:");
                    string k = Console.ReadLine();
                    kitaplar.Remove(k);
                }
                else
                    Console.WriteLine("Yanlış seçim!");

            }
        }

    }
}
