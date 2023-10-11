using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TCircle : IComparable<TCircle>
    {
        protected double radius;
        public TCircle() 
        {
            radius= 0;
        }
        public TCircle(double r)
        {
            radius = r;

        }

        public TCircle(TCircle circle)
        {
            radius = circle.radius;
        }

        public override string ToString()
        {
            return $"Коло з радiусом: {radius}";
        }
        public void Input()
        {
            Console.Write("Введiть радiус круга: ");
            radius = Convert.ToDouble(Console.ReadLine());
        }
        
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public double CalculateLength()
        {
            return 2 * Math.PI * radius;
        }
        public int CompareTo(TCircle otherCircle)
        {
            if (otherCircle == null)
                throw new ArgumentNullException(nameof(otherCircle), "Параметр не може бути null");

            return radius.CompareTo(otherCircle.radius);
        }
        public static TCircle operator +(TCircle circle1, TCircle circle2)
        {
            return new TCircle(circle1.radius + circle2.radius);
        }
        public static TCircle operator -(TCircle circle1, TCircle circle2)
        {
            return new TCircle(Math.Max(0, circle1.radius - circle2.radius));
        }
        public static TCircle operator *(TCircle circle, double factor)
        {
            return new TCircle(circle.radius * factor);
        }
        public static TCircle operator *(double factor, TCircle circle)
        {
            return circle * factor;
        }
        public void Output()
        {
            Console.WriteLine(this);
            Console.WriteLine($"Площа: {CalculateArea()}");
            Console.WriteLine($"Довжина кола: {CalculateLength()}");
        }
    }
}
