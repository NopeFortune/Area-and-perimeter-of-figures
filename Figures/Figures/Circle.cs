using System;

namespace Figures
{
    public class Circle : Figure
    {
        private double Radius;

        public Circle(double radius)
        {
            CanExist(radius);
            Radius = radius;
        }

        public override double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }

        public override double Perimeter()
        {
            return Math.Round((2 * Math.PI * Radius), 1);
        }

        public void CanExist(double radius)
        {
            if (radius <= 0)
            {
                throw new CircleException("Радиус должен быть положительным числом.");
            }
        }
    }
}
