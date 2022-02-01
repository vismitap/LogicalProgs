using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        int sum = 0;
        public void IsPerfectNumber()
        {
            Console.WriteLine("Enter any number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }

            if (num == sum)
            {
                Console.WriteLine($"{num} is a Perfect Number\n");
            }
            else
            {
                Console.WriteLine($"{num} is not a Perfect Number\n");
            }
        }
    }
}
