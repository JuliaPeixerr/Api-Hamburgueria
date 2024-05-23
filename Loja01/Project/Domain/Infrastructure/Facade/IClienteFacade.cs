using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Models;

namespace Loja01.Project.Domain.Infrastructure.Facade
{
    public interface IClienteFacade
    {
        Cliente Login(LoginClienteCommand command);
        void Save(SaveClienteCommand command);
        Cliente Create(SaveClienteCommand command);
    }
}
