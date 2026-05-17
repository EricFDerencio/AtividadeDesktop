using System.Collections.Generic;
using System;

namespace Reserva_Hotel
{ 
    public interface IRepository<T>
    {
        void Inserir(T entidade);
        void Editar(T entidade); 
        void Deletar(int id);
        IEnumerable<T> ObterTodos();
    }
}