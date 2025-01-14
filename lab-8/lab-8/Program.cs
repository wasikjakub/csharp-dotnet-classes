using System;
using System.Runtime.InteropServices;

// Cwiczenie 1

// string[] slowa = new string[]{
// "Juz północ",
// "cień",
// "ponury",
// "pół",
// "świata",
// "okrywa",
// "A jeszcze",
// "serce",
// "zmysłom",
// "spoczynku nie daje"};

// Console.WriteLine($"{slowa[^1]}"); // Spoczynku nie daje

// string[] sonet1 = slowa[2..6];

// foreach (var slowo in sonet1) //<ponury><pół><świata><okrywa>
//     Console.Write($"<{slowo}>");
// Console.WriteLine();

// string[] sonet2 = slowa[^3..^0]; // sercezmysłomspoczynku nie daje
// foreach (var slowo in sonet2) 
//     Console.Write($"{slowo}"); 
// Console.WriteLine();

// string[] sonet3 = slowa[..]; 
// string[] sonet4 = slowa[..5]; 
// string[] sonet5 = slowa[7..];

// foreach (var slowo in sonet3) // Juz północcieńponurypółświataokrywaA jeszczesercezmysłomspoczynku nie daje
//     Console.Write($"{slowo}"); 
// Console.WriteLine();

// foreach (var slowo in sonet4) // Juz północcieńponurypółświata
//     Console.Write($"{slowo}"); 
// Console.WriteLine();

// foreach (var slowo in sonet5) // sercezmysłomspoczynku nie daje
//     Console.Write($"{slowo}"); 
// Console.WriteLine();

// Index stri = ^5; // okrywa
// Console.WriteLine(slowa[stri]);

// Range fraza = 2..7;

// string[] tekst = slowa[fraza]; //  ponury  pół  świata  okrywa  A jeszcze 
// foreach (var slowo in tekst) 
//     Console.Write($" {slowo} "); 
// Console.WriteLine();

// Cwiczenie 2

//class Program
//{
    // public static event Action OnDigit;
    // public static event Action OnCharacter;

    // static void Main(string[] args)
    // {
    //     OnDigit += () => Console.WriteLine("Naciśnięto cyfrę!");
    //     OnCharacter += () => Console.WriteLine("Naciśnięto literę!");

    //     Console.WriteLine("Wpisz znak:");

    //     while (true)
    //     {
    //         ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
    //         char c = keyInfo.KeyChar;

    //         if (char.IsLetter(c))
    //         {
    //             OnCharacter?.Invoke()a;
    //         }
    //         else if (char.IsDigit(c))
    //         {
    //             OnDigit?.Invoke();
    //         }
    //         else
    //         {
    //             break;
    //         }
    //     }
    // }
//}

// Cwiczenie 3

// public class DisposeObject : IDisposable
// {
//     protected bool disposed = false;

//     private IntPtr unmanagedResource;

//     public DisposeObject()
//     {
//         unmanagedResource = Marshal.AllocHGlobal(100); 
//     }

//     ~DisposeObject()
//     {
//         Dispose(false);
//     }

//     public void Dispose()
//     {
//         Dispose(true);
//         GC.SuppressFinalize(this);
//     }

//     protected virtual void Dispose(bool disposing)
//     {
//         if (!disposed)
//         {
//             if (unmanagedResource != IntPtr.Zero)
//             {
//                 Marshal.FreeHGlobal(unmanagedResource);
//                 unmanagedResource = IntPtr.Zero;
//             }
//             disposed = true;
//         }
//     }
// }