using Loja01.Project.Domain.Command;
using Loja01.Project.Domain.Infrastructure.Facade;
using Loja01.Project.Domain.Models;
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

        [HttpGet("{id}")]
        public ActionResult Get(int id)
            => Ok(Service.Get(id));

        [HttpGet("all")]
        public ActionResult GetAll()
            => Ok(Service.GetAll());

        [HttpPost("create")]
        public ActionResult Create([FromBody] SaveProdutoCommand command)
            => Ok(Service.Create(command));

        [HttpPost("{id}/save")]
        public ActionResult Save(int id, [FromBody] SaveProdutoCommand command)
            => Ok(Service.Save(id, command));
    }
}
