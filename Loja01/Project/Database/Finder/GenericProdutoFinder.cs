using Loja01.Project.Domain.Models;
using System.Linq.Expressions;

namespace Loja01.Project.Database.Finder
{
    public class GenericProdutoFinder
    {
        private string? _descricao;

        public GenericProdutoFinder Descricao(string? descricao)
        {
            _descricao = descricao;
            return this;
        }

        public Expression<Func<Produto, bool>> ToExpression()
            => (produto) => (_descricao == null || produto.Descricao.ToLower().Contains(_descricao.ToLower()));
    }
}
