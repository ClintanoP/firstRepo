/* Name : Clintano
 * Date : 30/01/2021
 * Description : Write a program that asks the user to enter today’s sales for five stores.  
 * The program should then display a bar chart comparing each stores sales.  
 * Create each bar char by display row of asterisks.  
 * Each asterisk represents €100 of sales.
 */


using System;

namespace Q4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] storeSales = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter sales for Store {0} : ",i+1);
                storeSales[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sales Bar Chart");
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Store {0} : ",i+1);
                for (int x = 0; x < storeSales[i] / 100; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
