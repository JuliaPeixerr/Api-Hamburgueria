using Loja01.Project.Database.Finder;
using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Infrastructure.Facade;
using Loja01.Project.Domain.Models;
using Loja01.Project.Domain.Query;
using Loja01.Project.Domain.Repository;
using Loja01.Project.Domain.Repository.Interfaces;

namespace Loja01.Project.Infrastructure.Facade
{
    public class ProdutoFacade : IProdutoFacade
    {
        private IProdutoRepository _repository;

        public ProdutoFacade(IProdutoRepository repository)
            => (_repository) = (repository);

        public IList<Produto> GetAll(GetAllProdutosQuery query)
            => _repository.GetAll(new GenericProdutoFinder()
                .Descricao(query.Descricao).ToExpression());

        public Produto Save(int id, SaveProdutoCommand command)
        {
            var prod = Get(id);
            prod.Descricao = command.Descricao;
            _repository.Update(prod);
            return prod;
        }

        public Produto? Get(int id)
            => _repository.Get(id);
    }
}
