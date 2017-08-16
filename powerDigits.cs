using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powerDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            double remainder, sum = 0;
            Console.WriteLine("Enter a number");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the power value");
            double power = Convert.ToDouble(Console.ReadLine());
            double result =Math.Pow(number, power);
            Console.WriteLine("Power of {0} ^{1} is : {2}",number,power,result);
            while(result!=0)
            {
                remainder = result % 10;
                sum = sum + remainder;
                result = result / 10;
            }
            Console.WriteLine("The Addition of Digits is:"+Math.Ceiling(sum));
            Console.ReadLine();
        }
    }
}
