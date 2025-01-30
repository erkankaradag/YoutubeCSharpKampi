using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            // geriye değer döndürmeyen metot


            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ahmet Veli");
            //    Console.WriteLine("Cemal Kara");
            //    Console.WriteLine("Arif Zınar");
            //}
            //CustomerList();

            //void sum()
            //{
            //    int x = 1; int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();



            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string Surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + Surname);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ali", "Cenk");



            #endregion

            #region Geriye değer döndürmeyen Int parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye değer döndüren string parametreli metotlar


            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke:" + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine( CountryCard(x, y, z) );





            #endregion

            #region Geriye değer döndüren Int parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region Örnek uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + "isimli öğrenci sınavı geçti " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + "isimli öğrenci sınavı geçemedi " + "Ortalama:" + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali", 24, 41, 55));
            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));



            #endregion

            Console.Read();
        }
    }
}
