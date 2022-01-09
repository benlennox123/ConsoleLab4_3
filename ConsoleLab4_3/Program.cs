using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число А=");
            int A = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Введите число B=");
            int B = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Введите число C=");
            int C = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int a = A;
            int b = B;
            int count = 0;
                while (A>=C)
                {
                    A = A - C;
                    B = b;
                    while (B>=C)
                    {
                        B = B - C;
                        count++;
                    }
            }
            Console.WriteLine("В прямоугольнике размером {0}x{1} размещено {2} квадратов со стороной {3}", a, b, count, C);
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
