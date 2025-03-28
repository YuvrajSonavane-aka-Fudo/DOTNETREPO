using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            sumoftwo();
            evenorodd();
            findlargest();
        }

        static void sumoftwo()
        {
            Console.WriteLine("Enter two numbers: ");
            int a = int.Parse(Console.ReadLine() ?? "0");
            int b = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine(a + b);
        }

        static void evenorodd()
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine() ?? "0");
            if (a % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        static void findlargest()
        {
            Console.WriteLine("Enter three numbers: ");
            int[] arr = new int[100];
            int largest = 0;
            for (int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }

            Console.WriteLine(largest);
        }
    }
}
