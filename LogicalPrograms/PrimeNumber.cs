using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public void isPrime()
        {
            Console.WriteLine("Enter any number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 2; i <= (num/2)+1; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{num} is NOT a Prime Number");
                    break;
                }
                else
                {
                    Console.WriteLine($"{num} is a Prime Number");
                }
            }
        }
    }
}
