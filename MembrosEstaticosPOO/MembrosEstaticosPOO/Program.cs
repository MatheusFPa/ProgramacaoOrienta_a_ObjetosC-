using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticosPOO
{
    class Program
    {
        static double Pi = 3.14;                             //circuferencia 2.0 * Pi * r         Volume = (4/3) * Pi * R^3

        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double volume = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circuferencia(raio);
            double vol = Volume(volume);
            Console.WriteLine("Circuferencia: " + circ);
            Console.WriteLine("Volume: " + volume);


        }
        static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double v)
        {
            return 4 / 3 * Pi * Math.Pow(v, 3);
        }
    }
}
