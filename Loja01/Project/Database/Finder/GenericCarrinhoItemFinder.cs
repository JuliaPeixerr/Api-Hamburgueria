using Loja01.Project.Domain.Models;
using System.Linq.Expressions;

namespace Loja01.Project.Database.Finder
{
    public class GenericCarrinhoItemFinder
    {
        private int? _codigoCarrinho;

        public GenericCarrinhoItemFinder CodigoCarrinho(int? codigoCarrinho)
        {
            _codigoCarrinho = codigoCarrinho;
            return this;
        }

        public Expression<Func<CarrinhoItens, bool>> ToExpression()
            => (item) => (_codigoCarrinho == null || item.CodigoCarrinho == _codigoCarrinho);
    }
}
