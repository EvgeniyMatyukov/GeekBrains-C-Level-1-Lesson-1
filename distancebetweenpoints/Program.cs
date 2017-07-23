using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Автор Матюков Евгений
//Программа расстояние между точками

namespace distancebetweenpoints
{
    class Program
    {
        static double DistanceBetweenPoints(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }


        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            Console.WriteLine("Программа расстояние между точками");

            Console.Write("координата X1: ");
            point1.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("координата Y1: ");
            point1.Y = Convert.ToDouble(Console.ReadLine());

            Console.Write("координата X2: ");
            point2.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("координата Y2: ");
            point2.Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nрасстояние между точками = {0:F2}", DistanceBetweenPoints(point1, point2));
            Console.ReadKey();
        }
    }


    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

}
