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
    }
}
