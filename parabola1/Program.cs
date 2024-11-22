using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parabola1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coefficients for the first parabola (a, b, c):");
            ParabulaCac p1 = new ParabulaCac(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            Console.WriteLine("Enter coefficients for the second parabola (a, b, c):");
            ParabulaCac p2 = new ParabulaCac(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            Console.WriteLine("\nFirst parabola roots:");
            if (p1.GetFirstRoot() != double.NaN)
                Console.WriteLine($"First root: {p1.GetFirstRoot()} Second root: {p1.GetSecondRoot()}");
            else
                Console.WriteLine("No real roots.");

            Console.WriteLine("\nSecond parabola roots:");
            if (p2.GetFirstRoot() != double.NaN)
                Console.WriteLine($"First root: {p2.GetFirstRoot()} Second root: {p2.GetSecondRoot()}");
            else
                Console.WriteLine("No real roots.");

            Console.WriteLine("\nFirst parabola minimum/maximum:");
            p1.ViewMinMax();

            Console.WriteLine("\nSecond parabola minimum/maximum:");
            p2.ViewMinMax();

            Console.WriteLine("\nEnter coordinates of the point (x, y) to check:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool isOnFirstParabola = p1.IsOnTheGraph(x, y);
            bool isOnSecondParabola = p2.IsOnTheGraph(x, y);

            if (isOnFirstParabola && isOnSecondParabola)
                Console.WriteLine($"The point ({x}, {y}) is on both parabolas.");
            else if (isOnFirstParabola)
                Console.WriteLine($"The point ({x}, {y}) is on the first parabola.");
            else if (isOnSecondParabola)
                Console.WriteLine($"The point ({x}, {y}) is on the second parabola.");
            else
                Console.WriteLine($"The point ({x}, {y}) is not on either parabola.");

            Console.WriteLine($"\nTotal number of parabolas created: {ParabulaCac.ParabulaCount}");
        

        Console.ReadLine();
        }
    }
}
