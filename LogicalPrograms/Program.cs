using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs\n");

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("****************");
                Console.WriteLine("Enter\n0 for Exit\n" +
               "1 for Fibonacci Series \n");

                Console.WriteLine("****************\n");

                Console.WriteLine("Enter your option: ");
                int option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    case 0:
                        flag = false;
                        break;

                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.GenerateFibonacciSeries();
                        break;

                }
            }
        }
    }
}
