using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ExercicioClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados Pessoa1, Pessoa2;

            Pessoa1 = new Dados();
            Pessoa2 = new Dados();

            Console.WriteLine("Dados da primeira Pessoa:");

            Pessoa1.Nome = Console.ReadLine();
            Pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda Pessoa:");
            Pessoa2.Nome = Console.ReadLine();
            Pessoa2.idade = int.Parse(Console.ReadLine());

            if (Pessoa1.idade > Pessoa2.idade)
                Console.WriteLine("Pessoa mais Velha: " + Pessoa1.Nome);
            else
                Console.WriteLine("Pessoa mais Velha: " + Pessoa2.Nome);

        }
    }
}
