using System;

namespace Figures
{
    public class Rhomb : Figure
    {
        private double A;
        private double H;

        public Rhomb(double a, double h)
        {
            CanExist(a, h);
            A = a;
            H = h;
        }

        public override double Area()
        {
            return 4 * A;
        }

        public override double Perimeter()
        {
            return A * H;
        }

        public void CanExist(double a, double h)
        {
            if (a <= 0 || h <= 0)
            {
                throw new RhombException("Сторона и/или высота должна быть положительным числом и больше нуля.");
            }
        }
    }
}
