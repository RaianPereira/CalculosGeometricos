namespace CalculoGeometrico
{
    internal class Circunferencia
    {
        public static double pi = 3.14;


        public static double Volume (double r)
        {
            return 4.0 / 3.0 * pi - Math.Pow(r, 3);
        }


        public static double CircunferenciaRaio(double r)
        {
            return 2.0 * pi * r;
        }
    }
}
