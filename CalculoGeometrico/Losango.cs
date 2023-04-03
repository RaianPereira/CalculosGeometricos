using System.Globalization;

namespace CalculoGeometrico
{
    internal class Losango
    {
        public double dMaior;
        public double dMenor;


        public Losango() 
        {

        }

        public double area()
        {
            return dMaior * dMenor / 2.00;
        }


        public override string ToString()
        {
            return "Área do Losango é: "
                + area().ToString("F3", CultureInfo.InvariantCulture);
        }
    }
}
