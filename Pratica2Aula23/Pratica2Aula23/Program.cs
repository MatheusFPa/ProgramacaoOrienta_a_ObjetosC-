using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Pratica2Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Entre com seu nome completo:");
            string nome1 = Console.ReadLine();
           //Console.WriteLine($"Quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());
           //Console.WriteLine($"Entre com o preço de um produto:");
            double preco1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine($"Entre com seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string nome2 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome1);
            Console.WriteLine(quarto);
            Console.WriteLine(preco1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


           
        }
    }
}
