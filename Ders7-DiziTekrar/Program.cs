using System;

namespace Ders7_DiziTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            //int degisken = 100;
            //int[] dizi = new int[5]; // 5 elemanlı bir int dizisi.

            //// Diziye veri atadık.
            //dizi.SetValue(10, 0);   // dizi[0] = 10; // yandaki SetValue metodu ile aynı işi yapar.
            //dizi[1] = 20;
            //dizi[2] = 30;
            //dizi[3] = 40;
            //dizi[4] = 50;

            //int sayi = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    sayi += 10;
            //    dizi[i] = sayi;
            //}

            //Console.WriteLine(dizi[0]);
            //Console.WriteLine(dizi[1]);
            //Console.WriteLine(dizi[2]);
            //Console.WriteLine(dizi[3]);
            //Console.WriteLine(dizi[4]);

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}


            //string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara","Adıyaman" };

            //int AnkaraIndeksi = Array.IndexOf(sehirler, "Ankara");
            //int AdiyamanIndeksi1 = Array.IndexOf(sehirler, "Adıyaman");  // 1. index
            //int AdiyamanIndeksi2 = Array.IndexOf(sehirler, "Adıyaman",2); // 6.index : aramaya 2. indeksten başladık.




            ////// Diziden diziye kopyalama
            //int[] dizi1 = { 11, 41, 21, 32, 43, 54, 65, 66, 77, 86 };

            ////int[] dizi2 = new int[10];
            //int[] dizi2 = { 1,2,3,4,5,6,7,8,9,10 };

            //// dizi1'i dizi2'ye 0. indisten itibaren kopyala.
            //dizi1.CopyTo(dizi2, 0);

            //foreach (var item in dizi2)
            //{
            //    Console.WriteLine(item);
            //}


            //////////////////////////////
            //// ÇOK BOYUTLU DİZİLER  ////
            //////////////////////////////
            //{
            //    { 1,2,3,4,5},  // [0,4] = 0. satır,4. kolon.=>5
            //    { 6,7,8,9,10}
            //}

            //int[,] matris = new int[5, 5]; // 5x5 lik bir matris tanımlar.
            //matris[0, 0] = 10;
            //matris[0, 4] = 20;
            //matris[4, 4] = 30;

            // SORU: 2x3'lül bir dizi tanılayın. İçerisine rastgele üretilen
            // (1-15 aralığında) sayıları atayın.
            // Son olarak diziyi ekrana yazdırın.

            //int[,] dizi = new int[2,3];
            //Random r = new Random();

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        dizi[i, j] = r.Next(1,15);
            //    }
            //}





            //    Console.WriteLine();
            //}

            /*
            1 0 0 0 0
            0 1 0 0 0
            0 0 1 0 0
            0 1 0 0 0
            1 0 0 0 0
            (i==j) (i+j==4) (j<3)
            */

            //int[,] dizi = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (  (i == j || i + j == 4)    &&    j < 3)
            //        {
            //            dizi[i, j] = 1;
            //        }
            //    }
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(dizi[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            /*
            1 1 1 1 0
            1 1 1 1 0
            1 1 1 1 0
            1 1 1 1 0
            0 0 0 0 0
                */
            int[,] dizi = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i <= 3 && j <= 3)
                    {
                        dizi[i, j] = 1;
                    }
                }
            }

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(dizi[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            /*
             * 
            1 1 1 1 1
            1 0 0 0 1
            1 0 0 0 1
            1 0 0 0 1
            1 1 1 1 1
             */

            //int[,] dizi = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if ((i == 0) || (i == 4) || (j == 0) || (j == 4))
            //        {
            //            dizi[i, j] = 1;
            //            //Console.WriteLine("i=" + i + " j=" + j);
            //        }
            //    }
            //}

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }

            int a = 10;
            Console.WriteLine(a++);
            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a);
            Console.WriteLine(a--);
            Console.WriteLine(--a);


        }
    }
}
