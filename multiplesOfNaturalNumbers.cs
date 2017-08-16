using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplesOfNaturalNumbers
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Multiples of 3 & 5 <1000");
            for(int i=1;i<1000;i++)
            {
                if(i%3==0 || i%5==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
