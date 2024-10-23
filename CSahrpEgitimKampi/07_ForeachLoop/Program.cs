using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Foreach(1;2;3;4)

            //1 Değişken Türü
            //2 Değişken Adı
            //3 In
            //4 Liste, Koleksiyon, Dizi

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 23, 35, 45, 201, 7852, 10358 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 23, 35, 45, 201, 7852, 10358 };

            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 23, 35, 45, 201, 7852, 10358 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //string word = "Merhaba";

            //foreach (char c in word) 
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("C# Eğitim Kampı Sınav Uygulaması");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("-------------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var? :");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");

            //Öğrenci isimleri ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin adını giriniz..");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 tane sınav sonucu alalım

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //Notları topluyoruz
                }
                Console.WriteLine();

                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması {studentExamAvg[i]}");

                //Öğrencilerin ortalamasını ve geçip kalma durumlarını görelim
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı");
                }

                Console.WriteLine("-----------------------------------------------------");
            }




            #endregion
            Console.Read();
        }
    }
}
