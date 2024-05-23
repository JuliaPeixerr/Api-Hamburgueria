using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Infrastructure.Facade;
using Microsoft.AspNetCore.Mvc;

namespace Loja01.Project.API.Controllers
{
    [ApiController]
    [Route(URL)]
    public class ClienteController : ControllerBase
    {
        public const string URL = "Cliente";

        private IClienteFacade Service;

        public ClienteController(IClienteFacade service)
            => Service = service;

        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginClienteCommand command)
            => Ok(Service.Login(command));

        [HttpPost("save")]
        public ActionResult Save([FromBody] SaveClienteCommand command)
        {
            Service.Save(command);
            return Ok();
        }

        [HttpPost("create")]
        public ActionResult Create([FromBody] SaveClienteCommand command)
            => Ok(Service.Create(command));
    }
}
