using System;

namespace OOPLogin
{
    class Program
    {
        public  static void Main()
        {
            System.Console.WriteLine("** Ordek **");
            Ordek h1 = new Ordek();
            h1.beslenme();
            h1.Bosaltim();
            h1.Solunum();
            h1.SürüHalindeHareket();
            h1.Yuzme();

            System.Console.WriteLine("** Tohumsuz Bitki **");
            TohumsuzBitkiler b1  = new();
            b1.beslenme();
            b1.Bosaltim();
            b1.Solunum();
            b1.Fotosentez();
            b1.SporlaCogalma();


            
        }
    }
}
