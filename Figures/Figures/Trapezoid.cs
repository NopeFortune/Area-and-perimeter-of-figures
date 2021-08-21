using System;

namespace Figures
{
    public class Trapezoid : Figure
    {
        private double A;
        private double B;
        private double C;
        private double D;
        private double H;

        public Trapezoid(double a, double b, double c, double d, double h)
        {
            CanExist(a, b, c, d, h);
            A = a;
            B = b;
            C = c;
            D = d;
            H = h;
        }
        public override double Area()
        {
            return 0.5 * H * (A + B);
        }

        public override double Perimeter()
        {
            return A + B + C + D;
        }

        public void CanExist(double a, double b, double c, double d, double h)
        {
            if (a <= 0 || b <= 0 || c <= 0 || d <= 0 || h <= 0)
            {
                throw new TrapezoidException("Сторона и/или выоста должны быть положительным числом и больше нуля.");
            }
        }
    }
}
