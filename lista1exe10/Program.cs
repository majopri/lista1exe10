using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do dólar:");
            double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de dólares:");
            double quantidadeDolares = Convert.ToDouble(Console.ReadLine());

            double valorEmReais = cotacaoDolar * quantidadeDolares;

            Console.WriteLine("O valor correspondente em Reais é: R$ " + valorEmReais);
        }
    }
}
