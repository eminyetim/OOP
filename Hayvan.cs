using System;

public class Hayvan : Canli
{
    public void SürüHalindeHareket()
    {
        System.Console.WriteLine("Hayvanlar sürü halinde hareket eder.");
    }
}

public class Kus : Hayvan
{
    public void Ucmak()
    {
        System.Console.WriteLine("Uçma işlemi başarili");
    }
} 

public class Ordek:Hayvan
{
    public void Yuzme()
    {
        System.Console.WriteLine("Yüzme islemi basarili");
    }
    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();
        System.Console.WriteLine("Canlilar etkiye tepki verir.");
    }
}
