using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimUygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            Alman kisi = new Alman();
            kisi.Ad = "Thomas";
            kisi.Soyad = "Müller";
            Console.WriteLine(kisi.Ad+" "+kisi.Soyad+" şöyle dedi.");
            kisi.Selamlasma();

            Turk kisi2 = new Turk();
            kisi2.Ad = "Gamze";
            kisi2.Soyad = "Kural";
            Console.WriteLine(kisi2.Ad +" "+ kisi2.Soyad + " şöyle dedi.");
            kisi2.Selamlasma();

            Fasli kisi3 = new Fasli();
            kisi3.Ad = "Maryam";
            kisi3.Soyad = "Abdollah";
            Console.WriteLine(kisi3.Ad +" "+ kisi3.Soyad + " şöyle dedi.");
            kisi3.Selamlasma();

            Ingiliz kisi4 = new Ingiliz();
            kisi4.Ad = "Jenifer";
            kisi4.Soyad = "Lopez";
            Console.WriteLine(kisi4.Ad +" "+ kisi4.Soyad + " şöyle dedi.");
            kisi4.Selamlasma();

            Console.ReadKey();
        }
    }
}
