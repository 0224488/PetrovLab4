using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrovLab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Цикл для поиска квадратов числа через DO...WHILE
            int sc = 1;
            int f = 0;
            int i = 0;
            Console.WriteLine("Введите число целое число >0:");
            int n = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Квадрат числа {0} = {1}", i + 1, f += sc);
                sc += 2;
                i++;
            }
            while (i < n);
            Console.ReadKey();
        }
    }
}
