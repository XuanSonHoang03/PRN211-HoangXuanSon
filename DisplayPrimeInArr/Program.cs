using System;

namespace DisplayPrimeInArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input value of array
            int[] arr = InputValue();

            // Check prime number in array
            int[] result = CheckPrimeNumber(arr);

            // Display numbers that are prime in array
            DisplayPrimeInArr(arr, result);
        }

        private static void DisplayPrimeInArr(int[] arr, int[] result)
        {
            bool HasPrime = false;
            for(int i = 0; i < arr.Length; i++)
            {
                if (result[i] > 0)
                {
                    HasPrime = true;
                    break;
                }
            }

            if (!HasPrime)
            {
                Console.WriteLine("Don't have primes in the array.");
                return;
            }
            else
            {
                Console.Write("Primes in array are: ");
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] != 0)
                    {
                        Console.Write(result[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }

        private static int[] CheckPrimeNumber(int[] arr)
        {
            int[] result = new int[arr.Length];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrimeNumber(arr[i]))
                {
                    result[index] = arr[i];
                    index++;
                }
            }
            return result;
        }

        private static bool IsPrimeNumber(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static int[] InputValue()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter arr[{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
    }
}
