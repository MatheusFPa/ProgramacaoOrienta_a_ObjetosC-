using System;
using System.Globalization;

namespace Exercicio1POORetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");

            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + ret.Area().ToString("f2"));
            Console.WriteLine("Perímetro = " + ret.Perimetro().ToString("f2"));
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("f2"));


        }
    }
}
