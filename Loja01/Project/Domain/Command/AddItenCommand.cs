namespace Loja01.Project.Domain.Command
{
    public class AddItenCommand
    {
        public int Id { get; set; }
        public int? CodigoCarrinho { get; set; }
        public int? CodigoProduto { get; set; }
    }
}
