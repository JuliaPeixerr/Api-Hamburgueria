using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Models;

namespace Loja01.Project.Domain.Infrastructure.Service
{
    public interface IAddItemService
    {
        Carrinho Execute(AddItenCommand command);
    }
}
