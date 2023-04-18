using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            Console.WriteLine("Введите элементы массива:");

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(nums);

            if ((n == 1) || (n == 2))
            {
                Console.WriteLine( $"Максимальное число: {nums[n - 1]}");
            }
            else
            {
                Console.WriteLine($"Третий отчетливый максимум : {nums[n - 3]}");
            }

           Console.ReadKey();
        }
    }
}
