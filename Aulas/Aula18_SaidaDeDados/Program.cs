using System;
using System.Globalization;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            double saldo = 10.35784;
            int idade = 32;
            string nome = "Maria";

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2")); // .toString("F-Quantia de casas que quer exibir")
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); // Isso vai fazer imprimir com pontos ao invés de vírgula

            //Técnica do PLACEHOLDER
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais",nome, idade, saldo);

            //Técnica da INTERPOLAÇÃO
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            Console.ReadLine();
        }
    }
}