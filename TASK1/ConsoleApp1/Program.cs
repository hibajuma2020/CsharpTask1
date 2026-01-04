using System.Diagnostics.Metrics;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers you want:");
            int n = int.Parse(Console.ReadLine());

            float sum = 0;
            int count = 0;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Enter number " + i + ":");
                float number = float.Parse(Console.ReadLine());

                sum = sum + number;
                count = count + 1;
            }

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Count = " + count);

        }
    }
}
