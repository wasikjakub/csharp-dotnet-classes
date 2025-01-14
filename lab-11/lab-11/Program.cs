using System;
using System.Threading;

class Program
{
    // static void Main()
    // {
    // try
    // {
    //     Thread thread = new Thread(Run);
    //     thread.Start();
    // }
    // catch (Exception ex)
    // {
    //     Console.WriteLine("Exception: " + ex.Message);
    // }

    // Unhandled exception. System.NullReferenceException: Object reference 
    // not set to an instance of an object.
    // }
    // static void Run() { throw null; }

    // public static void Main()
    // {
    //     new Thread(Run).Start();
    // }
    // static void Run()
    // {
    //     try
    //     {
    //         // ...
    //         throw null;
    //         // ...
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine("Exception!");
    //     }
    // }
    // Exception!
    // lepszym wyborem będzie zadanie 2, gdyz jest to 
    // opisany i zaimplementowany jako obsułga

    // static void Main()
    // {
    //     Task.Factory.StartNew(Run);
    // }
    // static void Run()
    // {
    //     Console.WriteLine("Hello !! The thread pool!");
    // }
    // brak outputu

    // static void Main()
    // {
    //     ThreadPool.QueueUserWorkItem(Run);
    //     ThreadPool.QueueUserWorkItem(Run, 123);
    //     Console.ReadLine();
    // }
    // static void Run(object data)
    // {
    //     Console.WriteLine("Hello !! The thread pool! " + data);
    // }

    // Hello !! The thread pool! 
    // Hello !! The thread pool! 123

    // static void Main()
    // {
    //     Func<string, int> method = Do;
    //     IAsyncResult cookie = method.BeginInvoke("test", null, null);
    //     // .. tutaj możemy równolegle wykonywać inne prace ...
    //     int result = method.EndInvoke(cookie);
    //     Console.WriteLine("String length is: " + result);
    // }
    // static int Do(string s) { return s.Length; }
//     Unhandled exception. System.PlatformNotSupportedException: Operation is not supported on this platform.
//    at System.Func`2.BeginInvoke(T arg, AsyncCallback callback, Object object)
//    at Program.Main() in /Users/jakubwasik/Documents/univeristy/csharp-dotnet-classes/lab-11/lab-11/Program.cs:line 71
}