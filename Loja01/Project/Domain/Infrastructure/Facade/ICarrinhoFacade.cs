using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Models;

namespace Loja01.Project.Domain.Infrastructure.Facade
{
    public interface ICarrinhoFacade
    {
        Carrinho AddItem(AddItenCommand command);
    }
}
