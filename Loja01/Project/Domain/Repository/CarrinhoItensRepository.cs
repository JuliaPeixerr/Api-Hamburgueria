using Loja01.Project.Database;
using Loja01.Project.Domain.Models;
using Loja01.Project.Domain.Repository.Interfaces;

namespace Loja01.Project.Domain.Repository
{
    public class CarrinhoItensRepository : Repository<CarrinhoItens>, ICarrinhoItensRepository
    {
        public CarrinhoItensRepository(ProjectContext context) : base(context)
        {
        }
    }
}
