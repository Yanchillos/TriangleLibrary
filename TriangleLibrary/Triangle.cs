using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLibrary
{
    public class Triangle
    {
        public static double GetTriangleArea(double a, double b, double c)
        {
            if ((a <= 0) || (b <= 0) || (c <= 0))
            {
                Console.WriteLine("Неправильные длины сторон");
                return -1;
            }

            var sides = new double[] { a, b, c };
            Array.Sort(sides);

            if (sides[0] * sides[0] + sides[1] * sides[1] != sides[2] * sides[2])
            {
                Console.WriteLine("Стороны с такими длиннами не могут образовывать прямоугольный треугольник");
                return -1;
            }

            return sides[0] * sides[1] / 2;
        }
    }
}
