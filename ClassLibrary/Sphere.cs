using System;

namespace Core
{
    public class Sphere : IFigure
    {
        private int _radius;
        public Sphere(int radius)
        {
            if (radius <= 0)
            {
                throw new ShapeExeption("Значение радиуса сферы должно быть положительным");
            }
            _radius = radius;//проверкана неотрицательнось
        }
        public double ReturnVolume()
        {
            return 4 / 3.0 * Math.PI * Math.Pow(_radius, 3);
        }
    }
}
