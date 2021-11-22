using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double L = Convert.ToDouble(Console.ReadLine());
            double S = 0;
            double V = 0;
            Cube (L, out  S, out V);

            Console.WriteLine("Площадь поверхности куба равна {0:f2}", S);
            Console.WriteLine("Объем куба равен {0:f2}", V);
            Console.ReadKey();
        }

        static void Cube(double L, out double S, out double V)
        {
            S = Math.Pow(L,2) * 6;
            V = Math.Pow(L, 3);
        }
        
        









    }
}
