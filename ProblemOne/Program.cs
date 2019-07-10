using System;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int final = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    final += i;
                }
            }
            
            Console.WriteLine(final);
        }
    }
}