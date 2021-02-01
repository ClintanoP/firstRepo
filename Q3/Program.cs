/* Name : Clintano
 * Date : 30/01/2021
 * Description : Write a program that will predict the size of a populations of organisms.  
 * The programs should ask for the starting number of organisms, their average daily population increase as a percentage and the number of days 
 * they will multiply.  For example a population might begin with two, have a daily increase of 50%, and will be allowed to multiply for 7 days.  
 * The program should use a loop to show the size of the population for each day.
 */

using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            //decl var
            int startingOrganisms, daysOfIncubation;
            double dailyIncrease, finalOrganismNumbers;

            //getting user input, to then use in the loop
            Console.WriteLine("#########################################################################"); //simply for presentation
            Console.WriteLine("This program will predict the size of a population of organisms");
            Console.Write("Enter the starting number of organisms\t: ");
            startingOrganisms = int.Parse(Console.ReadLine());
            Console.Write("Enter the daily increase percentage\t: ");
            dailyIncrease = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of days of incubation\t: ");
            daysOfIncubation = int.Parse(Console.ReadLine());


            dailyIncrease = (dailyIncrease / 100) + 1; //making the percentage a 1.x, so can easily multiply


            finalOrganismNumbers = startingOrganisms;

            //for loop with the final desired output. 
            for (int i = 0; i <daysOfIncubation; i++)
            {
                finalOrganismNumbers = (finalOrganismNumbers * dailyIncrease);
                Console.WriteLine("Population on day {0} is {1:n2}", i+1, finalOrganismNumbers);
            }
            Console.WriteLine("#########################################################################");

        }
    }
}
