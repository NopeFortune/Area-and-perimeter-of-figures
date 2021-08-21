using System;

namespace Figures
{
    public class Square : Figure
    {
        private double A;

        public Square(double a)
        {
            CanExist(a);
            A = a;
        }

        public override double Area()
        {
            return Math.Pow(A, 2);
        }

        public override double Perimeter()
        {
            return 4 * A;
        }

        public void CanExist(double a)
        {
            if (a <= 0)
            {
                throw new SquareException("Сторона должна быть положительным числом и больше нуля.");
            }
        }
    }
}
