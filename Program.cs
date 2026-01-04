using System.Diagnostics.Metrics;

namespace CsharpProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            float number2 = float.Parse(Console.ReadLine());

            float result = number1 + number2;
                Console.WriteLine("The result:"+ result);
          
        if (result>50)
            {
                Console.WriteLine("Passed");
                    }

    else
            { Console.WriteLine("Faild");
            }
            int counter;
            for (counter = 1; counter <= 5; counter++) ;
        }
    }
}
