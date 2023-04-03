using System.Globalization;
namespace CalculoGeometrico
{
    internal class Circulo
    {
       
        public Circulo()
        {

        }

        
        public double result(double raioCirculo, double pi)
        {
            return (2 * pi) * raioCirculo;
        }

        public override string ToString()
        {
            return "Se você digitou o raio o resultado é o perímetro, se você digitou o perímetro esse valo é o raio: "+
                result;
        }

    }
}
