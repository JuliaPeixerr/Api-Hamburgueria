using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Infrastructure.Facade;
using Loja01.Project.Domain.Models;
using Loja01.Project.Domain.Query;
using Loja01.Project.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Loja01.Project.API.Controllers
{
    [ApiController]
    [Route(URL)]
    public class ProdutoController : ControllerBase
    {
        public const string URL = "produtos";
        private IProdutoFacade Service;

        public ProdutoController(IProdutoFacade service)
            => Service = service;

        [HttpGet("all")]
        public ActionResult GetAll([FromQuery] GetAllProdutosQuery query)
            => Ok(Service.GetAll(query));

        [HttpPost("{id}/save")]
        public ActionResult Save(int id, [FromBody] SaveProdutoCommand command)
            => Ok(Service.Save(id, command));
    }
}
