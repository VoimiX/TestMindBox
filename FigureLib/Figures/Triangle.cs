using System;
using System.Collections.Generic;
using System.Linq;


namespace FigureLib.Figures
{
    public class Triangle : Base
    {
        private double _a;
        private double _b;
        private double _c;

        internal Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A
        {
            get { return _a; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Сторона треугольника должна быть не меньше нуля");
                AllSidesCheck();
                _a = value;
            }
        }

        public double B
        {
            get { return _b; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Сторона треугольника должна быть не меньше нуля");
                AllSidesCheck();
                _b = value;
            }
        }

        public double C
        {
            get { return _c; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Сторона треугольника должна быть не меньше нуля");
                AllSidesCheck();
                _c = value;
            }
        }

        private void AllSidesCheck()
        {
            if (A > 0 && B > 0 && C > 0)
            {
                if (A + B < C || A + C < B || B + C < A)
                    throw new ArgumentOutOfRangeException(
                        "Неправильно заданы стороны треугольника. Такой треугольник не может существовать");
            }
        }

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
