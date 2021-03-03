// Entidade: 		Digital Innovation One - Bootcamp MRV .NET Developer
// Programadora: 	Rosemeire Deconti
// Data: 			Fevereiro/2021
// Aplicação: 		CRUD Console Series e Filmes
// Código:			Programa principal que interage com usuário através da console

using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        // ------------------------------------------------------------ Interage com usuário e trata a opção desejada
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

					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

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

			var serie = repositorio.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}

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
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}

        // ------------------------------------------------------------ Interage com usuário e Lista as séries
        private static void ListarSeries()
		{

            Console.WriteLine("****** DIOFLIX ****** Você escolheu: Listar todas as séries");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("****** DIOFLIX ****** Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

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
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novaSerie);
		}

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

			return opcaoUsuario;
		}
    }
}
