using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 // Author: Glenn Dailey

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonacciSeries(i));
            }
            Console.ReadKey();
        }

        static int FibonacciSeries(int n)
        {
            int firstNumber = 0, secondNumber = 1, result = 0;

            // return the first Fibonacci number
            if (n == 0) return 0;
            if (n == 1) return 1;

            for (int i = 2; i <=n; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }
            return result;
        }
    }
}
