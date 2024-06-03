using Loja01.Project.Database.Finder;
using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Infrastructure.Facade;
using Loja01.Project.Domain.Infrastructure.Service;
using Loja01.Project.Domain.Models;
using Loja01.Project.Domain.Repository;
using Loja01.Project.Domain.Repository.Interfaces;

namespace Loja01.Project.Infrastructure.Facade
{
    public class CarrinhoFacade : ICarrinhoFacade
    {
        private ICarrinhoRepository _repository;
        private IProdutoRepository _produtoRepository;
        private ICarrinhoItensRepository _itensRepository;
        private IAddItemService _addItemService;

        public CarrinhoFacade(ICarrinhoRepository repository,
            IProdutoRepository produtoRepository,
            ICarrinhoItensRepository itensRepository,
            IAddItemService addItemService)
            => (_repository, _produtoRepository, _itensRepository, _addItemService)
            = (repository, produtoRepository, itensRepository, addItemService);

        public Carrinho AddItem(AddItenCommand command)
            => _addItemService.Execute(command);

        public IList<CarrinhoItens> GetAllItens(int id)
            => _itensRepository.GetAll(new GenericCarrinhoItemFinder()
                .CodigoCarrinho(id).ToExpression());
    }
}
