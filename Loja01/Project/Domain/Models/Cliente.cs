using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja01.Project.Domain.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column("Cli_Codigo")]
        public int Id { get; set; }

        [Column("Cli_Nome")]
        public string? Nome { get; set; }

        [Column("Cli_Senha")]
        public string? Senha { get; set; }

        [Column("Cli_Email")]
        public string? Email { get; set; }

        [Column("Cli_CPF")]
        public string? CPF { get; set; }

        [Column("Cli_Nascimento")]
        public DateTime? DataNascimento { get; set; }
    }
}
