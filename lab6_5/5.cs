using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер года");
            int G = Convert.ToInt32(Console.ReadLine());
            if (G > 0)
            {
                int Cen = (G - 1) / 100 + 1;
                Console.WriteLine("Номер столетия:{0}", Cen);
            }

        }
    }
}
