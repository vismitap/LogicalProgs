using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class DayofWeek
    {
        public void DetermineDayOfWeek()
        {
            Console.WriteLine("Enter any year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter any month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter any day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + 31 * m0 / 12) % 7;

            switch (d0)
            {
                case 0:
                    Console.WriteLine("It's a Sunday\n");
                    break;

                case 1:
                    Console.WriteLine("It's a Monday\n");
                    break;

                case 2:
                    Console.WriteLine("It's a Tuesday\n");
                    break;

                case 3:
                    Console.WriteLine("It's a Wednesday\n");
                    break;

                case 4:
                    Console.WriteLine("It's a Thursday\n");
                    break;

                case 5:
                    Console.WriteLine("It's a Friday\n");
                    break;

                case 6:
                    Console.WriteLine("It's a Saturday\n");
                    break;
            }

        }
    }
}
