using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Infrastructure.Facade;
using Microsoft.AspNetCore.Mvc;

namespace Loja01.Project.API.Controllers
{
    [ApiController]
    [Route(URL)]
    public class CarrinhoController : ControllerBase
    {
        public const string URL = "Carrinho";

        private ICarrinhoFacade Service;

        public CarrinhoController(ICarrinhoFacade service)
            => Service = service;

        [HttpPost("add/item")]
        public ActionResult AddItem([FromBody] AddItenCommand command)
            => Ok(Service.AddItem(command));
    }
}
