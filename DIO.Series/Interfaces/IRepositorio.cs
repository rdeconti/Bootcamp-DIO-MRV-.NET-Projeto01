<<<<<<< HEAD
// Entidade: 		Digital Innovation One - Bootcamp MRV .NET Developer
// Programadora: 	Rosemeire Deconti
// Data: 			Fevereiro/2021
// Aplicação: 		CRUD Console Series e Filmes
// Código:			Interface para tratar as Séries ("assinatura de contrato" utilizada pelas classes)

=======
>>>>>>> 56a35f6b7d8b5ab8e13e279e29d19d215c93fd68
using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Exclui(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}