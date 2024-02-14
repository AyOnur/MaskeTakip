using Business.Concrete;
using Entities.Concrete;
using System.Reflection.Emit;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Degiskenler();
            
            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim:"Engin");
            SelamVer("Ahmet");
            SelamVer("Mehmet");
            SelamVer();

            int sonuc = Topla(5,9);

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;



            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List <string> yeniSehirler1 = new List<string> {"Ankara", "İstanbul","İzmir"};

            yeniSehirler1.Add("Bursa");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();

        }

        static void SelamVer(string isim = "İsimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam = " + sonuc);
            return sonuc; 
        }
        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 1000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Onur";
            string soyad = "Ay";
            int dogumYili = 2000;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.22);
            Console.WriteLine(tutar * 1.22);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int DogumYili { get; set; }

        public long TcNo { get; set;}

    }
}
