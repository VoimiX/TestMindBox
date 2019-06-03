using FigureLib.Figures;

namespace FigureLib
{
    public static class FigureFabric
    {
        public static Base CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public static Base CreateTriange(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }
    }
}
