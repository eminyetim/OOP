using System;


public /*sield*/ class Canli // sield anahtar kelimesi miras alınmayı engeller.
{
    public void beslenme()
    {
        System.Console.WriteLine("Canlilar Beslenir.");
    }
    public void Solunum()
    {
        System.Console.WriteLine("Canlilar Solunum Yapar.");
    }
    public void Bosaltim()
    {
        System.Console.WriteLine("Canlilar Bosaltim Yapar.");
    }

    public virtual void UyaranlaraTepki()
    {
        System.Console.WriteLine("Canlilar uyarilara tepki verir.");
    }
}