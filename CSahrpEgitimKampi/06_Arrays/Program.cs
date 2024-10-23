using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2,4,6,8..
            //sarı,kırmızı,mavi,turuncu...
            //adana,istanbul,bursa,izmir...

            // DeğişkenTürü [] DiziAdı = new DeğişenTürü[ElemanSayısı]

            //string[] colors = new string[5];
            //colors[0] = "sarı";
            //colors[1] = "kırmızı";
            //colors[2] = "Beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Adana";
            //cities[1] = "Bursa";
            //cities[2] = "İzmir";
            //cities[3] = "Ankara";
            //cities[4] = "İstanbul";

            //Console.WriteLine(cities[4]);


            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[5] = 10;
            //numbers[8] = 70;

            //Console.WriteLine(numbers[7]);

            //string[] cities = { "Prag", "Milano", "Atina", "Ankara" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm elemanları listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yaşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArrays = { 47, 85, 95, 41, 25, 789, 86, 100 };

            //int maxNumber = myArrays[0];

            //for (int i = 1; i < myArrays.Length; i++)
            //{
            //    if (myArrays[i] > maxNumber)
            //    {
            //        maxNumber = myArrays[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "mehmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);


            //Sort metodu küçükten büyüğe sıralar
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 25 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //reverse metodu diziyi tersten yazar
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 25 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metodlar

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı:" + " " + numbers.Max() + " " + "Dizinin en küçük elemanı:" + " " + numbers.Min());



            #endregion

            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = {10, 20, 30, 40 ,50};
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine("Çift sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("Tek sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
;
            #endregion
            Console.Read();
        }
    }
}
