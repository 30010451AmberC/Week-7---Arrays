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
    }
}
