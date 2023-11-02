using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            double A = 2 * Math.Cos(x - (Math.PI / 6));

            double y;
            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());
            double B = 0.5 + Math.Pow(Math.Sin(y), 2);

            double z;
            Console.WriteLine("Введите z: ");
            z = Convert.ToDouble(Console.ReadLine());
            double C = 1 + (Math.Pow(z, 2) / 3 - Math.Pow(z, 2) / 5);

            double t = A / B * C;

            Console.WriteLine("t = " + t);
            Console.ReadKey();

        }

    }
}
