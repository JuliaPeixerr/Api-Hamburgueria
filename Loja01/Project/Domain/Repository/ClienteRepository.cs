using Loja01.Project.Database;
using Loja01.Project.Domain.Models;
using Loja01.Project.Domain.Repository.Interfaces;

namespace Loja01.Project.Domain.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ProjectContext context) : base(context)
        {
        }
    }
}
