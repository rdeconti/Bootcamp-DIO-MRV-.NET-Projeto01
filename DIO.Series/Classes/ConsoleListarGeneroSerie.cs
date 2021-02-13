// Entidade: 		Digital Innovation One - Bootcamp MRV .NET Developer
// Programadora: 	Rosemeire Deconti
// Data: 			Fevereiro/2021
// Aplicação: 		CRUD Console Series e Filmes
// Código:			Obtém o genero das séries e enviar para o console

using System;

namespace DIO.Series
{
    internal class ConsoleListarGeneroSerie
    {
        public ConsoleListarGeneroSerie()
        {

            Console.WriteLine("****** DIOFLIX ****** Lista de generos disponíveis: ");
            Console.WriteLine();

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

        }
    }
}