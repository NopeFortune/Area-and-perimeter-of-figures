using System;

namespace Figures
{
    public class Triangle : Figure
    {
        private double A;
        private double B;
        private double C;
        private double H;

        public Triangle(double a, double b, double c, double h)
        {
            CanExist(a, b, c, h);
            A = a;
            B = b;
            C = c;
            H = h;
        }

        public override double Area()
        {
            return 0.5 * B * H;
        }

        public override double Perimeter()
        {
            return A + B + C;
        }

        public void CanExist(double a, double b, double c, double h)
        {
            if (a <= 0 || b <= 0 || c <= 0 || h <= 0)
            {
                throw new TriangleException("Сторона и/или высота должна быть положительным числом и больше нуля.");
            }
            else if (a >= (b + c) || b >= (a + c) || c >= (a + b))
            {
                throw new TriangleException("Одна из сторона должна быть мнеьше, чем сумма двух других сторон.");
            }
        }
    }
}
