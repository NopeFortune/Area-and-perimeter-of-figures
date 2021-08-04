using System;

namespace Figures
{
    public class Rhomb : Figure
    {
        private double A;
        private double H;

        public Rhomb(double a, double h)
        {
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
    }
}
