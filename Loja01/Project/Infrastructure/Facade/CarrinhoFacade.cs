using Loja01.Project.Database.Finder;
using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Infrastructure.Facade;
using Loja01.Project.Domain.Infrastructure.Service;
using Loja01.Project.Domain.Models;
using Loja01.Project.Domain.Models.NovaPasta;
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

        public IList<ItemProdutoDto> GetAllItens()
        {
            IList<ItemProdutoDto> dto = new List<ItemProdutoDto>();

            var carrinho = _repository.Get(new GenericCarrinhoFinder()
                .IsFinalizado(false).ToExpression());

            if (carrinho == null)
                return null;

            var itens = _itensRepository.GetAll(new GenericCarrinhoItemFinder()
                .CodigoCarrinho(carrinho.Id).ToExpression());

            foreach (var item in itens)
            {
                dto.Add(new ItemProdutoDto
                {
                    CarrinhoItens = item,
                    Produto = GetProduto(item.CodigoProduto.Value)
                });
            }

            return dto;
        }

        private Produto GetProduto(int id)
            => _produtoRepository.Get(id);

        public void AlterQuantidade(AlterQuantidadeCommand command)
        {
            var item = _itensRepository.Get(command.Id);

            if (command.IsSoma)
                item.Quantidade++;
            else
            {
                if (item.Quantidade == 0) return;

                item.Quantidade--;
            }

            _itensRepository.Update(item);
        }

        public void Remove(RemoveItemCommand command)
            => _itensRepository.Delete(command.Id);
    }
}
