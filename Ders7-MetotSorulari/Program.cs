using System;
using System.Collections.Generic;

namespace Ders7_MetotSorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 sayı 1 işlem alıp sonucu döndüren metodu tanımlayınız.
            // (s1,s2,string)

            //Console.Write("Bir Sayı Giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Bir Sayı Giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Bir İşlem Türü Giriniz: ");
            //string isleminiz = Console.ReadLine();


            //int a = KullaniciIslem(sayi1, sayi2, isleminiz);
            //Console.WriteLine(a);


            // Kendisine gönderilen double dizisini float dizisine çeviren makeItFloat isimli metodu tanımlayınız.
            // 10 elemanlı bir dizi.

            //double[] doubleArrayExp = { 5.0, 4.5, 6.5, 7.9 };
            //makeItFloat(doubleArrayExp);

            Metot3(3, 3.4D, 3.5f);
        }

        static int KullaniciIslem(int s1, int s2, string islem)
        {
            int sonuc = 0;

            if (islem.ToLower() == "topla")
            {
                sonuc = s1 + s2;
                //Console.WriteLine(sonuc);
                return sonuc;
            }
            else if (islem.ToLower() == "çıakrt")
            {
                sonuc = s1 - s2;
                //Console.WriteLine(sonuc);
                return sonuc;
            }
            else if (islem.ToLower() == "çarpma")
            {
                sonuc = s1 * s2;
                //Console.WriteLine(sonuc);
                return sonuc;
            }
            else
            {
                sonuc = s1 / s2;
                //Console.WriteLine(sonuc);
                return sonuc;
            }
        }


        static float[] makeItFloat(double[] doubleArray)
        {
            float[] floatArray = new float[doubleArray.Length];
            for (int i = 0; i < doubleArray.Length; i++)
            {
                floatArray[i] = (float)doubleArray[i];
            }
            //foreach (var item in floatArray)
            //{
            //    Console.WriteLine(item);
            //}
            return floatArray;
        }

        static List<double> KDVEkle(double[] fiyatlar)
        {
            List<double> kdvliFiyatlar = new List<double>();
            // KDV %18.
            foreach (var item in fiyatlar)
            {
                kdvliFiyatlar.Add(item * 1.18);
            }
            return kdvliFiyatlar;
        }


        static void Metot3(int a, double b, float c) 
        {
            Console.WriteLine("Çalıştı");
            return; 
        }
    }
}
