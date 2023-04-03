
namespace CalculoGeometrico
{
    internal class Triangulo
    {
        public double A, B, C;

        public Triangulo()
        {

        }
        public static double Area(double A, double B, double C)
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}
