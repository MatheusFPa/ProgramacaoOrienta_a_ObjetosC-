using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopsDoDidi
{
    class Program
    {

        static void Main(string[] args)
        {

            string result = Numeros(1, 4);
            Console.WriteLine(result);
        }
        public static string Numeros(int A, int B)
        {
            if (A > B)
            {
                return "O maior valor é: " + A;
            }
            else return "O maior valor é: " + B;

        }

    }
}
