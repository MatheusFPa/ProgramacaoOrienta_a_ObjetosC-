using System;
using System.Globalization;

namespace Exercicio1POORetangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;


        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2.0 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(2.0, Largura) + Math.Pow(2.0, Altura));
        }

    }
}
