using System;
using System.Security.Cryptography.X509Certificates;

// Ćw. 1
// struct Point2D
// {
//     public double X { get; private set; }
//     public double Y { get; private set; }
//     public Point2D(double x, double y)
//     {
//         X = x;
//         Y = y;
//     }
//     public void Reset()
//     {
//         X = 0;
//         Y = 0;
//     }
//     public void IncrX(double dx)
//     {
//         X += dx;
//     }
//     public void IncrY(double dy)
//     {
//         Y += dy;
//     }
//     public void Print2DPoint()
//     {
//         Console.WriteLine($"Point2D: X = {X}, Y = {Y}");
//     }
//     public double Dist(Point2D other)
//     {
//         double dx = X - other.X;
//         double dy = Y - other.Y;
//         return Math.Sqrt(dx * dx + dy * dy);
//     }
// }

// ĆW 2
// struct Point2D
// {
//     private double X; 
//     private double Y ; 
//     public Point2D()
//     {
//         X = 5;
//         Y = 10;
//     }
//     public override string ToString()
//     {
//         return $"Point2D: X = {X}, Y = {Y}";
//     }
// }



class Program
{
    enum DaysOfWeek
    {
        Poniedzialek = 1,
        Wtorek,
        Sroda,
        Czwartek,
        Piatek,
        Sobota,
        Niedziela
    }

    enum NumberRange
    {
        Small,
        Medium,
        Large
    }
    static void Main(string[] args)
    {
        // CW. 1
        // Point2D[] points = new Point2D[5];
        // int rad = 5;

        // for (int i = 0; i < 4; i++)
        // {
        //     Console.WriteLine($"Podaj współrzędne punktu {i + 1} (środek okręgu):");

        //     Console.Write("X: ");
        //     double x = Convert.ToDouble(Console.ReadLine());

        //     Console.Write("Y: ");
        //     double y = Convert.ToDouble(Console.ReadLine());

        //     points[i] = new Point2D(x, y);
        // }

        // bool found = false;
        // while (!found)
        // {
        //     Console.WriteLine("\nPodaj współrzędne piątego punktu:");
        //     Console.Write("X: ");
        //     double x5 = Convert.ToDouble(Console.ReadLine());

        //     Console.Write("Y: ");
        //     double y5 = Convert.ToDouble(Console.ReadLine());

        //     if (x5 < 0 || y5 < 0)
        //     {
        //         Console.WriteLine("\nWprowadzono ujemną współrzędną. Program zakończony.");
        //         break;
        //     }

        //     Point2D point5 = new Point2D(x5, y5);
        //     double minDistance = double.MaxValue;

        //     for (int i = 0; i < 4; i++)
        //     {
        //         double distance = point5.Dist(points[i]);
        //         if (distance <= rad)
        //         {
        //             Console.WriteLine($"\nPiąty punkt znajduje się wewnątrz okręgu o środku w punkcie {i + 1}.");
        //             found = true;
        //             break;
        //         }
        //         else
        //         {
        //             if (distance < minDistance)
        //             {
        //                 minDistance = distance;
        //             }
        //         }
        //     }

        //     if (!found)
        //     {
        //         Console.WriteLine($"\nPiąty punkt nie znajduje się w żadnym z okręgów.");
        //         Console.WriteLine($"Odległość od najbliższego środka okręgu: {minDistance}");
        //     }
        // }

        // Console.WriteLine("\nWspółrzędne wszystkich punktów:");
        // for (int i = 0; i < 4; i++)
        // {
        //     Console.WriteLine($"Punkt {i + 1} (środek okręgu):");
        //     points[i].Print2DPoint();
        // }

        // Console.WriteLine("\nPunkt 5:");
        // points[4].Print2DPoint();

        // ĆW 2 a
        // Point2D p;
        // Console.WriteLine(p.ToString()); 
        // Output: Use of unassigned local variable 'p'

        // ĆW 2 b
        // Point2D p = new Point2D();
        // Console.WriteLine(p.ToString());  
        // Output: Point2D: X = 0, Y = 0

        // ĆW 2 c
        // Point2D p = new Point2D(); 
        // Console.WriteLine(p.ToString());
        // Output: brak

        // CW 2 d
        // Point2D p = new Point2D();
        // Console.WriteLine(p.ToString()); 
        // Output: Point2D: X = 5, Y = 10

        // ĆW 3
        // int intCount = 0;
        // int floatCount = 0;
        // int stringCount = 0;

        // while (true)
        // {
        //     Console.WriteLine("Wprowadź dane (lub wpisz -1, aby zakończyć): ");
        //     string input = Console.ReadLine();

        //     if (input == "-1")
        //     {
        //         Console.WriteLine("Koniec programu.");
        //         break;
        //     }

        //     if (int.TryParse(input, out int intValue))
        //     {
        //         Console.WriteLine($"Wprowadzono liczbę całkowitą: {intValue}");
        //         intCount++;
        //     }
        //     else if (float.TryParse(input, out float floatValue))
        //     {
        //         Console.WriteLine($"Wprowadzono liczbę zmiennoprzecinkową: {floatValue}");
        //         floatCount++;
        //     }
        //     else
        //     {
        //         Console.WriteLine($"Wprowadzono tekst: {input}");
        //         stringCount++;
        //     }
        // }

        // Console.WriteLine("\nPodsumowanie:");
        // Console.WriteLine($"Liczba wprowadzonych liczb całkowitych: {intCount}");
        // Console.WriteLine($"Liczba wprowadzonych liczb zmiennoprzecinkowych: {floatCount}");
        // Console.WriteLine($"Liczba wprowadzonych tekstów: {stringCount}");

        // ĆW 4a
        // while (true)
        // {
        //     Console.WriteLine("Podaj numer dnia tygodnia (1-7) lub 0, aby zakończyć: ");
        //     string input = Console.ReadLine();

        //     if (int.TryParse(input, out int dayNumber))
        //     {
        //         if (dayNumber == 0)
        //         {
        //             Console.WriteLine("Koniec programu.");
        //             break;
        //         }

        //         if (dayNumber >= 1 && dayNumber <= 7)
        //         {
        //             DaysOfWeek day = (DaysOfWeek)dayNumber;
        //             Console.WriteLine($"Dzień tygodnia to: {day}");
        //         }
        //         else
        //         {
        //             Console.WriteLine("Podano nieprawidłowy numer. Spróbuj ponownie.");
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("Podano nieprawidłową wartość. Wprowadź liczbę.");
        //     }
        // }   


        // // ĆW 4b
        // while (true)
        // {
        //     Console.WriteLine("Podaj liczbę (lub wpisz 'exit', aby zakończyć): ");
        //     string input = Console.ReadLine();

        //     // Sprawdzenie, czy użytkownik chce zakończyć program
        //     if (input.ToLower() == "exit")
        //     {
        //         Console.WriteLine("Koniec programu.");
        //         break;
        //     }

        //     // Próba konwersji wprowadzonego ciągu na liczbę
        //     if (int.TryParse(input, out int number))
        //     {
        //         // Określenie kategorii wielkości liczby za pomocą metody GetSizeCategory
        //         NumberRange size = GetSizeCategory(number);
        //         Console.WriteLine($"Podana liczba to: {size}");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Podano nieprawidłową wartość. Wprowadź liczbę.");
        //     }
        // }
        // static NumberRange GetSizeCategory(int number)
        // {
        //     if (number < 10)
        //     {
        //         return NumberRange.Small;
        //     }
        //     else if (number >= 10 && number <= 99)
        //     {
        //         return NumberRange.Medium;
        //     }
        //     else
        //     {
        //         return NumberRange.Large;
        //     }
        // }

        // ĆW 5
    //     while (true)
    //     {
    //         Console.WriteLine("Podaj jeden znak (lub wpisz 'exit', aby zakończyć): ");
    //         string input = Console.ReadLine();

    //         if (input.ToLower() == "exit")
    //         {
    //             Console.WriteLine("Koniec programu.");
    //             break;
    //         }

    //         if (input.Length == 1)
    //         {
    //             char character = input[0];

    //             if (IsVowel(character))
    //             {
    //                 Console.WriteLine($"Znak '{character}' jest samogłoską.");
    //             }
    //             else if (char.IsDigit(character))
    //             {
    //                 Console.WriteLine($"Znak '{character}' jest cyfrą.");
    //             }
    //             else
    //             {
    //                 Console.WriteLine($"Znak '{character}' jest innym znakiem.");
    //             }
    //         }
    //         else
    //         {
    //             Console.WriteLine("Podaj dokładnie jeden znak.");
    //         }
    //     }
    
    // ĆW 6 
        // Console.WriteLine("Podaj łańcuch znaków:");
        // string input = Console.ReadLine();

        // if (!string.IsNullOrEmpty(input))
        // {
        //     string result = string.Join(" ", input.ToCharArray());
        //     Console.WriteLine($"Rozstrzelony tekst: {result}");
        // }
        // else
        // {
        //     Console.WriteLine("Podano pusty łańcuch.");
        // }


        // CW 7
        // try
        // {
        //     int value = checked(2147483647 + 1);
        // }
        // catch (OverflowException ex)
        // {
        //     Console.WriteLine("Wykryto przepełnienie wartości int: " + ex.Message);
        // }
    }

    // static bool IsVowel(char ch)
    // {
    //     ch = char.ToLower(ch);
    //     return "aąeęiouy".IndexOf(ch) >= 0;
    // }
}

