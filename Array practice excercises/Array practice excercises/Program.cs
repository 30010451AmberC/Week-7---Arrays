using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_practice_excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1:
            string[] medalWinners = new string[3]{"GOLD","SILVER", "BRONZE"};
            Console.WriteLine("Please enter the Gold medal winner:");
            medalWinners[0] = Console.ReadLine();
            Console.WriteLine("Please enter the Silver medal winner:");
            medalWinners[1] = Console.ReadLine();
            Console.WriteLine("Please enter the Bronze medal winner:");
            medalWinners[2] = Console.ReadLine();

            Console.WriteLine("Which medal winner would you like to know?");
            Console.WriteLine("Press 1 for the gold medal winner.");
            Console.WriteLine("Press 2 for the silver medal winner.");
            Console.WriteLine("Press 3 for the bronze medal winner.");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine($"Gold medal went to: {medalWinners[0]}");
            } else if (input == 2)
            {
                Console.WriteLine($"Silver medal went to: {medalWinners[1]}");
            } else if (input == 3)
            {
                Console.WriteLine($"Bronze medal went to: {medalWinners[2]}");
            }

            


        }

        public static void task2()
        {
            //Task 2:
            string[] firstNames = new string[5];
            for(int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine($"Please enter name {i + 1}:");
                firstNames[i] = Console.ReadLine();
            }
            Console.WriteLine($"The first name entered is {firstNames[0]}");
            Console.WriteLine($"The last name entered is {firstNames[4]}");

        }

        public static void task3()
        {
            //Task3:

            string[] names = {"Bob", "Jerry", "Greg", "Sarah", "Alice" };
            Random rand = new Random();

            Console.WriteLine($"{names[rand.Next(0,4)]}");
        }

    }
}
