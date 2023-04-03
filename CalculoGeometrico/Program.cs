using System;
using System.Globalization;


namespace CalculoGeometrico
{
    class Calculo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Deseja calcular?");
            Console.WriteLine("1 - Área do Triângulo      2 - Área do Retângulo      3 - Área da Circunferência      4 - Área do Circulo      5 - Área do Quadrado      6 - Área Trapézio      7 - Área do Losango      8 - Delta");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.Write("Digite o valor de A: ");
                    double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Digite o valor de B: ");
                    double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Digite o valor de C: ");
                    double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Triangulo t = new Triangulo();

                    double result = Triangulo.Area(A, B, C);

                    Console.WriteLine("O valor da Área é: " + result.ToString("F3", CultureInfo.InvariantCulture));
                    break;

                case 2:

                    Retangulo R = new Retangulo();

                    Console.WriteLine("Vamos descobrir a área, perímetro e diagonal do Retângulo:");
                    Console.Write("Digite a largura do retângulo: ");
                    R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Digite a altura do retângulo: ");
                    R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                    Console.WriteLine();
                    Console.WriteLine(R);

                    break;

                case 3:


                    Console.WriteLine("Vamos descobrir a Circunferência, volume e valor de PI");
                    Console.Write("Digite o raio: ");
                    double raio = double.Parse(Console.ReadLine());

                    double cir = Circunferencia.CircunferenciaRaio(raio);
                    double vol = Circunferencia.Volume(raio);

                    Console.WriteLine("Circunferência: " + cir.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Valor de PI:" + Circunferencia.pi.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 4:

                    Circulo Circ = new Circulo();

                    Console.WriteLine("Vamos descobrir as áreas do circulo");
                    Console.Write("Digte o valor do raio ou perimetro: ");
                    double raioCirculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Digite o valor de pi desejado para essa operação: ");
                    double pi = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    

                    Console.WriteLine(Circ);

                    break;

                case 5:

                    Quadrado q = new Quadrado();

                    Console.WriteLine("Vamos calcular a área é a diagonal do quadrado:");
                    Console.Write("Digite o valor do lado: ");
                    q.Lado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine(q);

                    break;


                case 6:

                    Trapezio trap = new Trapezio();

                    Console.WriteLine("Digite o valor da base maior, base menor é altura:");
                    string[] trapVet = Console.ReadLine().Split(' ');
                    trap.baseMaior = double.Parse(trapVet[0], CultureInfo.InvariantCulture);
                    trap.baseMenor = double.Parse(trapVet[1], CultureInfo.InvariantCulture);
                    trap.Altura = double.Parse(trapVet[2], CultureInfo.InvariantCulture);

                    Console.WriteLine(trap);

                    break;

                case 7:

                    Losango los = new Losango();

                    Console.WriteLine("Digite o valor da diagonal maior é a diagonal menor:");
                    string[] losVet = Console.ReadLine().Split(' ');
                    los.dMaior = double.Parse(losVet[0], CultureInfo.InvariantCulture);
                    los.dMenor = double.Parse(losVet[1], CultureInfo.InvariantCulture);


                    Console.WriteLine(los);



                    break;

                case 8:

                    Console.WriteLine("Vamos calcular Delta e as suas raizes");
                    Console.Write("Digite o valor de A: ");
                    double deltaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Digite o valor de B: ");
                    double deltaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Digite o valor de C: ");
                    double deltaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double resulDelta = Delta.CalculoDelta(deltaA, deltaB, deltaC);

                    Console.WriteLine();
                    Console.WriteLine("O valor de Delta é: " + resulDelta.ToString("F2", CultureInfo.InvariantCulture));

                    if (resulDelta >= 0)
                    {
                        double x1 = (-deltaB + Math.Sqrt(resulDelta)) / 2.00 * deltaA;
                        double x2 = (-deltaB - Math.Sqrt(resulDelta)) / 2.00 * deltaA;
                        Console.WriteLine();
                        Console.WriteLine("O valor de X1 é: " + x1.ToString("F2", CultureInfo.InvariantCulture) + " O valor de X2 é : " + x2.ToString
                            ("F2", CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        Console.WriteLine("Essa equação não possui raízes reais");
                    }
                    

                    break;

                default:
                    Console.WriteLine("Opção Invalida");
                    break;
            }
        }
    }       
}

