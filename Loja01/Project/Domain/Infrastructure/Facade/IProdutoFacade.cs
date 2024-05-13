using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Models;

namespace Loja01.Project.Domain.Infrastructure.Facade
{
    public interface IProdutoFacade
    {
        Produto? Get(int id);
        IList<Produto> GetAll();
        Produto Create(SaveProdutoCommand command);
        Produto Save(int id, SaveProdutoCommand command);
    }
}
