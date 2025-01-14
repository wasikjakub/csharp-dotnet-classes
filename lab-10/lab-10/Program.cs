using System;
using System.Threading;

// class ThreadExample
// {
//   static void Main()
//   {
//     Thread t = new Thread (Write1); //Uruchom inny wątek t.Start();
//     // Główny wątek.
//     t.Start();
//     for (int i = 0; i < 1000; i++) Console.Write ("0");
//   }
//   //Inny wątek
//   static void Write1()
//   {
//     for (int i = 0; i < 1000; i++) Console.Write ("1");
//   }
// }
// output:
// 000000000000000000000000000000000000000000000000000000000
// 000000000000000000000000000000000000000000000000000001000
// 011111111111111111111111111111111111111111111111111111111
// 111111111111111111111111111111111111111111111101111111111
// 111111111111111111000000000111111111111111110000110000000
// 000000000000000000000000000000000000000000000000000000000
// 000000000000000000000000000000000000000000000000111111111
// 111111111111111111111111111111111111111111111111111111111
// 111111111111111111111111111111111111111111111111111111111
// 111111111111111111111111111011111111111111111111111111111
// 111111111111111111111111111111111111111111111111111111111
// 111111111111111111111111111111111111111111111111111111111
// 1111111111111110000000000000000000000000000000000000000000
// 0001000000000000000000000000000000000000000000000000000000
// 0000000000000000000000000000000000000000000000000000000000
// 0000000000000000000000000000000000000111000000000000000000
// 0000000000000000000000000000000000000000000000000000000000
// 0000000000000000000000000000000000000000000000000000000000
// 0000000000000000000000000000000000000000000000000000001111
// 1111111111111111111111111111111111111111111111111111111111
// 1111111111111111111111111111111111111111111111111111111111
// 1111111111111111111111111111111111111111111111111111111111
// 1111111111111111111111111111111111111111111111111111111111
// 1111111111111111111111111111111111111111111111111111111111
// 1111111111111111111111111111111111111111111111111111111111
// 1111111111111111111111111111111111111111111111111111111111
// 1111111111111111111111100000010000001111000000000001111110
// 0000000000000000111000000000000000000000000110000000000111
// 1100000000000000000000000000111111111111111111111111111111
// 1111111111111111111111111111111111111111111111111111110000
// 0000000000000000000000000000000000000000000000000000000000
// 0000000000000000000000000000000000000000000000000000000000
// 0000000000000000000000000000000000000000000000000000000000
// 0000000000000000000000000000000000000000000000000000000000
// 0000000000000000000000000000000000000000 

// class Program
// {
//     static void Main()
//     {
//         new Thread(Run).Start(); // Uruchamia Run w nowym wątku
//         Run();                   // Uruchamia Run w głównym wątku
//     }

//     static void Run()
//     {
//         for (int cycles = 0; cycles < 5; cycles++)
//         {
//             Console.Write('x');
//         }
//     }
// }

// xxxxxxxxxx, wypisano 10 razy x - wątki nie są zsynchronizowane i walczą który wypisze co w konosli

// class ThreadTest
// {
//     bool done;
//     static void Main()
//     {
//         ThreadTest tt = new ThreadTest();
//         new Thread(tt.Run).Start();
//         tt.Run();
//     }
//     // Zauważ, że Run jest teraz metodą instancji
//     void Run()
//     {
//         if (!done) { done = true; Console.WriteLine("Done"); }
//     }
// }
// Done zostało wypisane raz poniewaz kod jest metodą instancji

// class ThreadExample
// {
//     static bool done; // Pole statyczne
//     static readonly object locker = new object();
//     static void Main()
//     {
//         new Thread(Run).Start();
//         Run();
//     }
//     static void Run()
//     {
//         // if (!done) { done = true; Console.WriteLine("Done"); }
//         if (!done) { Console.WriteLine ("Done"); done = true; }
//     }
// }

// Po zmianie kolejnosci w funkcji Run, Done zostało wypisane dwokrotnie

// class Program
// {
//     static readonly object locker = new object();
//     static bool done; // Pole statyczne
//     static void Main()
//     {
//         new Thread(Run).Start();
//         Run();
//     }

//     static void Run()
//     {
//         lock (locker)
//         {
//             for (int cycles = 0; cycles < 5; cycles++)
//             {
//                 if (!done) { Console.WriteLine("Done"); done = true; }
//             }
//         }
//     }
// }
// Teraz wątki są wykonywane po kolei

// class Program
// {
//     static void Main()
//     {
//         Thread t = new Thread(Run);
//         t.Start();
//         t.Join();
//         Console.WriteLine("Thread t has ended!");
//     }
//     static void Run()
//     {
//         for (int i = 0; i < 777; i++) Console.Write("☺");
//     }
// }

// Wynik: ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺
// ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺
// ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺
// ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺
// ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺
// ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺
// ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺
// ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺
// ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺
// ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺
// ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺
// ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺
// ☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺Thread t has ended!


class Program
{
    static Thread[] threads = new Thread[5];
    
    static int[] results = new int[5];

    static void Main()
    {
        int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        
        int[,] matrix2 = {
            { 10, 11, 12 },
            { 13, 14, 15 },
            { 16, 17, 18 }
        };
        
        int[,] matrix3 = {
            { 19, 20, 21 },
            { 22, 23, 24 },
            { 25, 26, 27 }
        };
        
        int[,] matrix4 = {
            { 28, 29, 30 },
            { 31, 32, 33 },
            { 34, 35, 36 }
        };
        
        int[,] matrix5 = {
            { 37, 38, 39 },
            { 40, 41, 42 },
            { 43, 44, 45 }
        };
        
        threads[0] = new Thread(() => SumMatrixElements(matrix1, 0));
        threads[1] = new Thread(() => SumMatrixElements(matrix2, 1));
        threads[2] = new Thread(() => SumMatrixElements(matrix3, 2));
        threads[3] = new Thread(() => SumMatrixElements(matrix4, 3));
        threads[4] = new Thread(() => SumMatrixElements(matrix5, 4));

        foreach (var thread in threads)
        {
            thread.Start();
        }

        foreach (var thread in threads)
        {
            thread.Join();
        }

        int totalSum = 0;
        foreach (var result in results)
        {
            totalSum += result;
        }

        Console.WriteLine($"Suma wszystkich elementów macierzy: {totalSum}");
    }

    static void SumMatrixElements(int[,] matrix, int index)
    {
        int sum = 0;
        foreach (var item in matrix)
        {
            sum += item;
        }

        results[index] = sum;
        Console.WriteLine($"Suma elementów macierzy {index + 1}: {sum}");
    }
}

// Wynik:
// Suma elementów macierzy 5: 369
// Suma elementów macierzy 2: 126
// Suma elementów macierzy 4: 288
// Suma elementów macierzy 3: 207
// Suma elementów macierzy 1: 45
// Suma wszystkich elementów macierzy: 1035