using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cores
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnCores retCor = new ReturnCores();

            string azul = retCor.CorAz();
            Console.WriteLine(azul);

            string blackinho = retCor.CorBlackinho();
            Console.WriteLine(blackinho);

         
        }
    }
}
