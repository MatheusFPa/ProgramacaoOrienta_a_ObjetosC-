using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioRecapitulacao3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int dif = (A * B - C * D);
            Console.WriteLine("DIFERENCA = " + dif );
            Console.ReadLine();

        }
    }
}
