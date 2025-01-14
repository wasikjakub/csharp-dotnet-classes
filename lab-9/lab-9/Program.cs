using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    private static readonly object ConsoleLock = new object(); 

    static void Main()
    {
        Console.Clear();
        Console.CursorVisible = false;

        Thread starThread = new Thread(DrawStar);
        Thread treeBodyThread = new Thread(DrawTreeBody);
        Thread decorationsThread = new Thread(DrawDecorations);
        Thread baseThread = new Thread(DrawBase);

        starThread.Start();
        treeBodyThread.Start();
        baseThread.Start();

        treeBodyThread.Join();
        baseThread.Join();
        decorationsThread.Start();

        decorationsThread.Join();
        starThread.Join();

        Console.CursorVisible = true;
        Console.ReadKey();
    }

    static void DrawStar()
    {
        lock (ConsoleLock)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.SetCursorPosition(15, 0); 
            Console.Write("*");
            Console.ResetColor();
        }
    }

    static void DrawTreeBody()
    {
        Console.ForegroundColor = ConsoleColor.Green; 
        for (int i = 1; i < 15; i++) 
        {
            string spaces = new string(' ', 15 - i);
            string branches = new string('*', i * 2 + 1);

            lock (ConsoleLock)
            {
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.SetCursorPosition(0, i);
                Console.Write(spaces + branches);
            }
            Thread.Sleep(100); 
        }
        Console.ResetColor();
    }

    static void DrawDecorations()
    {
        Random rand = new Random();
        ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };
        List<string> baubles = new List<string> { "0", "-0-", "^|^", "@" };

        for (int i = 0; i < 20; i++)
        {
            int y = rand.Next(1, 15); 
            int x = 15 - y + rand.Next(0, y * 2 + 1); 

            lock (ConsoleLock)
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = colors[rand.Next(colors.Length)];
                Console.Write(baubles[rand.Next(baubles.Count)]); 
            }
            Thread.Sleep(150); 
        }
        Console.ResetColor();
    }

    static void DrawBase()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow; 
        for (int i = 0; i < 3; i++)
        {
            lock (ConsoleLock)
            {
                Console.SetCursorPosition(12, 15 + i);
                Console.Write(new string('|', 7));
            }
            Thread.Sleep(100); 
        }
        Console.ResetColor();
    }
}