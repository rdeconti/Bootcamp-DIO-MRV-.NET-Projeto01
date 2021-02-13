<<<<<<< HEAD
// Entidade: 		Digital Innovation One - Bootcamp MRV .NET Developer
// Programadora: 	Rosemeire Deconti
// Data: 			Fevereiro/2021
// Aplicação: 		CRUD Console Series e Filmes
// Código:			Classe "Série" herda "EntidadeBase" e tem os construtores e métodos para "Series"

=======
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
<<<<<<< HEAD
        // ------------------------------------------------------------------- Atributos do objeto série
=======
        // Atributos
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;}

<<<<<<< HEAD
        // --------------------------------------------------------------------- Métodos do objeto série
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
=======
        // Métodos
		public Serie(int id, Genero genero, string titulo, string descricao, int ano)
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false;
		}

<<<<<<< HEAD
        // -------------------------------------- Formata os dados a serem exibidos para o usuário
=======
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
<<<<<<< HEAD

=======
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
<<<<<<< HEAD

			return retorno;
		}

        // -------------------------------------- Obtém os dados da série
=======
			return retorno;
		}

>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
        public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
<<<<<<< HEAD

        // -------------------------------------- Atualiza registro com informação de excluído
        public void Excluir() 
		{
=======
        public void Excluir() {
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
            this.Excluido = true;
        }
    }
}