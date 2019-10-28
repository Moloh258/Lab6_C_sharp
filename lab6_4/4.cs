using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон прямоугольника");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину стороны квадрата");
            int C = Convert.ToInt32(Console.ReadLine());
            if (A > 0 && B > 0 && C > 0)
            {
                int D = A / C;
                int SH = B / C;
                int kol_vo;
                Console.WriteLine("Количество квадратов, размещенных на прямоугольнике равно {0}", kol_vo = D * SH);
                int GY = A * B - (D * C) * (SH * C);
                Console.WriteLine("Площадь незанятой части прямоугольника равна:{0}", GY);
            }
            else
            {
                Console.WriteLine("Введите корректные числа");
            }
        }
    }
}
