// Entidade: 		Digital Innovation One - Bootcamp MRV .NET Developer
// Programadora: 	Rosemeire Deconti
// Data: 			Fevereiro/2021
// Aplicação: 		CRUD Console Series e Filmes
// Código:			Programa principal que interage com usuário através da console - Trata ano

using System;

namespace DIO.Series
{
    internal class ConsoleObterAnoSerie
    {
        public int consoleObterAnoSerie()
        {

            Console.Write("****** DIOFLIX ****** Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            return entradaAno;

        }

        public static implicit operator int(ConsoleObterAnoSerie v)
        {

            Console.Write("****** DIOFLIX ****** Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            return entradaAno;
            
        }
    }
}