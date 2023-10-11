using System.Numerics;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           TCircle c = new TCircle();
            c.Input();
            Console.WriteLine();
            c.Output();
            Console.WriteLine();
            TCircle c2 = new TCircle();
            c2.Input();
            Console.WriteLine();
            c2.Output();
            Console.WriteLine();
            TCylinder cylinder = new TCylinder();
            cylinder.Input();
            Console.WriteLine();
            cylinder.Output();
            Console.WriteLine();
            int result = c.CompareTo(c2);

            if (result > 0)
            {
                Console.WriteLine("Перший круг бiльший за другий.");
            }
            else if (result < 0)
            {
                Console.WriteLine("Перший круг менший за другий.");
            }
            else
            {
                Console.WriteLine("Круги мають однаковий радiус.");
            }
            Console.WriteLine();
            Console.Write("Введiть число f: ");
            double f = double.Parse(Console.ReadLine());
            TCircle circleSum = c + c2;
            TCircle circleDiff = c - c2;
            TCircle circleScaled = c * f;
            Console.WriteLine("\nРезультати операцiй з кругами:");
            Console.WriteLine("\nСума першого i другого круга:");
            circleSum.Output();

            Console.WriteLine("\nРiзниця першого i другого круга:");
            circleDiff.Output();

            Console.WriteLine($"\nКруг, помножений на {f}:");
            circleScaled.Output();
        }
    }
}