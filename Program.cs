using System;

namespace araçkiralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Araçları oluşturuyoruz, ama ekrana yazdırmıyoruz
            Araba araba = new Araba();
            araba.AracPlakasi = "34 FB 1907";
            araba.AracMarkası = "Ford";
            araba.AracModeli = "Mustang";

            Otobus otobus = new Otobus();
            otobus.AracPlakasi = "53 jkl 2340";
            otobus.AracMarkası = "Man";
            otobus.AracModeli = "Lion";

            Motosiklet motosiklet = new Motosiklet();
            motosiklet.AracPlakasi = "34 acar 45";
            motosiklet.AracMarkası = "Honda";
            motosiklet.AracModeli = "Cl259";

            Console.WriteLine("-----KİRALIK ARAÇ CAFER-----");

            // Kullanıcıdan seçim alıyoruz
            Console.WriteLine("Hangi aracın bilgisini görmek istiyorsunuz? (Araba/Otobus/Motosiklet)");
            string secim = Console.ReadLine();

            // Sadece seçilen aracın bilgisi gösterilecek
            if (secim.ToLower() == "araba")
            {
                Console.WriteLine(araba.BilgiYaz());
            }
            else if (secim.ToLower() == "otobus")
            {
                Console.WriteLine(otobus.BilgiYaz());
            }
            else if (secim.ToLower() == "motosiklet")
            {
                Console.WriteLine(motosiklet.BilgiYaz());
            }
            else
            {
                Console.WriteLine("Geçersiz seçim girdiniz lütfen tekrar deneyin");
            }

            Console.WriteLine("Çıkmak için Enter'a basın...");
            Console.ReadLine();
        }
    }

    public abstract class AracKiralama
    {
        public string AracPlakasi { get; set; }
        public string AracModeli { get; set; }
        public string AracMarkası { get; set; }

        public abstract string BilgiYaz();
    }

    public class Araba : AracKiralama
    {
        public override string BilgiYaz()
        {
            return $"Araç bilgisi: Marka: {AracMarkası}, Model: {AracModeli}, Plaka: {AracPlakasi}";
        }
    }

    public class Otobus : AracKiralama
    {
        public override string BilgiYaz()
        {
            return $"Araç bilgisi: Marka: {AracMarkası}, Model: {AracModeli}, Plaka: {AracPlakasi}";
        }
    }

    public class Motosiklet : AracKiralama
    {
        public override string BilgiYaz()
        {
            return $"Araç bilgisi: Marka: {AracMarkası}, Model: {AracModeli}, Plaka: {AracPlakasi}";
        }
    }
}
