using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача
{
    class Program
    {
        static void Main(string[] args)
        {     
            Console.Write("Введите число n:");
                int n = Convert.ToInt32(Console.ReadLine());
                long p = 1;
                for (int i = 1; i <= n; i++)
                { p *= i; }
                Console.WriteLine($"Произведение чисел от 1 до {n} равно {p}");
                Console.ReadLine();
            }
        }
}
