// Entidade: 		Digital Innovation One - Bootcamp MRV .NET Developer
// Programadora: 	Rosemeire Deconti
// Data: 			Fevereiro/2021
// Aplicação: 		CRUD Console Series e Filmes
// Código:			Classe abstrata "EntidadeBase" para ser herdada em outras classes protegendo a chave dos objetos

namespace DIO.Series
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }

    }
}