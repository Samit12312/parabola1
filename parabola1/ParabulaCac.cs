using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parabola1
{
    internal class ParabulaCac
    {
        double a;
        double b;
        double c;
        public static int ParabulaCount = 0;
        public ParabulaCac(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c; ParabulaCount++;
        }
        public void GetCuttingPoint(ParabulaCac other)
        {
            double A = this.a - other.a;
            double B = this.b - other.b;
            double C = this.c - other.c;
            if (A == 0)
            {
                double x = -C / B;
                double y = this.a * x * x + this.b * x + this.c;
                Console.WriteLine($"The parabolas intersect at one point: ({x}, {y})");
                return;
            }
            double value = B * B - 4 * A * C;

            if (value == 0)
            {
                double x = -B / (2 * A);
                double y = this.a * x * x + this.b * x + this.c;
                Console.WriteLine($"The parabolas intersect at one point: ({x}, {y})");
            }
            else
            {
                double x1 = (-B + Math.Sqrt(value)) / (2 * A);
                double x2 = (-B - Math.Sqrt(value)) / (2 * A);

                double y1 = this.a * x1 * x1 + this.b * x1 + this.c;
                double y2 = this.a * x2 * x2 + this.b * x2 + this.c;

                Console.WriteLine($"The parabolas intersect at two points: ({x1}, {y1}) and ({x2}, {y2})");
            }

        }
        public void ViewMinMax()
        {
            double x = -b / (2 * a);
            double y = a * x * x + b * x + c;
            string minOrMax = a > 0 ? "max" : "min";
            Console.WriteLine($"the parabola has a {minOrMax} point at coordinates ({x}, {y})");
        }
        public bool IsOnTheGraph(int x, int y)
        {
            double isonthegraph = a * x * x + b * x + c;
            return Math.Abs(isonthegraph - y) <= 0.0001;
        }
        public double CaculateY(double x)
        {
            double y = a * x * x + b * x + c; return y;
        }
        public double GetFirstRoot()
        {
            double firstroot = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 *a);
            return firstroot;
        }
        public double GetSecondRoot()
        {
            return (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }
        public override string ToString()
        {
            string parabola = "y = ";
            parabola += $"{a}x^2 ";
            if (b >= 0) parabola += $"+ {b}x ";
            else parabola += $"- {Math.Abs(b)}x ";
            if (c >= 0) parabola += $"+ {c}";
            else parabola += $"- {Math.Abs(c)}";
            return parabola;
        }
    }
}
