using System;

namespace FigureLib.Figures
{
    public class Circle : Base
    {
        internal Circle(double radius)
        {
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
