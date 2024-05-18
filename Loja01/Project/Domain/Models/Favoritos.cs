using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja01.Project.Domain.Models
{
    [Table("Favoritos")]
    public class Favoritos
    {
        [Key]
        [Column("Fav_Codigo")]
        public int Id { get; set; }
        
        [Column("Fav_Cod_Cliente")]
        public int? CodigoCliente { get; set; }

        [Column("Fav_Cod_Produto")]
        public int? CodigoProduto { get; set; }
    }
}
