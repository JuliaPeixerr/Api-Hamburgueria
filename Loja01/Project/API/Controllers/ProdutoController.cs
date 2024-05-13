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
        private ProdutoRepository _repository;

        public ProdutoController(ProdutoRepository repository)
            => _repository = repository;

        [HttpGet("{id}")]
        public ActionResult<Produto> Get(int id)
        {
            var result = _repository.FirstOrDefaultById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
