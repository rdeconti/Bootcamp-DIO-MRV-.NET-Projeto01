<<<<<<< HEAD
// Entidade: 		Digital Innovation One - Bootcamp MRV .NET Developer
// Programadora: 	Rosemeire Deconti
// Data: 			Fevereiro/2021
// Aplicação: 		CRUD Console Series e Filmes
// Código:			Classe "SerieRepositorio" herda Interface "IRepositorio" para realizar CRUD

=======
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
<<<<<<< HEAD
        // -------------------------------------- Cria instância Série
        private List<Serie> listaSerie = new List<Serie>();

        // -------------------------------------- Atualiza a série com os dados informados pelo usuário
        public void Atualiza(int id, Serie objeto)
=======
        private List<Serie> listaSerie = new List<Serie>();
		public void Atualiza(int id, Serie objeto)
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
		{
			listaSerie[id] = objeto;
		}

<<<<<<< HEAD
        // -------------------------------------- Atualiza a série com marcação de registro exlcuído
        public void Exclui(int id)
=======
		public void Exclui(int id)
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
		{
			listaSerie[id].Excluir();
		}

<<<<<<< HEAD
        // -------------------------------------- Inclui a série informada pelo usuário
        public void Insere(Serie objeto)
=======
		public void Insere(Serie objeto)
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
		{
			listaSerie.Add(objeto);
		}

<<<<<<< HEAD
        // -------------------------------------- Obtém a lista de séries
        public List<Serie> Lista()
=======
		public List<Serie> Lista()
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
		{
			return listaSerie;
		}

<<<<<<< HEAD
        // -------------------------------------- Obtém o número de séries existentes para determinar o próximo ID de série
        public int ProximoId()
=======
		public int ProximoId()
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
		{
			return listaSerie.Count;
		}

<<<<<<< HEAD
        // -------------------------------------- Retorna a série escolhida pelo usuário
        public Serie RetornaPorId(int id)
=======
		public Serie RetornaPorId(int id)
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
		{
			return listaSerie[id];
		}
	}
}