using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Caculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input number
            (int a, int b) numbers = InputNumber();
            //input operator
            int opera = InputOpera();
            //Caculate
            int result = Caculate(numbers, opera);
            //Display result
            DisplayResult(result, numbers, opera);
        }

        private static void DisplayResult(int result, (int a, int b) numbers, int opera)
        {
            switch (opera)
            {
                case 1: Console.WriteLine($"{numbers.a} + {numbers.b} = {result}");
                    break;
                case 2:
                    Console.WriteLine($"{numbers.a} - {numbers.b} = {result}");
                    break;
                case 3:
                    Console.WriteLine($"{numbers.a} * {numbers.b} = {result}");
                    break;
                case 4:
                    Console.WriteLine($"{numbers.a} / {numbers.b} = {result}");
                    break;
            }
        }

        private static int Caculate((int a, int b) numbers, int opera)
        {
            int result = 0;
            switch (opera)
            {
                case 1: result = numbers.a + numbers.b; 
                    break;
                case 2:
                    result = numbers.a - numbers.b;
                    break;
                case 3:
                    result = numbers.a * numbers.b;
                    break;
                case 4: result = numbers.a / numbers.b;
                    break;
            }
            return result;
        }

        private static int InputOpera()
        {
            int opera;
            do
            {
                Console.Write("Input operator (1 - Addition; 2 - Subtraction; 3 - Multiplication; 4 - Division): ");
                opera = int.Parse(Console.ReadLine());
            } while (opera < 1 || opera > 4);
            return opera;
        }

        private static (int a, int b) InputNumber()
        {
            Console.Write("Input a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            int b = int.Parse(Console.ReadLine());

            return (a, b);
        }
    }
}
