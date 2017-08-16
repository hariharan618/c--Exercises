using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenFibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a range to find fibonacci");
           // int range = Convert.ToInt16(Console.ReadLine());
            int a = 1, b = 2, c,sum=2;
            while((a+b)< 4000000)
            {
                c = a + b;
                a = b;
                b = c;
                if (c % 2 == 0)
                    sum = sum + c;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
