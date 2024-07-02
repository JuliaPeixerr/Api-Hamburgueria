using Loja01.Project.Database.NovaPasta;
using Loja01.Project.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Loja01.Project.Database
{
    public class ProjectContext : DbContext
    {
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Carrinho> Carrinho { get; set; }
        public virtual DbSet<CarrinhoItens> CarrinhoItens { get; set; }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
