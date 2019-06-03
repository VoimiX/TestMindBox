using System;
using System.Collections.Generic;
using System.Linq;

namespace FigureLib.Figures
{
    public class Triange : Base
    {
        internal Triange(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Radius { get; private set; }

        public double A {get; set;}
        public double B { get; set; }
        public double C { get; set; }

        public bool IsRectangular
        {
            get
            {
                const double error = 0.01;// погрешность
                
                if (A == B && A == C && B == C) //если все стороны равны, то это точно не прямоуг. треугольник
                {
                    return false;
                }

                var sides = new List<double>() { A, B, C };
                var g = sides.Max(); //гипотенуза
                for (int i = 0; i < sides.Count(); i++)
                {
                    if (sides[i] == g)
                    {
                        sides.RemoveAt(i);
                        break;
                    }
                }

                var gCalc = Math.Sqrt(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));

                return Math.Abs(g - gCalc) < error;
            }
        }

        public override double Square
        {
            get
            { 
                double p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
    }
}
