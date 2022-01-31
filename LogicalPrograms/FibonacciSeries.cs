using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public void GenerateFibonacciSeries()
        {
            Console.WriteLine("Enter the number of elements in fibonacci series you want: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] fiboArr = new int[num];
            fiboArr[0] = 0;
            fiboArr[1] = 1;

            for(int i = 2; i < num; i++)
            {
                fiboArr[i] = fiboArr[i-1] + fiboArr[i-2];
            }

            for(int i = 0; i < num; i++)
            {
                Console.Write(fiboArr[i]+" ");
            }
            Console.WriteLine("\n");
        }
    }
}
