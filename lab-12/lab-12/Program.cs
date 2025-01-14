using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

public struct authorParam
{
    public string id;
    public double book;
    public int year;
}

// using(SomeDisposableClass someDisposableObject = new SomeDisposableClass())
// {
// someDisposableObject.DoTheJob();
// }

// Jest to implementacja wzorca Dispose 
// w języku C# i służy do zarządzania zasobami, które wymagają zwolnienia 
// po ich użyciu, takimi jak pamięć, uchwyty plików, połączenia sieciowe, uchwyty do baz danych itp.

// class Program
// {
//     static void Main(string[] args)
//     {

//         List<authorParam> mAuthors = new List<authorParam>();
//         mAuthors.Add(new authorParam { id = "A1", book = 10.5, year = 2000 });
//         mAuthors.Add(new authorParam { id = "A2", book = 12.3, year = 2010 });
//         mAuthors.Add(new authorParam { id = "A3", book = 15.0, year = 2015 });

//         // mAuthors[1].year = 2020;

//         // Cannot modify the return value of 'List<authorParam>.this[int]' because it is not a variable
//     }
// }

// List values = new List(){"Ala ", "ma ", "kota ", "!"};
// string output = string.Empty;
// foreach (var value in values)
// {
//     output += value; //  ???
// }

// output bedzie zawierał "Ala ma kota!"



namespace ConsoleApp1
{
    class Program
    {
        static Point point1;
        static Pen pen1;
        static void Main(string[] args)
        {
            Console.WriteLine(pen1 == null); // zwraca True
            Console.WriteLine(point1 == null); // zwraca False
            // w celu naprawienia trzeba uzyc nullable type
            // static Point? point1;
            Console.ReadKey();
        }
    }
}

// catch (SomeException ex)
// {
//     toLog.log(ex);
//     throw ex;
// }

// catch (SomeException ex)
// {
//     logger.log(ex);
//     throw;
// }

// Drugi przyklad zachowuje informacje o wyjatku przez co to ulatwia 
// debuggowanie kodu


// var track = (Track)car;
// var track = car as Track;

// Metoda car as Track jest bezpieczniejsza, ponieważ nie powoduje 
// wyjątków i zwraca null w przypadku niezgodności typów, podczas gdy 
// (Track)car wymusza rzutowanie, ale może rzucić wyjątek InvalidCastException w przypadku błędu.

class Program
{
    private static IEnumerable<string> _numbers = new[] { "1", "2", "3", "4" };
    static void Main(string[] args)
    {
        Console.WriteLine("Classic:");
        foreach (var fruit in GetFruits())
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine("\r\nYield return:");
        foreach (var fruit in GetFruitsWithYield())
        {
            Console.WriteLine(fruit);
        }
    }
private static IEnumerable<string> GetFruits()
{
    var result = new List<string>();
    foreach (var num in _numbers)
    {
        if (num == "3" || num == "4")
            {
            result.Add(num);
            }
    }
    return result;
}
private static IEnumerable<string> GetFruitsWithYield()
{
    foreach (var num in _numbers)
    {
        if (num == "3" || num == "4")
            {
                yield return num;
            }
    }
}
}

// Yield pozwala na zaoszczedzenie pamięci poprzez zwracanie 
// wartosci jeden po drugim. w tym przypadku nie jest potrzebna
// tablica result tylko wartosci sa odrazu zwracane. Jest to przydatne w przypadku
// koniecznosci oszczednosci pamieci oraz przy bardzo duzych zbiorach danych.