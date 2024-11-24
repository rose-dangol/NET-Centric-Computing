using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendarView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calendar View of a Month \n");
            Console.WriteLine("Su Mo Tu We Th Fr Sa");

            int daysInMonth = 30;
            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"{day,2} ");
                
                if (day % 7 == 0) 
                {
                    Console.WriteLine();
                }
            }
            }
        }
    }
