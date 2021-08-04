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
    }
}
