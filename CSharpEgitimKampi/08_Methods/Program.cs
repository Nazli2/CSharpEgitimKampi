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

			//Geriye Değer Döndürmeyen Metotlar
			//Customer --> Listele, ekle, sil, güncelle
			//Void

			//void CustomerList()
			//{
			//	Console.WriteLine("Mustafa Kavuşdu");
			//	Console.WriteLine("Nazlı Şahin");
			//	Console.WriteLine("Birsen Durmaz");
			//}

			//CustomerList();
			//CustomerList();
			//CustomerList();
			//CustomerList();

			//void Sum()
			//{
			//	int x = 1;
			//	int y = 2;
			//	int z = x + y;
			//	Console.WriteLine(z);
			//}

			//Sum();

			#endregion

			#region Geriye Değer Döndürmeyen String Parametreli Metotlar

			//void WriteMethod(string customerName)
			//{
			//	Console.WriteLine(customerName);
			//}

			//WriteMethod("Mustafa Kavuşdu");

			//void CustomerCard(string name, string surName)
			//{
			//	Console.WriteLine("Müşteri: " + name + " " + surName);
			//}

			//CustomerCard("Mustafa", "Kavuşdu");
			//CustomerCard("Nazlı", "Şahin");


			#endregion

			#region Geriye Değer Döndürmeyen Int Parametreli Metotlar

			//void Sum(int number1, int number2, int number3)
			//{
			//	int result = number1 + number2 + number3;
			//	Console.WriteLine(result);
			//}

			//Sum(4, 5, 6);

			#endregion

			#region Geriye Değer Döndüren Metotlar

			//string CustomerName()
			//{
			//	return "Mustafa Kavuşdu";
			//}

			//CustomerName();

			//string StudentCard()
			//{
			//	string name = "Mustafa";
			//	string surname = "Kavuşdu";

			//	return name + " " + surname;
			//}

			//Console.WriteLine(StudentCard());

			#endregion

			#region Geriye Değer Döndüren Parametreli Metotlar

			//string CountryCard(string countryName, string capital, string flagColor)
			//{
			//	string cardInfo = "Ülke: " +  countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
			//	return cardInfo;
			//}

			//string x, y, z;
			//Console.Write("Ülke Adını Giriniz: ");
			//x = Console.ReadLine();

			//Console.Write("Başkenti Giriniz: ");
			//y = Console.ReadLine();

			//Console.Write("Bayrak Rengini Giriniz: ");
			//z = Console.ReadLine();

			//Console.WriteLine(CountryCard(x, y, z));

			//Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

			#endregion

			#region Geriye Değer Döndüren Int Parametreli Metotlar

			//int Sum(int number1, int number2)
			//{
			//	int result = number1 + number2;
			//	return result;
			//}

			//Console.WriteLine(Sum(47, 26));
			//Console.WriteLine(Sum(36, 27));
			//Console.WriteLine(Sum(29, 26));
			//Console.WriteLine(Sum(96, 69));

			#endregion

			#region Örnek Uygulama

			//string ExamResult(string student, int exam1, int exam2, int exam3)
			//{
			//	int result = (exam1 + exam2 + exam3) / 3;
			//	if(result >= 50)
			//	{
			//		return student + " isimli öğrenci sınavı geçti " + "Ortalama: " + result; 
			//	}
			//	else
			//	{
			//		return student + " isimli öğrenci başarısız oldu " + "Ortalama: " + result;
			//	}
			//}

			//Console.WriteLine(ExamResult("Mustafa", 95, 85, 100));
			//Console.WriteLine(ExamResult("Nazlı", 35, 45, 27));
			
			#endregion


			Console.Read();
		}
	}
}
