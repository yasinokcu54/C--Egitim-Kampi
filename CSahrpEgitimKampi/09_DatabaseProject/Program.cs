using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Ado.net

			Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
			Console.WriteLine();
			Console.WriteLine();

			string tableNumber;
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("1 - Kategoriler");
			Console.WriteLine("2 - Ürünler");
			Console.WriteLine("3 - Siparişler");
			Console.WriteLine("4 - Çıkış Yap");
			Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz: ");
			tableNumber = Console.ReadLine();
			Console.WriteLine("--------------------------------------------");


			SqlConnection connection = new SqlConnection("Data Source=DESKTOP-67JOUT2\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

			SqlCommand command = new SqlCommand("select * from Tbl_Category", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			connection.Close();

			foreach (DataRow row in dataTable.Rows)
			{
				foreach (var item in row.ItemArray)
				{
					Console.Write(item);
				}
				Console.WriteLine();
			}

			Console.Read();
		}
	}
}
