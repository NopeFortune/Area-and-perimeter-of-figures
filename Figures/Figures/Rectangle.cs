using System;

namespace Figures
{
    public class Rectangle : Figure
    {
        private double A;
        private double B;

        public Rectangle(double a, double b)
        {
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
    }
}
