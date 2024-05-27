using Loja01.Project.Database.Finder;
using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Infrastructure.Facade;
using Loja01.Project.Domain.Models;
using Loja01.Project.Domain.Repository.Interfaces;

namespace Loja01.Project.Infrastructure.Facade
{
    public class ClienteFacade : IClienteFacade
    {
        private IClienteRepository _repository;

        public ClienteFacade(IClienteRepository repository)
            => (_repository) = (repository);

        public Cliente Login(LoginClienteCommand command)
        {
            var user = _repository.Get(new GenericClienteFinder()
                .Nome(command.Usuario).ToExpression());

            if (user != null && user.Senha == command.Senha)
                return user;
            else
                throw new Exception("A informação está errada");
        }

        public Cliente Create(SaveClienteCommand command)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = command.Nome;
            cliente.Email = command.Email;
            cliente.Senha = command.Senha;
            cliente.Id = GetLastId();

            _repository.Create(cliente);
            return cliente;
        }

        public void Save(SaveClienteCommand command)
        {
            var cliente = _repository.Get(command.Codigo.Value);

            cliente.Nome = command.Nome;
            cliente.Email = command.Email;
            cliente.Senha = command.Senha;
            cliente.CPF = command.CPF;
            cliente.DataNascimento = command.Nascimento;

            _repository.Update(cliente);
        }

        private IList<Cliente> GetAll()
            => _repository.GetAll();

        private int GetLastId()
        {
            var user = GetAll().Reverse().FirstOrDefault();
            if (user != null)
                return user.Id + 1;
            return 1;
        }
    }
}
