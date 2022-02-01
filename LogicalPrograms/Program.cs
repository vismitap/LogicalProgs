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
               "1 for Fibonacci Series \n" +
               "2 for Perfect Number\n" +
               "3 for Prime Number\n" +
               "4 for Reverse Number\n" +
               "5 for Coupon Generation\n" +
               "6 for Stop Watch\n" +
               "7 for Day of Week\n");

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

                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.IsPerfectNumber();
                        break;

                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.IsPrime();
                        break;

                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.ReturnReverse();
                        break;

                    case 5:
                        CouponGeneration coupon = new CouponGeneration();
                        coupon.GenerateCoupon();
                        break;

                    case 6:
                        StopWatch watch = new StopWatch();
                        watch.SimulateStopWatch();
                        break;

                    case 7:
                        DayofWeek day = new DayofWeek();
                        day.DetermineDayOfWeek();
                        break;
                }
            }
        }
    }
}
