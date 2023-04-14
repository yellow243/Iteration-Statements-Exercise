using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void PrintNumbers1000()
        {
            //Number 1
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void PrintNumbers999()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        static bool CheckIfEqual(int a, int b)
        {

            return a == b;
        }


        //Write a method to check whether a given number is even or odd
        static bool CheckIfEven(int num)
        {
            return num % 2 == 0;
        }

        //Write a method to check whether a given number is positive or negative

        static bool CheckIfPositive(int num)
        {
            if (num >= 0)
            {
                return true;
            }
            return false;
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        static void CheckTheirAge()
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Great you can vote!");
            }
            else
            {
                Console.WriteLine("Better luck next time");
            }

        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static void CheckTheNumber()
        {
            Console.WriteLine("What is your number between -10 and 10?");
            int answer = int.Parse(Console.ReadLine());
            if (answer >= -10 && answer <= 10)
            {
                Console.WriteLine("Your number is in the range!");
            }
            else
            {
                Console.WriteLine("Your number is OUT of range L!");
             }

        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void Multiplication(int digies)
        {
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine(i * digies);
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintNumbers1000();

            PrintNumbers999();

            var isEqual = CheckIfEqual(5,5);
            Console.WriteLine(isEqual);

            var isEven = CheckIfEven(7809);
            Console.WriteLine(isEven);

            var isPositive = CheckIfPositive(272);
            Console.WriteLine(isPositive);

            CheckTheirAge();

            CheckTheNumber();

            Multiplication(5);



        }
    }
}
