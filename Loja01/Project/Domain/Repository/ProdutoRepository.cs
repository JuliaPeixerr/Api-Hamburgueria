using Loja01.Project.Database;
using Loja01.Project.Domain.Models;

namespace Loja01.Project.Domain.Repository
{
    public class ProdutoRepository
    {
        private readonly ProjectContext _context;

        public ProdutoRepository(ProjectContext context)
        {
            _context = context;
        }
        public List<Produto> GetAll()
            => _context.Produto.ToList();

        public Produto? FirstOrDefaultById(int id)
            => _context.Produto.FirstOrDefault(x => x.Id == id);

        public void Add(Produto teste)
        {
            _context.Produto.Add(teste);
            _context.SaveChanges();
        }

        public void Update(Produto teste)
        {
            var entity = FirstOrDefaultById(teste.Id);

            if (entity != null)
                _context.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = FirstOrDefaultById(id);

            if (entity != null)
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
