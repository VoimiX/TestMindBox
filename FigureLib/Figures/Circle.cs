using System;

namespace FigureLib.Figures
{
    public class Circle : Base
    {
        internal Circle(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException("radius", "Радиус должен быть не меньше нуля");
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double Square
        {
            get
            {
                return  Math.PI * Math.Pow(Radius, 2);
            }
        }
    }
}
