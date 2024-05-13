using Loja01.Project.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Loja01.Project.Database
{
    public class ProjectContext : DbContext
    {
        public virtual DbSet<Produto> Produto { get; set; }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }
    }
}
