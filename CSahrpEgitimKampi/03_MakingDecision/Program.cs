using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else 1

            //Console.WriteLine("Lütfen Şifreyi Giriniz :");
            //string password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            #endregion


            #region If Else 2

            //string capital, country;
            //Console.WriteLine("Başkenti Giriniz.. :");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Giriniz.. :");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}

            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}

            #endregion

            #region If Else 3

            //Console.WriteLine("Sayıyı Giriniz..");
            //int number = int.Parse(Console.ReadLine());         

            //if(number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            #endregion

            #region If Else 4

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav1 :");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2 :");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3 :");
            //exam3 = int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların Ortalaması : " + " " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}

            //if(average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}

            //if(average > 84 & average <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            #endregion

            #region If Else 5

            //string city;
            //Console.WriteLine("Şehir Girişi Yapınız..");
            //city = Console.ReadLine();

            //if(city == "adana" | city == "ankara" | city == "trabzın")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}

            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}
            #endregion

            #region If Else 6

            //Console.WriteLine("Lütfen kullanıcı adını giriniz");
            //string username = Console.ReadLine();

            //if(username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kontrol edilemez");
            //}

            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}
            #endregion

            #region Mod İşlemleri 1

            //int number = 26;

            //int result = number % 5;

            //Console.WriteLine(result);

            #endregion

            #region Mod İşlemleri 2

            //Console.WriteLine("1. Sayıyı Girin ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sayıyı Girin ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. Sayının 2. Sayıya Bölümünden Kalan :" + " " + result);
            #endregion

            #region Mod İşlemleri 3

            //Console.WriteLine("Lütfen sayıyı girin");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}

            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}
            #endregion

            #region Mod İşlemleri 4

            //char team;
            //Console.WriteLine("Lütfen Takım Sembolünü Giriniz");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("--------------------------");

            //string menuItem;
            //Console.WriteLine("Detayını Görmek İstediğiniz Menu Seçimi");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasülye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("------------ Ana Yemekler --------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin Çorbası");
            //    Console.WriteLine("------------ Çorbalar --------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Pizzalar --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Margaritha");
            //    Console.WriteLine("3- Tavuklu Pizza");
            //    Console.WriteLine("------------ Pizzalar --------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("------------ İçecekler --------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Triliçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine("------------ Tatlılar --------------");
            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay Girişi Yapınız");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default : Console.WriteLine("Hatalı Giriş"); break;
            //}


            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("1. Sayıyı Giriniz");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sayıyı Giriniz");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam :" + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark :" + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım :" + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm :" + result);
            //        break;

            //        default: Console.WriteLine("Hatalı Giriş"); break;
            //}

            #endregion


            Console.Read();
        }
    }
}
