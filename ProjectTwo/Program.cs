using System;

namespace ProjectTwo
{
    class Program
    {
        private static void Main(string[] args)
        {
            int num1, sum = 0;
            int num2 = 1;
            
            for (int i = 0; i < 4000000; i = num1 + num2)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                num1 = num2;
                num2 = i;
            }
            Console.WriteLine(sum);
        }
    }
}