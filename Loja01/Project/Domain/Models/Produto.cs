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

        [Column("Pro_Titulo")]
        public string? Titulo { get; set; }

        [Column("Pro_Descricao")]
        public string? Descricao { get; set; }

        [Column("Pro_Valor")]
        public double? Valor { get; set; }

        // METODOSSSSSS

        // get all produtos // busca por descricao

        // metodo para favoritar // desfavoritar

        // metodo para add no carrinho

        // get all que tem no carrinho

        // add quantidade (ou diminuir) do prod (feito no front ?? add um save com prod e quant)
        // excluir do carrinho

        // fechar a compra

        // add forma de pagamento na nota

        // cadastro de usuario // login de usuario
        
    }

    // fazer a parte de formas de pagamento depois
}
