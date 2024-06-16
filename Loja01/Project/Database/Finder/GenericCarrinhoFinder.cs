using Loja01.Project.Domain.Models;
using System.Linq.Expressions;

namespace Loja01.Project.Database.Finder
{
    public class GenericCarrinhoFinder
    {
        private int? _id;
        private bool? _isFinalizado;

        public GenericCarrinhoFinder Id(int? id)
        {
            _id = id;
            return this;
        }

        public GenericCarrinhoFinder IsFinalizado(bool? isFinalizado)
        {
            _isFinalizado= isFinalizado;
            return this;
        }

        public Expression<Func<Carrinho, bool>> ToExpression()
            => (carrinho) => (_id == null || carrinho.Id == _id) &&
            (_isFinalizado == null || carrinho.Finalizado == (_isFinalizado.Value ? "S" : "N"));
    }
}
