using System;

namespace FigureLib.Figures
{
    public class Circle : Base
    {
        private double _radius;

        internal Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("radius", "Радиус должен быть не меньше нуля");
                _radius = value;
            }
        }

        public override double Square
        {
            get
            {
                return  Math.PI * Math.Pow(Radius, 2);
            }
        }
    }
}
