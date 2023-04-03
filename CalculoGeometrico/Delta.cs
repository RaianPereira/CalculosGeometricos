namespace CalculoGeometrico
{
    internal class Delta
    {
        public double A, B, C;

        public double valorDelta;
        public Delta(double deltaA, double deltaB, double deltaC)
        {
            A = deltaA;
            B = deltaB;
            C = deltaC;

        }

        public static double CalculoDelta(double deltaA, double deltaB, double deltaC)
        {
            return Math.Pow(deltaB, 2) - 4.00 * deltaA * deltaC;
        }


    }
}
