using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TCylinder : TCircle
    {
        private double height;
        public TCylinder()
        {
            height = 0.0;
        }

        public TCylinder(double r, double h) : base(r)
        {
            height = h;
        }

        public override string ToString()
        {
            return $"Цилiндр з радiусом {radius} i висотою {height}";
        }
        public new void Input()
        {
            base.Input();
            Console.Write("Введiть висоту цилiндра: ");
            height = Convert.ToDouble(Console.ReadLine());
        }
        public double CalculateVolume()
        {
            return CalculateArea() * height;
        }
        public new void Display()
        {
            Console.WriteLine(this);
            Console.WriteLine($"Площа основи: {CalculateArea()}");
            Console.WriteLine($"Об'єм: {CalculateVolume()}");
        }
    }
}
