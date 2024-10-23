﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //For (x;y;x)
            //x : Başlangıç;
            //y : Bitiş;
            //z : Artış - azalış

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("ZEO");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+= 3)
            //{
            //    Console.WriteLine(i);
            //}   

            //Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz adedi giriniz");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları


            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 0; i <= 10; i++) 
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine(totalValue);

            //int count = 0;

            //for (int i = 1; i < 50; i++)
            //{
            //    if( i % 7 == 0 )
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);



            #endregion

            #region Örnek
            //Bir bakteri türü her saat sonunda kendini 2ye çoğaltıyor. Başlangıçta 1 adet bakteri var, 24 saat sonra kaç bakteri olur ? 

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda :" + " " + bacterium);
            //}

            #endregion

            #region while döngüsü

            //while(şart)
            //{
            //işlemler
            //}

            //int i = 1;
            //while(i <= 10)
            //{
            //    Console.WriteLine("ZEO");
            //    i++;
            //}

            //int i = 1;

            //while(i <= 10)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek sınav sorusu
            //Klavyeden girilen 3basamaklı sayının basamakları toplamını hesaplayan kodu

            //Console.WriteLine("3 Basamaklı bir sayı giriniz");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds, sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;

            //Console.WriteLine(hundreds + "+" + tens + "+" + ones);
            //sum = ones + tens + hundreds;
            //Console.WriteLine(number + " " + "Sayısının basamaklar toplamı:" + " " + sum);
            


            #endregion

            Console.Read();
        }
    }
}
