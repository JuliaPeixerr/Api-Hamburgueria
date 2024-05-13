using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja01.Project.Domain.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        [Column("Pro_Codigo")]
        public int Id { get; set; }

        [Column("Pro_Descricao")]
        public string? Descricao { get; set; }
    }
}
