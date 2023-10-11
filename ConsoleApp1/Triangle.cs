using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangle
    {
        private double x1, y1;
        private double x2, y2;
        private double x3, y3;
        public void InputCoordinates()
        {
            Console.WriteLine("Введiть координати вершин трикутника:");
            Console.Write("x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("x2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            y2 = double.Parse(Console.ReadLine());
            Console.Write("x3: ");
            x3 = double.Parse(Console.ReadLine());
            Console.Write("y3: ");
            y3 = double.Parse(Console.ReadLine());
        }
        public double this[string side]
        {
            get
            {
                switch (side)
                {
                    case "a":
                        return CalculateDistance(x1, y1, x2, y2);
                    case "b":
                        return CalculateDistance(x2, y2, x3, y3);
                    case "c":
                        return CalculateDistance(x3, y3, x1, y1);
                    default:
                        throw new ArgumentException("Невiрний iндекс сторони трикутника.");
                }
            }
        }
        private double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public double CalculatePerimeter()
        {
            return this["a"] + this["b"] + this["c"];
        }
        public double CalculateArea()
        {
            double s = CalculatePerimeter() / 2;
            return Math.Sqrt(s * (s - this["a"]) * (s - this["b"]) * (s - this["c"]));
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Вершина A: ({x1}, {y1})");
            Console.WriteLine($"Вершина B: ({x2}, {y2})");
            Console.WriteLine($"Вершина C: ({x3}, {y3})");
            Console.WriteLine($"Сторона a: {this["a"]}");
            Console.WriteLine($"Сторона b: {this["b"]}");
            Console.WriteLine($"Сторона c: {this["c"]}");
            Console.WriteLine($"Периметр: {CalculatePerimeter()}");
            Console.WriteLine($"Площа: {CalculateArea()}");
        }
    }
}
