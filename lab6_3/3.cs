using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня в году");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите каким днем недели было 1 января");
            int N = Convert.ToInt32(Console.ReadLine());
            if (K < 366 && K >= 0 && N >= 1 && N <= 7)
            {
                Console.WriteLine("Номер дня недели: {0}", K = K % 7 + 1);

            }
            else { Console.WriteLine("Введите корректное число"); }
        }
    }
}
