using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            // ()
            //Belirli işleri tekrardan kaçınmak için metotlaştırıp, gerekli yerde çağırma
            //Geriye değer döndürmeyen
            //Costumer --> Listele, ekle, sil, güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string Name, string SurName)
            //{
            //    Console.WriteLine("Müşteri: " +  Name + " " + SurName);
            //}

            //CustomerCard("Murat", "Uzun");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;

            //    Console.WriteLine(result);
            //}

            //Sum(25, 65, 48);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //Console.WriteLine(CustomerName());

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " -Başkent: " + capital + " -Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Renklerini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine("Türkiye", "Ankara", "Kırmızı-Beyaz");



            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,  int number2)
            //{
            //    int result = number1 + number2;

            //    return result;
            //}

            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(56, 28));
            //Console.WriteLine(Sum(45, 52));
            //Console.WriteLine(Sum(38, 79));
            //Console.WriteLine(Sum(125, 122));

            #endregion

            #region Örnek

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if(result >= 50)
                {
                    return student +  " İsimli Öğrenci dersi geçti" + " Ortalaması: " + result;
                }
                else
                {
                    return student + " İsimli Öğrenci dersten kaldı" + " Ortalaması: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 45, 65, 50));
            Console.WriteLine(ExamResult("Merve", 30, 65, 20));

            #endregion
            Console.Read();
        }
    }
}
