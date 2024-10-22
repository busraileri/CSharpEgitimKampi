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
			//Ado.Net

			Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi ***** ");
			Console.WriteLine();
			Console.WriteLine();

			string tableNumber;

			Console.WriteLine("--------------------------------------");
			Console.WriteLine("1-Kategoriler");
			Console.WriteLine("2-Ürünler");
			Console.WriteLine("3-Siparişlerim");
			Console.WriteLine("4-Çıkış Yap");
			Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
			tableNumber = Console.ReadLine();
			Console.WriteLine("--------------------------------------");

			//sınıf - nesne
			//baglantı oluşturma
			SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UCJURK5\\SQLMSI;initial Catalog=EgitimKampiDb;integrated Security=true");
			connection.Open();

			SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command); //c# kodları ile sqldb arası köprü sınıfı
			DataTable dataTable = new DataTable(); //datatable nesne örneği verileri belleğe geçici (ram) belleğe almamı sağlayacak
			adapter.Fill(dataTable);
			connection.Close();

			foreach (DataRow row in dataTable.Rows)
			{
				foreach(var item in row.ItemArray)
				{
					Console.Write(item.ToString());
				}
				Console.WriteLine();
			}
		





			Console.Read();
		}
	}
}
