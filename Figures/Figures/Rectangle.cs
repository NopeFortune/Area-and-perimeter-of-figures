using System;

namespace Figures
{
    public class Rectangle : Figure
    {
        private double A;
        private double B;

        public Rectangle(double a, double b)
        {
            CanExist(a, b);
            A = a;
            B = b;
        }
        public override double Area()
        {
            return A * B;
        }

        public override double Perimeter()
        {
            return 2 * (A + B);
        }

        public void CanExist(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new RectangleException("Одна из сторон должна быть положительным числом и больше нуля.");
            }
        }
    }
}
