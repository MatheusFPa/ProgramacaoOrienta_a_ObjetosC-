using System;
using System.Globalization;

namespace Exercicio2ClassePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario Func1 = new Salario();
            Salario Func2 = new Salario();

            Console.WriteLine("Dados do Primeiro Funcionario:");
            Console.Write("Nome: ");
            Func1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            Func1.SalarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da Segunda Pessoa:");
            Console.Write("Nome: ");
            Func2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            Func2.SalarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (Func1.SalarioFuncionario + Func2.SalarioFuncionario) / 2.0;

            Console.WriteLine("Salário Médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
