using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioPratico4POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeNumber = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double receive = hour * salary;

            Console.WriteLine("NUMBER = " + employeeNumber);
            Console.WriteLine("SALARY = U$ " + receive.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
