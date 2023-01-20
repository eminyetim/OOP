using System;

public class Bitki : Canli
{
    public void Fotosentez()
    {
        System.Console.WriteLine("Fotosentez işlemi başarili");
    }
}

public class TohumluBitkiler : Bitki
{
    public void TohumluCogalma()
    {
        System.Console.WriteLine("Tohumlu üreme basarili");
    }
}

public class TohumsuzBitkiler : Bitki
{
    public void SporlaCogalma()
    {
        System.Console.WriteLine("Sporla cogalma basarili .");
    }

    
    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();
        System.Console.WriteLine("Bitkiler Güneşe Yönelinir.");
    }
}