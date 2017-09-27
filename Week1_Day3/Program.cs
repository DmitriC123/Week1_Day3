using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstNumber = 2;
            //int secondNumber = 6;

            //if(firstNumber > secondNumber)
            //{
            //    //Do something
            //    Console.WriteLine("You have broken math. Good job.");
            //}
            //else
            //{
            //    //Do something else
            //    Console.WriteLine("That makes sense.");
            //}

            Console.WriteLine("What day of the week is it?");
            string day = Console.ReadLine();

            if (day == "Monday")
            {
                Console.WriteLine("Back to work.");
            }
            else if (day == "Friday")
            {
                Console.WriteLine("TGIF");
            }
            else
            {
                Console.WriteLine("Bloop");
            }
        }
    }
}
