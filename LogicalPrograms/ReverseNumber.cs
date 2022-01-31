using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void ReturnReverse()
        {
            Console.WriteLine("Enter any number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0, rem = num;
            while (rem > 0)
            {
                rev = rev * 10 + rem%10;
                rem /= 10;
            }
            Console.WriteLine($"Reverse of {num} is "+ rev+"\n");
        }
    }
}
