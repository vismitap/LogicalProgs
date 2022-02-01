using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatch
    {
        int secStart = 0, secEnd = 0;

        public void SimulateStopWatch()
        {
            Console.WriteLine("Enter s for start \nEnter e for start \nEnter t for terminating the simulation");
            string option = Console.ReadLine();
            bool flag = true;

            while (flag)
            {
                switch (option)
                {
                    case "s":
                        Console.WriteLine("Stop watch Started!");
                        DateTime dateTimeStart = DateTime.Now;
                        secStart = dateTimeStart.Second;
                        option = Console.ReadLine();
                        break;

                    case "e":
                        Console.WriteLine("Stop watch Stopped!");
                        DateTime dateTimeEnd = DateTime.Now;
                        secEnd = dateTimeEnd.Second;

                        Console.WriteLine("The time elapsed is: " + (secEnd - secStart) + "secs");

                        option = Console.ReadLine();
                        if (option == "e")
                        {
                            Console.WriteLine("The timer has stopped already, Enter s to start the timer");
                        }
                        break;

                    case "t":
                        flag = false;
                        break;


                    default:
                        Console.WriteLine("Invalid option");
                        option = Console.ReadLine();
                        break;
                }
            }

        }

    }
}
