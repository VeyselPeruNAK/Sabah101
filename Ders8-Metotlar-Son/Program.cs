using System;

namespace Ders8_Metotlar_Son
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Topla(4,5));
            //Console.WriteLine(Topla(4,5,5,6,7));
            //Console.WriteLine(Topla(4,5,12,13,14));
            //Console.WriteLine(Topla(4,5,100));

            //Console.WriteLine(PuanTopla("Mehmet",33,50,40,20,30));
            //Console.WriteLine(PuanTopla("Engin",35,45,56));

            //int f4 = Faktoriyel(4);
            //Console.WriteLine(f4);

            int s1 = 5; // ilk değer ataması yaptık.
            Console.WriteLine(DegerDegistir(ref s1));
            Console.WriteLine(s1);


            int s2; // ilk değer ataması yapmadık.
            Console.WriteLine(DegerDegistirOut(out s2));
            Console.WriteLine(s2);

        }

        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }

        // params parametreleri normal parametreler ile birlikte kullanılırken params en sağda kalmalıdır!!!
        static string PuanTopla(string isim, int yas, params int[] puanlar)
        {
            int toplamPuan = 0;
            foreach (int puan in puanlar)
            {
                toplamPuan += puan;
            }
            return isim + " " + Convert.ToString(toplamPuan);
        }

        // 5! = 5.4! = 5.4.3! = 5.4.3.2! = 5.4.3.2.1


        // Recursive: Kendini tekrar eden veya çağıran metotlar.
        static int Faktoriyel(int sayi)
        {
            if (sayi <= 1)
                return 1;
            else
                return sayi * Faktoriyel(sayi - 1);
        }





        // ref kullanılırken parametrenin ilk değer ataması zorunludur.
        static int DegerDegistir(ref int sayi)
        {
            sayi = sayi * 10;
            return sayi;
        }
        // out kullanılırken parametrenin ilk değer ataması zorunlu değildir.
        static int DegerDegistirOut(out int sayi)
        {
            sayi = 20;
            return sayi + 100;
        }















    }
}
