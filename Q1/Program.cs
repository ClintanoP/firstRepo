/* Name : Clintano
 * Date : 29/01/2021
 * Description : The distance a vehicle travels can be calculated as follows

Distance = speed * Time

For example if a train travels 40 km per hour for three hours, the distance travelled is 120 km.
Write a program that asks for the speed of a vehicle and the number of hours it has travelled.
 */

using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //decl var
            int speedPerHour, numberHoursTravelled, distanceTravelled;


            //get user input
            Console.Write("Enter the speed in KMp/h         : ");
            speedPerHour = int.Parse(Console.ReadLine());
            Console.Write("Enter number of hours travelled  : ");
            numberHoursTravelled = int.Parse(Console.ReadLine());


            //loop and output
            Console.WriteLine("Hour\tDistance Travelled");
            for (int i = 1; i < numberHoursTravelled+1; i++)
            {
                distanceTravelled = speedPerHour * i;
                Console.WriteLine("{0}\t{1}",i, distanceTravelled);
            }
        }
    }
}
