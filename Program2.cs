using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeltonProjectOne
    //Richard Felton, Project One, May 21, 2018
{
    class Program
    {
        static void Main(string[] args)
        {

            string vacationHome;
            double retirementAccount = 0;
            int retirementAge = 0;
            string vehicle = "Tesla Model S";


            Console.WriteLine("Hello! To have your fortune revealed, please TYPE your name, age, birth month, favorite color and number of siblings when prompted.");

            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Please enter your birth month as a number: ");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number of siblings that you have: ");
            int numberOfSiblings = int.Parse(Console.ReadLine());

            Console.Write("Please write the name of a your favorite ROYGBIV color. If you do not " +
                "understand what the acronym ROYGBIV stands for, then type the word HELP instead: ");
            string favColor = Console.ReadLine().ToLower();

            if (favColor.Equals("red"))
            {
                Console.WriteLine("You have entered Red as your favorite color.");
                vehicle = "fire engine";
            }
            else if (favColor.Equals("orange"))
            {
                Console.WriteLine("You have entered Orange as your favorite color.");
                vehicle = "Oscar Mayer Weinermobile";
            }
            else if (favColor.Equals("yellow"))
            {
                Console.WriteLine("You have entered Yellow as your favorite color.");
                vehicle = "NYC Yellow Cab";
            }
            else if (favColor.Equals("green"))
            {
                Console.WriteLine("You have entered Green as your favorite color.");
                vehicle = "John Deere air-conditioned tractor";
            }
            else if (favColor.Equals("blue"))
            {
                Console.WriteLine("You have entered Blue as your favorite color.");
                vehicle = "Electric Blue Hyundai Elantra";
            }
            else if (favColor.Equals("indigo"))
            {
                Console.WriteLine("You have entered Indigo as your favorite color.");
                vehicle = "Toyota Prius";
            }
            else if (favColor.Equals("violet"))
            {
                Console.WriteLine("You have entered Violet as your favorite color.");
                vehicle = "Tesla Model S";
            }
            else if (favColor.Equals("help"))
            {
                Console.Write("ROYGBIV is an acronym that represents the colors " +
                    "of the rainbow: Red, Orange, Yellow, Green, Blue, Indigo, and Violet." +
                    "Type the name of one of these colors as your favorite color: ");
                favColor = Console.ReadLine().ToLower();
            }
            else
            {
                Console.WriteLine("Do you need help to select your favorite color?" +
                    "If so, type the word HELP: ");
                favColor = Console.ReadLine().ToLower();
            }
            if (favColor.Equals("help"))
            {
                Console.Write("ROYGBIV is an acronym that represents the colors " +
                    "of the rainbow: Red, Orange, Yellow, Green, Blue, Indigo, and Violet." +
                    "Type the name of one of these colors as your favorite color: ");
                favColor = Console.ReadLine().ToLower();
            }

            Console.WriteLine(favColor);
            Console.WriteLine(vehicle);

            int oddEven = age % 2;
            Console.Write("Odd or Even Remainder is ");
            Console.WriteLine(oddEven);

            switch(oddEven)
            {
                case 0:
                     Console.WriteLine(oddEven);
                    Console.WriteLine("Your age is even");
                    retirementAge = 25;
                    break;
                case 1:
                    Console.WriteLine(oddEven);
                    Console.WriteLine("Your age is odd");
                    retirementAge = 40;
                    break;
                default:
                    Console.WriteLine(oddEven);
                    Console.WriteLine("Your age has to be either odd or even!");
                    break;
            }

            Console.Write("siblings: ");
            Console.WriteLine(numberOfSiblings);

            switch (numberOfSiblings)
                
            {
                case 0:
                    Console.WriteLine(numberOfSiblings);
                    Console.WriteLine("You have no siblings.");
                    vacationHome = "Nassau, Bahamas";
                    break;
                case 1:
                    Console.WriteLine(numberOfSiblings);
                    Console.WriteLine("You have one sibling.");
                    vacationHome = "Traverse City, Michigan";
                    break;
                case 2:
                    Console.WriteLine(numberOfSiblings);
                    Console.WriteLine("You have two siblings.");
                    vacationHome = "Panama City, Florida";
                    break;
                case 3:
                    Console.WriteLine(numberOfSiblings);
                    Console.WriteLine("You have three siblings.");
                    vacationHome = "Phoenix, Arizona";
                    break;
                default:
                    Console.WriteLine(numberOfSiblings);
                    Console.WriteLine("You have less than zero siblings.");
                    vacationHome = "Rome, New York";
                    break;
            }

            Console.Write(numberOfSiblings);
            Console.WriteLine(vacationHome);

            Console.Write(birthMonth);
            Console.WriteLine(birthMonth);

            switch(birthMonth)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine(birthMonth);
                    retirementAccount = 600000;
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    Console.WriteLine(birthMonth);
                    retirementAccount = 1500000;
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                    Console.WriteLine(birthMonth);
                    retirementAccount = 3000000;
                    break;
                default:
                    Console.WriteLine(birthMonth);
                    retirementAccount = 0;
                    break;
            }

            Console.WriteLine(retirementAccount);

            Console.WriteLine("Your fortune is as follows:");
            Console.WriteLine(firstName + " " + lastName + " will retire");
            Console.WriteLine("in " + retirementAge + " years with " + retirementAccount + " in the bank,");
            Console.WriteLine("a vacation home in " + vacationHome + ", and a " + vehicle + ".");



        }//Main Method Curly Brace
    }//Program Curly Brace
}//namespace Curly Brace
