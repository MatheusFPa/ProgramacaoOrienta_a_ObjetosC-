using System;
using System.Globalization;

namespace Exercicio3POOClasses
{
    class Aluno
    {
        public string NomeAluno;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double Resto()
        {
            return (NotaFinal() - 60.0) * -1;
        }

    }
}
