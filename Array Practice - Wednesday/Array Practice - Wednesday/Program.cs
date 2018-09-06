using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practice___Wednesday
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1:

            int[] nums = new int[5];
            for (int i = 0; i < nums.Length; i++ )
            {
                Console.Write($"Please enter number {i + 1}");
                nums[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Forward");
            for (int j = 0; j<nums.Length; j++)
            {
                Console.WriteLine($"Number {j+1}: {nums[j]}");
            }

            Console.WriteLine("Reversed");
            for (int k = nums.Length; k >0; k--)
            {
                Console.WriteLine($"Number {k}: {nums [k-1]}");
            }
        }

        public static void task2()
        {
            //Task 2a:
            Console.WriteLine("How many numbers would you like to store in the array?");
            int[] array = new int[int.Parse(Console.ReadLine())];
            
            for (int i = 0; i<array.Length; i++)
            {
                Console.WriteLine($"Please enter number {i+1}: ");
                array[i] = int.Parse(Console.ReadLine()); 
            }
            Console.ReadLine();
            //FORWARD
            int total = 0;
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine($"Number {j + 1} (Array index {j}: num[j]");
                total += array[j]; //'+=' is shortcut for 'total = total + array[j]';
            }
            Console.WriteLine("Total of these array items: " + total);

            //REVERSE
           
            for (int j = array.Length; j < 0; j--)
            {
                Console.WriteLine($"Number {j - 1} (Array index {j}: num[j]");
                total = array[j] + total;
            }
            Console.WriteLine("Total of these array items: " + total);

            //Task 2b:
            foreach (int x in array)
            {
                Console.WriteLine(x); //'int x in' - x can be anything, p, q, bob, etc. As long as it has int and in on either sides of it, it will work
                total += x;
            }
            Console.WriteLine($"total = {total}");
        }

        public static void task3()
        {
            //Task 3:
            int[] array1 = new int[5];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Please enter number {i + 1}: ");
                array1[i] = int.Parse(Console.ReadLine());
                
            }
        }
    }
}
