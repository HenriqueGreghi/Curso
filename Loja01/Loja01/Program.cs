using System;
using System.Collections.Generic;
using Loja01.Entitis;
using System.Globalization;

namespace Loja01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            Console.Write("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string Nome = Console.ReadLine();
                Console.Write("Price:");
                double Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Customs fee:");
                    double taxaImportação = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ProdutoImportado(Nome, Valor, taxaImportação));
                }
                else if (type == 'c')
                {
                    lista.Add(new Produto(Nome, Valor));

                }
                else
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime DataFabricacao = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(Nome, Valor, DataFabricacao));
                }



            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Produto prod in lista)
            {
                Console.WriteLine(prod.ValorEtiqueta());
            }
        }
    }
}
