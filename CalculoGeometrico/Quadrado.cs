using System.Globalization;
namespace CalculoGeometrico
{
    internal class Quadrado
    {
        public double Lado;

        public Quadrado()
        {

        }

        public Quadrado(double l) 
        {
            Lado = l;
        }

        public double area()
        {
            return Math.Pow(Lado, 2);
        }

        public double diagonal() 
        {
            return Lado * Math.Sqrt(2);
        }

        public override string ToString()
        {
            return "Area do quadrado é: "
                + area().ToString("F2", CultureInfo.InvariantCulture)
                +" E sua diagonal: "
                + diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
