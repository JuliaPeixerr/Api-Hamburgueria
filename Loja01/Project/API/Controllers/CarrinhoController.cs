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

        [HttpGet("itens/all")]
        public ActionResult GetAllItens()
            => Ok(Service.GetAllItens());

        [HttpPost("item/alter/quantidade")]
        public ActionResult AlterQuantidade([FromBody] AlterQuantidadeCommand command)
        {
            Service.AlterQuantidade(command);
            return Ok();
        }

        [HttpPost("item/remove")]
        public ActionResult Remove([FromBody] RemoveItemCommand command)
        {
            Service.Remove(command);
            return Ok();
        }

        [HttpPost("finalize")]
        public ActionResult Finalize()
        {
            Service.Finalize();
            return Ok();
        }
    }
}
