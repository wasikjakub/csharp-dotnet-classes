using System;
using System.Collections.Generic;

// public interface ICepikData
// {
//     string GetCepikData();
// }

// public interface IStatData
// {
//     string GetStatData();
// }

// public interface IPoliceData
// {
//     string GetPoliceData();
// }

// public class Auto : ICepikData, IStatData, IPoliceData
// {
//     public string TypPojazdu { get; set; }
//     public string Marka { get; set; }
//     public double Pojemnosc { get; set; }
//     public int LiczbaMiejsc { get; set; }
//     public string VIN { get; set; }
//     public string NrRejestracyjny { get; set; }
//     public int RokProdukcji { get; set; }
//     public string Kolor { get; set; }
//     public string PolisaNr { get; set; }

//     public string ImieINazwisko { get; set; }
//     public string AdresZamieszkania { get; set; }
//     public string PESEL { get; set; }
//     public string NrPrawaJazdy { get; set; }
//     public DateTime DataUzyskaniaPrawaJazdy { get; set; }
//     public int RokZakupu { get; set; }
//     public int LiczbaPunktowKarnych { get; set; }

//     public string GetCepikData()
//     {
//         return $"Pojazd: {TypPojazdu}, Marka: {Marka}, VIN: {VIN}, Właściciel: {ImieINazwisko}, Adres: {AdresZamieszkania}";
//     }

//     public string GetStatData()
//     {
//         return $"Typ Pojazdu: {TypPojazdu}, Marka: {Marka}, Rok Produkcji: {RokProdukcji}, Kolor: {Kolor}";
//     }

//     public string GetPoliceData()
//     {
//         return $"Pojazd: {TypPojazdu}, VIN: {VIN}, Właściciel: {ImieINazwisko}, Punkty Karne: {LiczbaPunktowKarnych}";
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Auto auto1 = new Auto
//         {
//             TypPojazdu = "Samochód osobowy",
//             Marka = "Toyota",
//             Pojemnosc = 1.8,
//             LiczbaMiejsc = 5,
//             VIN = "VIN123456789",
//             NrRejestracyjny = "ABC1234",
//             RokProdukcji = 2020,
//             Kolor = "Czarny",
//             PolisaNr = "POLISA001",
//             ImieINazwisko = "Jan Kowalski",
//             AdresZamieszkania = "Warszawa, ul. Zielona 5",
//             PESEL = "12345678901",
//             NrPrawaJazdy = "PRAWO001",
//             DataUzyskaniaPrawaJazdy = new DateTime(2015, 5, 10),
//             RokZakupu = 2021,
//             LiczbaPunktowKarnych = 2
//         };

//         Auto auto2 = new Auto
//         {
//             TypPojazdu = "Motocykl",
//             Marka = "Honda",
//             Pojemnosc = 0.6,
//             LiczbaMiejsc = 2,
//             VIN = "VIN987654321",
//             NrRejestracyjny = "XYZ5678",
//             RokProdukcji = 2018,
//             Kolor = "Czerwony",
//             PolisaNr = "POLISA002",
//             ImieINazwisko = "Anna Nowak",
//             AdresZamieszkania = "Kraków, ul. Kwiatowa 10",
//             PESEL = "10987654321",
//             NrPrawaJazdy = "PRAWO002",
//             DataUzyskaniaPrawaJazdy = new DateTime(2017, 8, 20),
//             RokZakupu = 2019,
//             LiczbaPunktowKarnych = 0
//         };

//         List<ICepikData> cepikList = new List<ICepikData> { auto1, auto2 };
//         List<IStatData> statList = new List<IStatData> { auto1, auto2 };
//         List<IPoliceData> policeList = new List<IPoliceData> { auto1, auto2 };

//         Console.WriteLine("Dane CEPiK:");
//         foreach (var item in cepikList)
//         {
//             Console.WriteLine(item.GetCepikData());
//         }

//         Console.WriteLine("\nDane statystyczne:");
//         foreach (var item in statList)
//         {
//             Console.WriteLine(item.GetStatData());
//         }

//         Console.WriteLine("\nDane policyjne:");
//         foreach (var item in policeList)
//         {
//             Console.WriteLine(item.GetPoliceData());
//         }
//     }
// }

// CW 2

// public class Point
// {
//     public int x, y;

//     public Point(int p1, int p2)
//     {
//         x = p1;
//         y = p2;
//     }

//     public static Point operator +(Point p1, Point p2)
//     {
//         return new Point(p1.x + p2.x, p1.y + p2.y);
//     }

//     public static bool operator true(Point p)
//     {
//         return p.x != 0 || p.y != 0;
//     }

//     public static bool operator false(Point p)
//     {
//         return p.x == 0 && p.y == 0;
//     }

//     public static bool operator ==(Point p1, Point p2)
//     {
//         return p1.x == p2.x && p1.y == p2.y;
//     }

//     public static bool operator !=(Point p1, Point p2)
//     {
//         return !(p1 == p2);
//     }

//     public static bool operator <(Point p1, Point p2)
//     {
//         return p1.x < p2.x && p1.y < p2.y;
//     }

//     public static bool operator <=(Point p1, Point p2)
//     {
//         return p1.x <= p2.x && p1.y <= p2.y;
//     }

//     public static bool operator >(Point p1, Point p2)
//     {
//         return p2 < p1;
//     }

//     public static bool operator >=(Point p1, Point p2)
//     {
//         return p2 <= p1;
//     }

//     public static Point operator ++(Point p)
//     {
//         p.x++;
//         p.y++;
//         return p;
//     }

//     public static Point operator --(Point p)
//     {
//         p.x--;
//         p.y--;
//         return p;
//     }

//     public static implicit operator Point(int value)
//     {
//         return new Point(value, 0);
//     }

//     public static explicit operator int(Point p)
//     {
//         return p.x + p.y;
//     }

//     public override bool Equals(object obj)
//     {
//         if (obj is Point p)
//         {
//             return this == p;
//         }
//         return false;
//     }

//     public override int GetHashCode()
//     {
//         return HashCode.Combine(x, y);
//     }

//     // public static Point operator +=(Point p1, Point p2) // error: Overloadable binary operator expected
//     // {
//     //     p1.x += p2.x;
//     //     p1.y += p2.y;
//     //     return p1;
//     // }

//     public override string ToString()
//     {
//         return $"({x}, {y})";
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Point p1 = new Point(2, 3);
//         Point p2 = new Point(4, 5);
//         // Point p3 = p1 + p2; // Error: Operator '+' is ambiguous on operands of type 'Point' and 'Point'

//         Point p0 = new Point(0, 0);
//         Console.WriteLine($"p0 is true? {(p0 ? "Yes" : "No")}");

//         Console.WriteLine($"p1 == p2? {p1 == p2}");
//         Point p4 = new Point(2, 3);
//         Console.WriteLine($"p1 == p4? {p1 == p4}");

//         Console.WriteLine($"p1 < p2? {p1 < p2}");
//         Console.WriteLine($"p1 <= p4? {p1 <= p4}");

//         Console.WriteLine($"p1 before ++: {p1}");
//         p1++;
//         Console.WriteLine($"p1 after ++: {p1}");
//         p1--;
//         Console.WriteLine($"p1 after --: {p1}");

//         Point p5 = 5;
//         Console.WriteLine($"p5: {p5}");

//         Point p6 = new Point(2, 5);
//         int suma = (int)p6;
//         Console.WriteLine($"Suma współrzędnych p6: {suma}");

//         //p1 += p2; // Error: Operator '+=' is ambiguous on operands of type 'Point' and 'Point'
//         Console.WriteLine($"p1 += p2: {p1}");
//     }
// }

// CW 3

public class Calculator
{
    public delegate void Operation(int a, int b);

    public static void Add(int a, int b)
    {
        Console.WriteLine($"Dodawanie: {a} + {b} = {a + b}");
    }

    public static void Subtract(int a, int b)
    {
        Console.WriteLine($"Odejmowanie: {a} - {b} = {a - b}");
    }

    public static void Multiply(int a, int b)
    {
        Console.WriteLine($"Mnożenie: {a} * {b} = {a * b}");
    }

    public static void Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Dzielenie: Błąd - dzielenie przez zero!");
        }
        else
        {
            Console.WriteLine($"Dzielenie: {a} / {b} = {(double)a / b}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator.Operation operation;

        operation = Calculator.Add;
        operation(10, 5);

        operation = Calculator.Subtract;
        operation(10, 5);

        operation = Calculator.Multiply;
        operation(10, 5);

        operation = Calculator.Divide;
        operation(10, 5);

        operation = Calculator.Add;
        operation += Calculator.Multiply;
        operation += Calculator.Divide;

        Console.WriteLine("\nWielokrotne przypisanie funkcji do delegata:");
        operation(10, 5);
    }
}
