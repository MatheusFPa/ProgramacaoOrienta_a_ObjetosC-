using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TesteSurpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            double result = calc.soma(3,5);
            Console.WriteLine(result);




            Console.ReadLine();
        }
    }
}
