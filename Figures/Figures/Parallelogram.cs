using System;

namespace Figures
{
    public class Parallelogram : Figure
    {
        private double A;
        private double B;
        private double H;

        public Parallelogram(double a, double b, double h)
        {
            CanExist(a,b,h);
            A = a;
            B = b;
            H = h;  
        }
        public override double Area()
        {
            return A * H;
        }

        public override double Perimeter()
        {
            return 2 * (A + B);
        }

        public void CanExist(double a, double b, double h)
        {
            if (a <= 0 || b <= 0 || h <= 0)
            {
                throw new ParallelogramException("Сторона и/или высота должны быть положительным числом.");
            }
        }
    }
}
