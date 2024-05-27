using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja01.Project.Domain.Models
{
    [Table("Carrinho")]
    public class Carrinho
    {
        [Key]
        [Column("Car_Codigo")]
        public int Id { get; set; }

        [Column("Car_Valor")]
        public double? Valor { get; set; }
        
        [Column("Car_Data")]
        public DateTime? Data { get; set; }

        [Column("Car_Finalizado")]
        public bool? Finalizado { get; set; }

        [Column("Car_Data_Finalizado")]
        public DateTime? DataFinalizado { get; set; }
    }
}
