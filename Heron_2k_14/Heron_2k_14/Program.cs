using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heron_2k_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p, areaP, areaS;
            double pA, pB, pC, sA, sB, sC;

            Console.WriteLine("Coloque as medidas do primeiro triângulo:");
            pA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Coloque as medidas do segundo triângulo:");
            sA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (pA + pB + pC) / 2.0;
            areaP = Math.Sqrt(p * (p - pA) * (p - pB) * (p - pC));


            p = (sA + sB + sC) / 2.0;
            areaS = Math.Sqrt(p * (p - sA) * (p - sB) * (p - sC));

            Console.WriteLine("Área do primeiro triângulo = " + areaP.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do segundo triângulo = " + areaS.ToString("F4", CultureInfo.InvariantCulture));

            if (areaP > areaS)
            {
                Console.WriteLine("Maior área: Primeiro triângulo");
            }
            else if (areaP == areaS)
            {
                Console.WriteLine("Áreas Iguais entre os triângulos");
            }
            else
            {
                Console.WriteLine("Maior área: Segundo triângulo");
            }
        }
    }
}
