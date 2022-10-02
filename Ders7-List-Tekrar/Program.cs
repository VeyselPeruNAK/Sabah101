using System;
using System.Collections.Generic;
using System.Linq;

namespace Ders7_List_Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Tanımlama
            //List<int> liste = new List<int>();
            //// Veri ekleme
            //liste.Add(14); // Listenin sonuna 14 ekler.
            //liste.Insert(1, 34); // index belirterek ekleme yaptık.
            //// veriye getirme
            //Console.WriteLine(liste[0]); // listenin 0. indexini yazdırdık.
            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item); // listedeki her elemanı ekrana yazdırdık.
            //}

            //// listeyi temizleme
            //// liste.clear(); //temizler.

            //// Listenin eleman sayısı veya bir elemanın ka. defa olduğu..

            //List<string> sehirler = new List<string>() { "istanbul", "İzmir", "Manisa", "Van","Mersin","Gaziantep","Şanlıurfa","Van" };

            //int elemanSayisi = sehirler.Count();

            //int vanSayisi = sehirler.Count(sehir => sehir == "Van");
            //Console.WriteLine($"Van: {vanSayisi}");
            //Console.WriteLine($"Toplam eleman sayısı: {elemanSayisi}");

            //// Veri silme
            //sehirler.Remove("istanbul");
            //sehirler.RemoveAt(6);

            //for (int i = 0; i < sehirler.Count(); i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}


            //bool adanaVarMi = sehirler.Contains("Adana"); // Adana listede var mı?

            // SORU: Kullanıcıdan 5 isim alıp bunları sıralayıp ekrana yazdıran programı yazınız.

            //List<string> isimler = new List<string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("isim : ");
            //    isimler.Add(Console.ReadLine());
            //}
            //isimler.Sort();
            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);


            // Farklı tipte verileri tutmak için.
            List<object> karisikListe = new List<object>() { 1, "Mehmet Demir", 432, "5462923058",true };
            


        }
    }
}
