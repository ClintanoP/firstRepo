/* Name : Clintano
 * Date : 30/01/2021
 * Description : Write a program that uses nested loops to collect data and calculate the average rainfall  over a period of years.  
 * The program should ask for the number of years.  The outer loop will iterate once for each year.  
 * The inner loop will iterate 12 times, once for each month.  
 * Each iteration of the inner loop will ask the user for the inches of rainfall for that month.  
 * After all iteration, the program should display the number of months, the total inches of rainfall,
 * and the average rainfall per month for the entire period.
 */
using System;

namespace Q2
{
    class Program
    {
        static int monthlyRainfall, totalRainfall, currentYear = 0;
        static void Main(string[] args)
        {
            //decl ints
            int numberYears, lengthInMonths, averageRainfall;

            //small intro to what program is and getting initial user input
            Console.WriteLine("#########################################################################");
            Console.WriteLine("Welcome to the rainfall recorder and calculator");
            Console.Write("Enter number of years of data you would like to record\t: ");
            numberYears = int.Parse(Console.ReadLine());
            lengthInMonths = numberYears * 12;

            //loop which calls the innerloop method
            for (int i = 0; i < numberYears; i++)
            {
                InnerLoop();
            }


            averageRainfall = totalRainfall / lengthInMonths; //calculating the average rainfall

            //final output with all information
            Console.WriteLine("#########################################################################");
            Console.WriteLine("The total period of time was {0} months", lengthInMonths);
            Console.WriteLine("The total amount of rain was {0} inches", totalRainfall);
            Console.WriteLine("The average amount of rain was {0} inches", averageRainfall);
            Console.WriteLine("#########################################################################");
        }

        static int InnerLoop()
        {
            currentYear++; //to always have the current year no matter how many years the user puts in
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine();
                Console.Write("Enter amount of rainfall for Year {0} Month {1} in inches : ", currentYear, i+1);
                monthlyRainfall = int.Parse(Console.ReadLine());              
                totalRainfall = monthlyRainfall + totalRainfall;
            }
            return totalRainfall;
        }
    }
}
