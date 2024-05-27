using Loja01.Project.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Loja01.Project.Database.NovaPasta
{
    public class CarrinhoMapper : IEntityTypeConfiguration<Carrinho>
    {
        public void Configure(EntityTypeBuilder<Carrinho> builder)
        {
            var stringToBoolConverter = new ValueConverter<string, bool>(
                v => v == "S", v => v ? "S" : "N");

            builder.Property(c => c.Finalizado)
                .HasConversion(stringToBoolConverter);
        }
    }
}
