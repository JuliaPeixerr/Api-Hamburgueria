using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Models;
using Loja01.Project.Domain.Models.NovaPasta;

namespace Loja01.Project.Domain.Infrastructure.Facade
{
    public interface ICarrinhoFacade
    {
        Carrinho AddItem(AddItenCommand command);
        IList<ItemProdutoDto> GetAllItens();
        void AlterQuantidade(AlterQuantidadeCommand command);
        void Remove(RemoveItemCommand command);
    }
}
