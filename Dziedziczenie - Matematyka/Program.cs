using System;
using System.Security.Cryptography.X509Certificates;

class Delta
{
    public double a;
    public double b;
   public double c;
   public double delta1;
    public double x1;
    public double x2;
    public double x0;
    public void wczytaj()
    {
        Console.WriteLine("Podaj a: ");
        a = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("a = 0 jest to funkcja liniowa!");
            Environment.Exit(0); // sprawdziłem sobie to w internecie, taka nauka nowych funkcji, że można zakończyć program w dowolnym miejscu, a nie tylko w mainie
        }
        else
        {
            Console.WriteLine("Podaj b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            c = int.Parse(Console.ReadLine());
        }
    }
    public void oblicz()
    {
        delta1 = (b * b) - (4 * a * c);
    }
    public void wyswietl()
    {
        Console.WriteLine($"Delta: {delta1}");
        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");
        Console.WriteLine($"c: {c}");
    }
    static void Main(string[] args)
    {
        Argumenty argumenty = new Argumenty();
        argumenty.wczytaj();
        argumenty.oblicz();
        argumenty.wyswietl();
        argumenty.oblicz1();
        argumenty.wyswietl1();

    }
}



class Argumenty : Delta
{
    public void oblicz1()
    {
        if (delta1 > 0)
        {
            Console.WriteLine("Obliczam dwa miejsca zerowe: ");
            x1 = (-b - Math.Sqrt(delta1)) / (2 * a);
            x2 = (-b + Math.Sqrt(delta1)) / (2 * a);
        }
        else if (delta1 == 0)
        {
            Console.WriteLine("Obliczam jedno miejsce zerowe: ");
            x0 = (-b) / (2 * a);
        }
        else
        {
            Console.WriteLine("Brak miejsc zerowych");

        }
    }
    public void wyswietl1()
    {
        if (delta1 > 0)
        {
            Console.WriteLine($"x1: {x1}");
            Console.WriteLine($"x2: {x2}");
        }
        else if (delta1 == 0)
        {
            Console.WriteLine($"x0: {x0}");
        }
        
        
    }
}
