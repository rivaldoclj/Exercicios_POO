using System;
using System.Xml;
using System.Globalization;

namespace POO6 {
    class Program {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);
        }
    }
}