using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            ////double number;

            ////number = 4.85;

            ////Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("Elma Kg Fiyat : " + " " + applePrice + " " + "TL");
            //Console.WriteLine("Portakal Kg Fiyat : " + " " + orangePrice + " " + "TL");
            //Console.WriteLine("Çilek Kg Fiyat : " + " " + strawberryPrice + " " + "TL");
            //Console.WriteLine("Patates Kg Fiyat : " + " " + potatoPrice + " " + "TL");
            //Console.WriteLine("Domates Kg Fiyat : " + " " + tomatoPrice + " " + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Alınan Ürün : Elma--" + " " + "Birim Fiyatı :" + " " + applePrice + " " + "--Gramaj :" + " " + appleGram + " " + "Toplam Tutar :" + " " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün : Portakal--" + " " + "Birim Fiyatı :" + " " + orangePrice + " " + "--Gramaj :" + " " + orangeGram + " " + "Toplam Tutar :" + " " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün : Çilek--" + " " + "Birim Fiyatı :" + " " + strawberryPrice + " " + "--Gramaj :" + " " + strawberryGram + " " + "Toplam Tutar :" + " " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün : Patates--" + " " + "Birim Fiyatı :" + " " + potatoPrice + " " + "--Gramaj :" + " " + potatoGram + " " + "Toplam Tutar :" + " " + potatoTotalPrice);

            //Console.WriteLine("Alınan Ürün : Domates--" + " " + "Birim Fiyatı :" + " " + tomatoPrice + " " + "--Gramaj :" + " " + tomatoGram + " " + "Toplam Tutar :" + " " + tomatoTotalPrice);

            //Console.WriteLine();

            //Console.WriteLine("Ödenecek Toplam Tutar : " + " " + totalPrice);


            #endregion

            #region Char Değişkenler

            //char symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı :");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı :");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi :");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi :");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş :");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No :");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------");
            //Console.WriteLine("Yolcu TC Kimlik No :" + " " + passengerIdentityNumber + "Yolcu Ad Soyad : " +  passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);

            #endregion

            #region Kalvyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1250;
            //computerPrice = 21400;
            //chairPrice = 6800;
            //tvPrice = 14500;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız TV Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;

            //Console.WriteLine("Ödenecek Toplam tutar : " + " " + totalPrice + "TL");

            #endregion

            #region Kalvyeden Double Girişleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Litfen 1. Sınav Notunu Giriniz :");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Litfen 2. Sınav Notunu Giriniz :");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Litfen 3. Sınav Notunu Giriniz :");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız :" + " " + result);

            #endregion

            #region Klavyeden Karakter Girişi

            //char gender;

            //Console.Write("Lütfen Cinsiyet Seçiniz..");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet:" + " " + gender);

            #endregion
            Console.Read();
        }
    }
}
