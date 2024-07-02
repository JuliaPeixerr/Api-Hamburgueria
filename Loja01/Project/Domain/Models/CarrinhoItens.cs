using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja01.Project.Domain.Models
{
    [Table("Carrinho_Itens")]
    public class CarrinhoItens
    {
        [Key]
        [Column("CIt_Codigo")]
        public int Id { get; set; }
        
        [Column("CIt_Cod_Carrinho")]
        public int? CodigoCarrinho { get; set; }

        [Column("CIt_Cod_Produto")]
        public int? CodigoProduto { get; set; }

        //[ForeignKey("CodigoProduto")]
        //public virtual Produto? Produto { get; set; }

        [Column("CIt_Quantidade")]
        public int? Quantidade { get; set; }

        [Column("CIt_Valor_Unitario")]
        public double? ValorUnitario { get; set; }

        [Column("CIt_Valor_Total")]
        public double? ValorTotal { get; set; }
    }
}
