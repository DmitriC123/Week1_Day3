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

            //Console.WriteLine("What day of the week is it?");
            //string day = Console.ReadLine();

            //if (day == "Monday")
            //{
            //    Console.WriteLine("Back to work.");
            //}
            //else if (day == "Friday")
            //{
            //    Console.WriteLine("TGIF");
            //}
            //else
            //{
            //    Console.WriteLine("Bloop");
            //}

            //Console.WriteLine("How old are you?");
            //int userAge = int.Parse(Console.ReadLine());

            //if (userAge >= 0 && userAge <= 1)
            //{
            //    Console.WriteLine("You're just a baby!");
            //}
            //else if (userAge > 1 && userAge < 4)
            //{
            //    Console.WriteLine("Yay toddlers!");
            //}
            //else if (userAge >= 4 && userAge < 13)
            //{
            //    Console.WriteLine("Enjoy your childhood.");
            //}
            //else if (userAge >= 13 && userAge < 65)
            //{
            //    Console.WriteLine("Life is akward");
            //}
            //else if (userAge >= 65 && userAge < 100)
            //{
            //    Console.WriteLine("Enjoy your retirement");
            //}
            //else
            //{
            //    Console.WriteLine("That's not really your age.");
            //}

            //Console.WriteLine("How many points did you earn?");
            //int pointsEarned = int.Parse(Console.ReadLine());

            //switch (pointsEarned)
            //{
            //    case 0:
            //        Console.WriteLine("You lose.");
            //        break;
            //    case 1:
            //        Console.WriteLine("Needs practice.");
            //        break;
            //    case 2:
            //        Console.WriteLine("On target.");
            //        break;
            //    case 3:
            //        Console.WriteLine("SuperStar.");
            //        break;
            //    case 4:
            //        Console.WriteLine("Overachiever.");
            //        break;
            //    case 5:
            //        Console.WriteLine("You cheated!");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid score entered.");
            //        break;

            //}

            //Returning to the above problem, replace hard-coded values of 4(number of diners) and 13(cost per diner) with values provided by the user. 


            //Console.WriteLine("How much did each person pay?");
            //int billPortion = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many people were attending?");
            //int people = int.Parse(Console.ReadLine());
            //int billTotal = billPortion * people;
            //Console.WriteLine(billTotal);
            //double newBill;

            ////How nice!The restaurant is having Customer Appreciation Week.If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!Otherwise, 
            ////they’ll receive a 5 % discount.

            //if (billTotal >= 50)
            //{
            //    newBill = billTotal * .9;
            //    Console.WriteLine("Your discounted total is now $" + newBill);
            //}
            //else
            //{
            //    newBill = billTotal * .95;
            //    Console.WriteLine("Your discounted total is now $" + newBill);
            //}

            //Write a console application to ask the user for two integers. Check and see if the two integers are equal to each other.If they are, 
            //inform the the user that the numbers are equal, else inform the user that the numbers are not equal

            //Console.WriteLine("Put down any number");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Find another number");
            //int secondNumber = int.Parse(Console.ReadLine());
            //if(firstNumber == secondNumber)
            //    {
            //    Console.WriteLine("Those numbers are equal!");
            //}
            //else
            //{
            //    Console.WriteLine("Those number are never equal!!!");
            //}

            //Console.WriteLine("Please pick a number");
            //int firstNumber = int.Parse(Console.ReadLine());
            //if (firstNumber % 2 == 0)
            //{
            //    Console.WriteLine("Congrats! It's even.");
            //}
            //else
            //{
            //    Console.WriteLine("Congrats!! You have an odd number.");
            //}

            //Write a console application to check whether a letter is a vowel or consonant.

            //Console.WriteLine("Please enter a letter.");
            //string userLetter = Console.ReadLine().ToLower();
            //char yourLetter = char.Parse(userLetter);

            //switch (yourLetter)
            //{
            //    case 'a':
            //        Console.WriteLine("This is a vowel.");
            //        break;
            //    case 'e':
            //        Console.WriteLine("This is a vowel.");
            //        break;
            //    case 'i':
            //        Console.WriteLine("This is a vowel.");
            //        break;
            //    case 'o':
            //        Console.WriteLine("This is a vowel.");
            //        break;
            //    case 'u':
            //        Console.WriteLine("THis is a vowel.");
            //        break;
            //    default:
            //        Console.WriteLine("This is a consanant.");
            //        break;

            //Write a console application that prompts the user to input two integer values.Find and print the greatest value of the two integers. 

            Console.WriteLine("Enter a whole number.");
            int firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number.");
            int secondValue = int.Parse(Console.ReadLine());

            if (firstValue > secondValue)
            {
                Console.WriteLine(firstValue + "is the larger value.");

            }
            else if (secondValue > firstValue)
            {
                Console.WriteLine(secondValue + "is the larger value.");

            }
            else
            {
                Console.WriteLine("Go baack to start.");
            }
        }
    }
}

