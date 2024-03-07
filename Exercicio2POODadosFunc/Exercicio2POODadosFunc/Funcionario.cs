using System.Globalization;

namespace Exercicio2POODadosFunc
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SubImposto()
        {
            return Salario - Imposto;
        }
        public void Porcentagem(double percent)
        {
            Salario += Salario * (percent / 100);
        }


        public override string ToString()
        {
            return Nome + ", $" + SubImposto().ToString("f2");
        }

    }
}
