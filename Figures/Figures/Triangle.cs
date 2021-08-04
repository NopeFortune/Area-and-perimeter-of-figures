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
    }
}
