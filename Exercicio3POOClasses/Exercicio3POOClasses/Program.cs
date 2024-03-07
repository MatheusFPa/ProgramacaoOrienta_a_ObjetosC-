using System;
using System.Globalization;

namespace Exercicio3POOClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();


            Console.Write("Nome do aluno: ");
            aluno.NomeAluno = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            

            if (aluno.NotaFinal() > 60)
            {
                Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString(), "F2", CultureInfo.InvariantCulture);
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString(), "F2", CultureInfo.InvariantCulture);
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM =  " + aluno.Resto().ToString() + " PONTOS", "F2", CultureInfo.InvariantCulture);
            }
        }
    }
}
