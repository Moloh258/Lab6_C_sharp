using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество секунд, прошедших с начала суток");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 86400 && a >= 0)
            {
                Console.WriteLine("Количество секунд, прошедших с начала последней минуты: {0}", a = a % 60);
            }
            else { Console.WriteLine("Введите подходящее число"); }
        }
    }
}
