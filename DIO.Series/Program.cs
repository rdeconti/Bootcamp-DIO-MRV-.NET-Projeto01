<<<<<<< HEAD
﻿// Entidade: 		Digital Innovation One - Bootcamp MRV .NET Developer
// Programadora: 	Rosemeire Deconti
// Data: 			Fevereiro/2021
// Aplicação: 		CRUD Console Series e Filmes
// Código:			Programa principal que interage com usuário através da console

using System;
=======
﻿using System;
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
<<<<<<< HEAD

        // ------------------------------------------------------------ Interage com usuário e trata a opção desejada
=======
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarSeries();
						break;
<<<<<<< HEAD

					case "2":
						InserirSerie();
						break;

					case "3":
						AtualizarSerie();
						break;

					case "4":
						ExcluirSerie();
						break;

					case "5":
						VisualizarSerie();
						break;

=======
					case "2":
						InserirSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						ExcluirSerie();
						break;
					case "5":
						VisualizarSerie();
						break;
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

<<<<<<< HEAD
			Console.WriteLine("****** DIOFLIX ****** Obrigado por utilizar nossos serviços !");
			Console.ReadLine();
        }

        // ------------------------------------------------------------ Interage com usuário e exclui a série
        private static void ExcluirSerie()
		{

            Console.WriteLine("****** DIOFLIX ****** Você escolheu: Excluir série");

            // -------------------------------------------------------- Verificar se o ID existe
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            while (indiceSerie > repositorio.ProximoId())
            {
                Console.WriteLine($"Digite o id da série corretamente. Limite máximo: {repositorio.ProximoId()}");
                indiceSerie = int.Parse(Console.ReadLine());
            }

            // -------------------------------------------------------- Confirmar com usuário a exclusão

            Console.WriteLine("Digite SIM para confirmar a exclusão");
            string entradaConfirmação = Console.ReadLine();

			if (entradaConfirmação.ToUpper() == "SIM")
			{
                repositorio.Exclui(indiceSerie);
			}

		}

        // ------------------------------------------------------------ Interage com usuário e visualiza a série
        private static void VisualizarSerie()
		{
            Console.WriteLine("****** DIOFLIX ****** Você escolheu: Visualizar série");

            // -------------------------------------------------------- Verificar se o ID existe
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            while (indiceSerie > repositorio.ProximoId())
            {
                Console.Write($"Digite o id da série corretamente. Limite máximo: {repositorio.ProximoId()}");
                indiceSerie = int.Parse(Console.ReadLine());
            }
=======
			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static void ExcluirSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceSerie);
		}

        private static void VisualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68

			var serie = repositorio.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}

<<<<<<< HEAD
        // ------------------------------------------------------------ Interage com usuário e atualiza a série
        private static void AtualizarSerie()
		{

            Console.WriteLine("****** DIOFLIX ****** Você escolheu: Atualizar série");

            // -------------------------------------------------------- Verificar se o ID existe
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            while (indiceSerie > repositorio.ProximoId())
            {
                Console.Write($"Digite o id da série corretamente. Limite máximo: {repositorio.ProximoId()}");
        		indiceSerie = int.Parse(Console.ReadLine());
			}

            // -------------------------------------------------------- Listar generos das séries no console
            new ConsoleListarGeneroSerie();

            // -------------------------------------------------------- Interage com usuário e obtém os dados
            int entradaGenero = new ConsoleObterGeneroSerie();
            string entradaTitulo = new ConsoleObterTituloSerie();
            int entradaAno = new ConsoleObterAnoSerie();
            string entradaDescricao = new ConsoleObterDescSerie();

            // -------------------------------------------------------- Atualizar a série
            Serie atualizaSerie = new Serie(id: indiceSerie,
=======
        private static void AtualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie atualizaSerie = new Serie(id: indiceSerie,
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}
<<<<<<< HEAD

        // ------------------------------------------------------------ Interage com usuário e Lista as séries
        private static void ListarSeries()
		{

            Console.WriteLine("****** DIOFLIX ****** Você escolheu: Listar todas as séries");
=======
        private static void ListarSeries()
		{
			Console.WriteLine("Listar séries");
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
<<<<<<< HEAD
				Console.WriteLine("****** DIOFLIX ****** Nenhuma série cadastrada.");
=======
				Console.WriteLine("Nenhuma série cadastrada.");
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

<<<<<<< HEAD
        // ------------------------------------------------------------ Interage com usuário e insere a série
        private static void InserirSerie()
		{

            Console.WriteLine("****** DIOFLIX ****** Você escolheu: Inserir série");

            // -------------------------------------------------------- Listar generos das séries no console
            new ConsoleListarGeneroSerie();

            // -------------------------------------------------------- Interage com usuário e obtém os dados
            int entradaGenero = new ConsoleObterGeneroSerie();
			string entradaTitulo = new ConsoleObterTituloSerie();
            int entradaAno = new ConsoleObterAnoSerie();
			string entradaDescricao = new ConsoleObterDescSerie();

            // -------------------------------------------------------- Inserir a série
            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
=======
        private static void InserirSerie()
		{
			Console.WriteLine("Inserir nova série");

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie novaSerie = new Serie(id: repositorio.ProximoId(),
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novaSerie);
		}

<<<<<<< HEAD
		// ------------------------------------------------------------ Interage com usuário: obtém a opção desejada
        private static string ObterOpcaoUsuario()
		{
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
			Console.WriteLine("****** DIOFLIX ****** Estamos a seu dispor ****** DIOFLIX ******");
            Console.WriteLine("****************************************************************");
            Console.WriteLine();

			Console.WriteLine("1 - Listar séries");
			Console.WriteLine("2 - Inserir série");
			Console.WriteLine("3 - Atualizar série");
			Console.WriteLine("4 - Excluir série");
			Console.WriteLine("5 - Visualizar série");
			Console.WriteLine("C - Limpar Tela");
			Console.WriteLine("X - Sair");

			Console.WriteLine();
            Console.WriteLine("****** DIOFLIX ****** Informe o item desejado:");

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();

=======
        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Séries a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
			return opcaoUsuario;
		}
    }
}
