using System;

public class Program
{
    public class Przyklad
    {
        public void Metoda(in int liczba)
        {
            Console.WriteLine("MetodaIn: Przekazano liczba = " + liczba);
            // liczba = 5; // Nie można zmodyfikować zmiennej in
        }

        // public void Metoda(out int liczba)
        // {
        //     liczba = 5; // Musimy przypisać wartość do zmiennej out
        //     Console.WriteLine("MetodaOut: Zmieniono liczba na " + liczba);
        // }
        // 'Program.Przyklad' cannot define an overloaded method that differs only on parameter modifiers 'out' and 'in'CS0663
    }

    public class Point
    {
        public int x, y;
        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
    public static void Fun5(Point p)
    {
        p = new Point(1, 2);
    }
    public static void Fun6(ref Point p)
    {
        p = new Point(1, 2);
        p = null;
    }
    public static void Fun1(in int i)
    {
        Console.WriteLine("Fun1: i = " + i);
    }

    public static void Fun2(out int i)
    {
        i = 1;
        Console.WriteLine("Fun2: i = " + i);
    }

    public static void Fun3(ref int i)
    {
        Console.WriteLine("Fun3: i = " + i);
    }

    public static void Fun4(int i)
    {
        Console.WriteLine("Fun4: i = " + i);
    }

    public unsafe void swap(int* p, int* q)
    {
        int temp = *p;
        *p = *q;
        *q = temp;
    }

    // public static void Main()
    // {
    //         int a = 6;
    //         Fun1(a);
    //         Fun2(out a);
    //         Fun3(ref a);
    //         Fun4(a);

    //         short b = 7;
    //         Fun1(b);
    //         // Fun2(out b);   // Nie można przekazać short bez rzutowania do int
    //         // Fun3(ref b);   // Nie można przekazać short bez rzutowania do int
    //         Fun4(b);

    //         int x = 10;
    //         int y = 10;

    //         Console.WriteLine("Wartość x przed wywołaniem Fun1: " + x);
    //         Fun1(x);
    //         Console.WriteLine("Wartość x po wywołaniu Fun1: " + x);

    //         Console.WriteLine("\nWartość y przed wywołaniem Fun2: " + y);
    //         Fun2(out y);
    //         Console.WriteLine("Wartość y po wywołaniu Fun2: " + y);

    //         Console.WriteLine("\nWartość x przed wywołaniem Fun3: " + x);
    //         Fun3(ref x);
    //         Console.WriteLine("Wartość x po wywołaniu Fun3: " + x);

    //         Console.WriteLine("\nWartość y przed wywołaniem Fun4: " + y);
    //         Fun4(y);
    //         Console.WriteLine("Wartość y po wywołaniu Fun4: " + y);

    //         Point point = new Point(10, 15);

    //         Console.WriteLine("Przed Fun5: x = " + point.x + ", y = " + point.y);
    //         Fun5(point);
    //         Console.WriteLine("Po Fun5: x = " + point.x + ", y = " + point.y);

    //         Console.WriteLine("\nPrzed Fun6: x = " + point.x + ", y = " + point.y);
    //         Fun6(ref point);

    // swap(1, 2);
    // Argument 2: cannot convert from 'int' to 'int*' 
    // }
    public unsafe static void Main(string[] args)
    {
        int[] buffer = new int[1024];

        fixed (int* buf = buffer)
        {
            for (int i = 0; i < 1024; i++)
            {
                *(buf + i) = i * 2;  
            }

            Console.WriteLine("Pierwsze 10 wartości w buforze:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("buf[{0}] = {1}", i, *(buf + i));  
            }
        }
        // Output
        // buf[0] = 0
        // buf[1] = 2
        // buf[2] = 4
        // buf[3] = 6
        // buf[4] = 8
        // buf[5] = 10
        // buf[6] = 12
        // buf[7] = 14
        // buf[8] = 16
        // buf[9] = 18

        int[] tablica = new int[10];
        int liczbaElementow = 0;

        while (true)
        {
            Console.WriteLine(string.Join(" ", tablica)); 

            Console.Write("Podaj nowy element (lub 'exit' aby zakończyć): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit") break; 

            if (int.TryParse(input, out int nowyElement) && liczbaElementow < 10)
            {
                Array.Copy(tablica, 0, tablica, 1, liczbaElementow);
                tablica[0] = nowyElement;
                liczbaElementow++;
            }
            else
            {
                Console.WriteLine("Błąd: Tablica pełna lub nieprawidłowe dane.");
            }
        }


        // Ćwiczenie 4: Odwrócenie tablicy
        int[] tablica4 = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Podaj liczbę {i + 1}: ");
            tablica4[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Liczby w odwrotnej kolejności:");
        for (int i = 4; i >= 0; i--)
        {
            Console.WriteLine(tablica4[i]);
        }

        // Ćwiczenie 5: Zliczanie powtarzających się liczb
        int[] tablica5 = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Podaj liczbę {i + 1}: ");
            tablica5[i] = int.Parse(Console.ReadLine());
        }

        var powtórzenia = tablica5.GroupBy(x => x)
                                  .Where(g => g.Count() > 1)
                                  .Select(g => new { Liczba = g.Key, LiczbaPowtórzeń = g.Count() });

        Console.WriteLine("Powtarzające się liczby:");
        foreach (var item in powtórzenia)
        {
            Console.WriteLine($"Liczba: {item.Liczba}, Ilość: {item.LiczbaPowtórzeń}");
        }

        // Ćwiczenie 6: Sumowanie dwóch tablic
        int[,] tablica1 = new int[5, 5];
        int[,] tablica2 = new int[5, 5];
        int[,] wynikowa = new int[5, 5];

        Console.WriteLine("Wprowadź dane do pierwszej tablicy (5x5):");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"tablica1[{i},{j}]: ");
                tablica1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Wprowadź dane do drugiej tablicy (5x5):");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"tablica2[{i},{j}]: ");
                tablica2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                wynikowa[i, j] = tablica1[i, j] + tablica2[i, j];
            }
        }

        Console.WriteLine("Wynikowa tablica (suma):");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(wynikowa[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Długość: {wynikowa.Length}");
        Console.WriteLine($"Długość (LongLength): {wynikowa.LongLength}");
        Console.WriteLine($"Ranga: {wynikowa.Rank}");

        // Ćwiczenie 7: Wyznaczanie wyznacznika macierzy 3x3
        int[,] macierz = {
            { 1, 0, -1 },
            { 0, 0,  1 },
            { -1, -1, 0 }
        };

        int wyznacznik = macierz[0, 0] * (macierz[1, 1] * macierz[2, 2] - macierz[1, 2] * macierz[2, 1])
                       - macierz[0, 1] * (macierz[1, 0] * macierz[2, 2] - macierz[1, 2] * macierz[2, 0])
                       + macierz[0, 2] * (macierz[1, 0] * macierz[2, 1] - macierz[1, 1] * macierz[2, 0]);

        Console.WriteLine($"Wyznacznik macierzy 3x3 wynosi: {wyznacznik}");

        // Ćwiczenie 8: Inicjalizacja i wyświetlenie tablicy schodkowej
        int[,] schodkowa1 = {
            { 1, 4, 10, 14, 19 },
            { 2, 5, 11, 15, 20 },
            { 3, 6, 12, 16, 21 },
            { 13, 17, 8, 18, 9 }
        };

        Console.WriteLine("Tablica schodkowa (Sposób 1):");
        for (int i = 0; i < schodkowa1.GetLength(0); i++)
        {
            for (int j = 0; j < schodkowa1.GetLength(1); j++)
            {
                Console.Write(schodkowa1[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int[,] schodkowa2 = new int[4, 5];
        int[,] wartosci = {
            { 1, 4, 10, 14, 19 },
            { 2, 5, 11, 15, 20 },
            { 3, 6, 12, 16, 21 },
            { 13, 17, 8, 18, 9 }
        };

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                schodkowa2[i, j] = wartosci[i, j];
            }
        }

        Console.WriteLine("\nTablica schodkowa (Sposób 2):");
        for (int i = 0; i < schodkowa2.GetLength(0); i++)
        {
            for (int j = 0; j < schodkowa2.GetLength(1); j++)
            {
                Console.Write(schodkowa2[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

// class TestPointer
// {
//     public static void Main()
//     {
//         int[] list = { 110, 100, 200 };
//         fixed (int* ptr = list)
//             for (int i = 0; i < 3; i++)
//             {
//                 Console.WriteLine("Adres [{0}]={1}", i, (int)(ptr + i));
//                 Console.WriteLine("Wartosé[{0}]={1}", i, *(ptr + i));
//             }
//         Console.ReadKey();
//     swap(1, 2);
// }
// }

// Outpu po wywolaniu:
// Adres [0]=54880
// Wartosé[0]=110
// Adres [1]=54884
// Wartosé[1]=100
// Adres [2]=54888
// Wartosé[2]=200

// Po usunieciu unsafe: Pointers and fixed size 
// buffers may only be used in an unsafe context