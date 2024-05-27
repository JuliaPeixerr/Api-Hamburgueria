using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Infrastructure.Service;
using Loja01.Project.Domain.Models;
using Loja01.Project.Domain.Repository.Interfaces;

namespace Loja01.Project.Infrastructure.Service
{
    public class AddItemService : IAddItemService
    {
        private ICarrinhoRepository _repository;
        private IProdutoRepository _produtoRepository;
        private ICarrinhoItensRepository _itensRepository;

        public AddItemService(
            ICarrinhoRepository repository,
            IProdutoRepository produtoRepository,
            ICarrinhoItensRepository itensRepository)
            => (_repository, _produtoRepository, _itensRepository)
            = (repository, produtoRepository, itensRepository);

        public Carrinho Execute(AddItenCommand command)
        {
            var carrinho = new Carrinho();
            var produto = _produtoRepository.Get(command.CodigoProduto.Value);

            if (!command.CodigoCarrinho.HasValue)
                carrinho = BuildCarrinho(produto);
            else
                carrinho = GetCarrinho(command.CodigoCarrinho.Value);

            var item = new CarrinhoItens();
            item.Id = GetLastId();
            item.CodigoCarrinho = command.CodigoCarrinho;
            item.CodigoProduto = command.CodigoProduto;
            item.Quantidade = 1;
            item.ValorUnitario = produto.Valor;
            item.ValorTotal = produto.Valor;

            _itensRepository.Create(item);
            return carrinho;
        }

        private Carrinho BuildCarrinho(Produto produto)
        {
            var carrinho = new Carrinho();

            carrinho.Valor = produto.Valor;
            carrinho.Data = DateTime.Now;
            carrinho.Finalizado = false;

            _repository.Create(carrinho);
            return carrinho;
        }

        private int GetLastId()
        {
            IList<CarrinhoItens> all = _itensRepository.GetAll();

            var user = all.Reverse().FirstOrDefault();
            if (user != null)
                return user.Id + 1;
            return 1;
        }

        private Carrinho GetCarrinho(int id)
            => _repository.Get(id);
    }
}
