using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC.Dominio.Interfaces.Servicos
{
    public interface IServicoBase<T> : IDisposable where T : class
    {
        IList<T> Buscar(Expression<Func<T, bool>> where);
        IList<T> Buscar(string _include, Expression<Func<T, bool>> where);
        IList<T> ListarTodos();
        void Inserir(T obj);
        void Alterar(T obj);
        void Excluir(T obj);    
    }
}
