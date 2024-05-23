using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Models;
using Loja01.Project.Domain.Query;

namespace Loja01.Project.Domain.Infrastructure.Facade
{
    public interface IProdutoFacade
    {
        IList<Produto> GetAll(GetAllProdutosQuery query);
        Produto Save(int id, SaveProdutoCommand command);
    }
}
