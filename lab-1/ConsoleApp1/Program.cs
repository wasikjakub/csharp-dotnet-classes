using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ex. 1

            static void SumNum(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            //---------------------------------------------------------------------------------------------
            // Ex. 2

            static void DivNum(int a, int b)
            {
                Console.WriteLine(a / b);
            }
            //---------------------------------------------------------------------------------------------
            // Ex.3

            int result1 = (-1) + (4 * 6);
            int result2 = (35 + 5) % 7;
            int result3 = (14 - (4 * 6 / 11));
            int result4 = 2 + 15 / (6 * 1) - 7 % 2;
            Console.WriteLine(result1 + " " + result2 + " " + result3 + " " + result4);
            //----------------------------------------------------------------------------------------------     
            // Ex. 4

            Console.WriteLine("Enter first number: ");
            string numOne = Console.ReadLine();
            int.Parse(numOne);
            Console.WriteLine("Enter second number: ");
            string numTwo = Console.ReadLine();
            int.Parse(numTwo);
            Console.WriteLine($"Drugi numer: {numTwo}. Pierwszy numer: {numOne}");
            //----------------------------------------------------------------------------------------------            
            //Ex. 5

            Console.WriteLine("Enter first number: ");
            string numberOne = Console.ReadLine();
            int firstNumber = int.Parse(numberOne);  

            Console.WriteLine("Enter second number: ");
            string numberTwo = Console.ReadLine();
            int secondNumber = int.Parse(numberTwo);  

            Console.WriteLine("Enter third number: ");
            string numberThree = Console.ReadLine();
            int thirdNumber = int.Parse(numberThree);  

            int resultMultiply = + firstNumber * secondNumber * thirdNumber;

            Console.WriteLine(thirdNumber + "*" + secondNumber + "*" + firstNumber + "=" + resultMultiply);
            //-------------------------------------------------------------------------------------------------
            //Ex. 6 

            Console.WriteLine("Podaj cyfrę:");
            char cyfra = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine(" " + new string(cyfra, 4));
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(cyfra + "    " + cyfra);
            }

            Console.WriteLine(" " + new string(cyfra, 4));
        
            //-------------------------------------------------------------------------------------------------
            //Ex. 7
            int ii = 75400;
            double id = 7.54;

            string s1 = string.Format("Wartość int to {0}, a wartość double to {1:F2}", ii, id);
            Console.WriteLine(s1);

            string s2 = "Cyfra int " + ii + ", a to cyfra double " + id.ToString("F2");
            Console.WriteLine(s2);

            Console.WriteLine("---{0,40}---", ii);
            Console.WriteLine("---{0,-40}---", ii);

            int newInt = 57300;
            double newDouble = 5.73;

            Console.WriteLine("{0:c}, {0:d}, {0:e}, {0:f}, {0:r}, {0:x}", newInt);
            Console.WriteLine("{0:c}, {0:e}, {0:f}, {0:r}", newDouble);

            float flo = 220.022f;

            Console.WriteLine("„{0:0.00000}”, {0:[#].(#)(##)}, {0:0.0}, {0:0,0}, {0:,.}, {0:0%}, {0:0e+0}", flo);

            DateTime d = System.DateTime.Now;

            Console.WriteLine("{0:d}, {0:D}, {0:t}, {0:T}, {0:f},{0:F}, {0:g}, {0:G}, {0:M}, {0:r}, {0:s}, {0:u}, {0:U}, {0:Y}", d);
            //-------------------------------------------------------------------------------------------------
            //Ex. 8

            Console.WriteLine("Podaj temperaturę w stopniach Celsjusza:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double celsius))
            {
                double kelvin = celsius + 273.15;
                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine($"Temperatura w Kelvinach: {kelvin:F2} K");
                Console.WriteLine($"Temperatura w Fahrenheicie: {fahrenheit:F2} °F");
            }
            //-------------------------------------------------------------------------------------------------
            //Ex. 9
            Console.WriteLine((int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b)) && (a < 0 && b > 0 || a > 0 && b < 0));    
        }
    }
}