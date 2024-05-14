using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Infrastructure.Facade;
using Loja01.Project.Domain.Models;
using Loja01.Project.Domain.Repository;
using Loja01.Project.Domain.Repository.Interfaces;

namespace Loja01.Project.Infrastructure.Facade
{
    public class ProdutoFacade : IProdutoFacade
    {
        private IProdutoRepository _repository;

        public ProdutoFacade(IProdutoRepository repository)
            => (_repository) = (repository);

        public Produto? Get(int id)
            => _repository.GetById(id);

        public IList<Produto> GetAll()
            => _repository.GetAll();

        private int GetLastId()
        {
            var prod = GetAll().Reverse().FirstOrDefault();
            if (prod != null) 
                return prod.Id + 1;
            return 1;
        }

        public Produto Create(SaveProdutoCommand command)
        {
            Produto prod = new Produto();
            prod.Id = GetLastId();
            prod.Descricao = command.Descricao;
            _repository.Add(prod);
            return prod;
        }

        public Produto Save(int id, SaveProdutoCommand command)
        {
            var prod = Get(id);
            prod.Descricao = command.Descricao;
            _repository.Update(prod);
            return prod;
        }
    }
}
