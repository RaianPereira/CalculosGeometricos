using System.Globalization;
namespace CalculoGeometrico
{
    internal class Trapezio
    {
        public double baseMaior;
        public double baseMenor;
        public double Altura;

        public Trapezio() 
        {
            
        }

        public double area()
        {
            return (baseMaior + baseMenor) * Altura / 2.00;
        }

        public override string ToString()
        {
            return "Área do trapezio é: "
                + area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
