using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SquareRoot
    {
        public void CalSquareRoot()
        {
            Console.WriteLine("Enter any number: ");
            double num = Convert.ToInt32(Console.ReadLine());

            double root, assumedRoot = num;

            while (true)
            {
                root = 0.5 * (assumedRoot + ((double) num / assumedRoot));

                if (Math.Abs(assumedRoot - root) < 1)
                {
                    break;
                }

                assumedRoot = root;
            }

            Console.WriteLine(root);
        }
    }
}
