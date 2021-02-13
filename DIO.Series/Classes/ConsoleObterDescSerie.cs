// Entidade: 		Digital Innovation One - Bootcamp MRV .NET Developer
// Programadora: 	Rosemeire Deconti
// Data: 			Fevereiro/2021
// Aplicação: 		CRUD Console Series e Filmes
// Código:			Programa principal que interage com usuário através da console - Trata descrição

using System;

namespace DIO.Series
{
    internal class ConsoleObterDescSerie
    {
        public string consoleObterDescSerie()
        {

            Console.Write("****** DIOFLIX ****** Digite um resumo da série: ");
            string entradaDescricao = Console.ReadLine();
            return entradaDescricao;

        }

        public static implicit operator string(ConsoleObterDescSerie v)
        {

            Console.Write("****** DIOFLIX ****** Digite um resumo da série: ");
            string entradaDescricao = Console.ReadLine();
            return entradaDescricao;
            
        }
    }
}