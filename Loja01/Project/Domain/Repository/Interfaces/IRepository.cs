using Loja01.Project.Domain.Models;
using System.Linq.Expressions;

namespace Loja01.Project.Domain.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        T? Get(int id);
        T? Get(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
