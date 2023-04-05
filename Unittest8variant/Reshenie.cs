using System;
namespace Unittest8variant
{
    public class Reshenie
    {
        public double Example_method(double a, double x, double c, double result)
        {
            result = 0;
            Console.WriteLine("Введите значение a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение c: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение x: ");
            x = double.Parse(Console.ReadLine());

            if (c < 0 && a != 0)
            {
                result = (-a) * Math.Pow(x, 2);
            }
            else
            {
                if (c > 0 && a == 0)
                {
                    result = (a - x) / (c * x);
                }
                else
                {
                    result = -x / (c - a * x);
                }
            }

            return result;


        }
    }
}

