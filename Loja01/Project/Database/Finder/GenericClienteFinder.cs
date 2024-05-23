using Loja01.Project.Domain.Models;
using System.Linq.Expressions;

namespace Loja01.Project.Database.Finder
{
    public class GenericClienteFinder
    {
        private string? _nome;

        public GenericClienteFinder Nome(string? nome)
        {
            _nome = nome;
            return this;
        }

        public Expression<Func<Cliente, bool>> ToExpression()
            => (cliente) => (_nome == null || cliente.Nome == _nome);
    }
}
