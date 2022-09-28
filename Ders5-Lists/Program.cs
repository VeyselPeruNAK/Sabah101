﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Ders5_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Dİzilerden farklı olarak. Kapasitesi sınırlı değildir. otomatik genişler.

            //// Tanımlama
            //List<int> ilkListem = new List<int>();
            //List<string> sehirler = new List<string>() { "istanbul", "İzmir", "Manisa", "Van" };
            //List<int> araListe = new List<int>() { 1000, 2000, 3000 };
            //// Veri Ekleme
            //ilkListem.Add(1990); // Add metodu listenin sonuna ekleme yapar.
            //ilkListem.Add(1231);
            //ilkListem.Add(1921);
            //ilkListem.Insert(0, 1988); // 0. index'e 1988 değerini atar.
            //ilkListem.InsertRange(2, araListe);


            //// Veriye Ulaşma
            //Console.WriteLine(ilkListem[0]);
            //Console.WriteLine(ilkListem[1]);
            //Console.WriteLine(sehirler[3]);

            //foreach (var item in ilkListem)
            //{
            //    Console.WriteLine(item);
            //}

            //// Temizleme
            //ilkListem.Clear();
            //foreach (var item in ilkListem)
            //{
            //    Console.WriteLine(item);
            //}


            //// Listedeki toplam eleman sayısını bulma
            //Console.WriteLine(sehirler.Count);

            //// Listede var mı?
            //bool sivasCheck = sehirler.Contains("Sivas");
            //Console.WriteLine(sivasCheck);

            //if (sivasCheck == false)
            //    sehirler.Insert(1, "Sivas");

            //// Listeden Silme
            //sehirler.Remove("Manisa");
            //foreach (var sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}

            //sehirler.RemoveAt(2); // 2. indexi sil.



            //

            /*
            Method  ------------ 	Usage
            Add :	Adds an element at the end of a List<T>.
            AddRange :	Adds elements of the specified collection at the end of a List<T>.
            BinarySearch :	Search the element and returns an index of the element.
            Clear :	Removes all the elements from a List<T>.
            Contains :	Checks whether the specified element exists or not in a List<T>.
            Find :	Finds the first element based on the specified predicate function.
            Foreach :	Iterates through a List<T>.
            Insert 	:Inserts an element at the specified index in a List<T>.
            InsertRange :	Inserts elements of another collection at the specified index.
            Remove :	Removes the first occurrence of the specified element.
            RemoveAt :	Removes the element at the specified index.
            RemoveRange :	Removes all the elements that match the supplied predicate function.
            Sort :	Sorts all the elements.
            TrimExcess :	Sets the capacity to the actual number of elements.
            TrueForAll :	Determines whether every element in the List<T> matches the conditions defined by the specified predicate. 
            */




            // SORU:# 1-10 arasında rastgele 5'er sayı üretip iki listeye atan ve daha sonra listenin elemanlarından 
            //# iki listede ortak olmayanları başka bir listeye atarak ekrana yazdıran program.
            //# Örn: l1 = [11,22,33,44,55] l2 = [55,66,77,88,99]  l3 = [11,22,33,44,66,77,88,99]
            // CEVAP
            //List<int> liste1 = new List<int>();
            //List<int> liste2 = new List<int>();
            //List<int> listeFark = new List<int>();
            //Random rnd = new Random();

            //// Listelere sayı üretip ekledik.
            //Console.Write("Liste1:");

            //for (int i = 0; i < 5; i++)
            //{
            //    int sayi = rnd.Next(1, 10);
            //    liste1.Add(sayi);
            //    Console.Write(sayi + "  ");
            //}
            //Console.WriteLine();
            //Console.Write("Liste2:");

            //for (int i = 0; i < 5; i++)
            //{
            //    int sayi = rnd.Next(1, 10);
            //    liste2.Add(sayi);
            //    Console.Write(sayi + "  ");
            //}
            //Console.WriteLine();
            //// Farkları ekledik.
            //foreach (var eleman in liste1)
            //{
            //    if (liste2.Contains(eleman) == false)
            //        listeFark.Add(eleman);
            //}
            //foreach (var eleman in liste2)
            //{
            //    if (liste1.Contains(eleman) == false)
            //        listeFark.Add(eleman);
            //}
            //Console.Write("Farklar: ");
            //for (int i = 0; i < listeFark.Count; i++)
            //{
            //    Console.Write(listeFark[i] + " ");
            //}



            // 1-20 arasında 15 sayı üretip bir listeye atın.
            // Kullanıcıdan bir tahmin alıp. Listede olup olmadığına bakın.
            // Listede var ise index numarasını ekrana yazdırın.

            //List<int> liste15 = new List<int>();
            //Random rnd = new Random();
            //for (int i = 0; i < 15; i++)
            //{
            //    liste15.Add(rnd.Next(1, 20));
            //}
            //Console.Write("tahmininiz : ");
            //int tahmin = Convert.ToInt32(Console.ReadLine());

            //if(liste15.Contains(tahmin))
            //    Console.WriteLine($"{tahmin} sayısının listedeki indeksi: {liste15.IndexOf(tahmin)}");


            // 0-255 arasında 1 sayı üretin .
            // Kullanıcıdan 15 karakter alıp bir listeye atın.
            // Programın sonunda kullanıcı karakteri bulursa. Tebrik etsin. Ve karakteri ekranda göstersin.
            // Bulamazsa girdiği karakterler arasından üretline karaktere en yakın olanı ve farkını yazsın.

            Random rnd = new Random();
            int rastGele = Convert.ToByte(rnd.Next(0, 255));
            Console.WriteLine($"Üretilen : {rastGele}/{Convert.ToChar(rastGele)}");

            int enYakinTahmin = 255;

            List<int> tahminler = new List<int>();
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Tahmin:");
                string k = Console.ReadLine();
                Console.Write(k + " : ");
                int kInt = Convert.ToInt32(k[0]);
                tahminler.Add(kInt);
                Console.WriteLine(kInt);
            }

            foreach (var tahmin in tahminler)
            {
                if (tahmin == rastGele)
                {
                    Console.WriteLine("Tebrikler Buldunuz !");
                    char cTahmin = Convert.ToChar(tahmin);
                    enYakinTahmin = 0;
                    break;

                }
                else
                {
                    int fark = Math.Abs((rastGele - tahmin)); // Mutlak değer aldık.
                    if (fark < enYakinTahmin)
                        enYakinTahmin = (byte)fark;
                }
            }
            if (enYakinTahmin != 0)
                Console.WriteLine($"Malesef bulamadınız!\n Rastgele karakter/ ASCII kodu : {Convert.ToChar(rastGele)} /{rastGele} En yakın tahmininiz : {Convert.ToChar(enYakinTahmin)}/{enYakinTahmin} ");



        }
    }
}
