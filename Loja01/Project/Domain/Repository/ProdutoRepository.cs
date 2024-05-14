
using Loja01.Project.Database;
using Loja01.Project.Domain.Models;
using Loja01.Project.Domain.Repository.Interfaces;

namespace Loja01.Project.Domain.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ProjectContext context) : base(context)
        {
        }
    }
}
