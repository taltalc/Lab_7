using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double S1 = Triangle(a1, b1, c1);
            Console.WriteLine("Площадь первого треугольника  равна {0:f2}", S1);
            Console.WriteLine("Введите стороны второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double S2 = Triangle(a2, b2, c2);
            Console.WriteLine("Площадь второго треугольника равна {0:f2}", S2);
            double S = 0;
            double Max = 0;
            

            if (S1 > S2)
            {
                Max = S1;
                Console.WriteLine("Площадь первого треугольника больше {0:f2}", Max);
            }
            else
            {
                Max = S2;
                Console.WriteLine("Площадь второго треугольника больше {0:f2}", Max);
            }

            
            Console.ReadKey();
        }

        static double Triangle(double a, double b, double c)
        {
            double S=Math.Sqrt((a+b+c)/2*((a+b+c)/2-a)*((a + b + c)/2-b)*((a + b + c)/2-c));
            return S;





        }

        
        
      
        
            

    }

    







}


    

