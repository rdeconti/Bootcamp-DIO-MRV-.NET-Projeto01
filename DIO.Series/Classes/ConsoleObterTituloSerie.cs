// Entidade: 		Digital Innovation One - Bootcamp MRV .NET Developer
// Programadora: 	Rosemeire Deconti
// Data: 			Fevereiro/2021
// Aplicação: 		CRUD Console Series e Filmes
// Código:			Programa principal que interage com usuário através da console - Trata titulo

using System;

namespace DIO.Series
{
    internal class ConsoleObterTituloSerie
    {
        public string consoleObterTituloSerie()
        {

            Console.Write("****** DIOFLIX ****** Digite o título da série: ");  
            string entradaTitulo = Console.ReadLine();
            return entradaTitulo;

        }
        public static implicit operator string(ConsoleObterTituloSerie v)
        {

            Console.Write("****** DIOFLIX ****** Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();
            return entradaTitulo;
            
        }
    }
}