using System;

namespace Figures
{
    public class Square : Figure
    {
        private double A;

        public Square(double a)
        {
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
    }
}
