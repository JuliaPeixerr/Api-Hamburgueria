namespace Loja01.Project.Domain.Command
{
    public class SaveClienteCommand
    {
        public int? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? CPF { get; set; }
        public DateTime? Nascimento { get; set; }
    }
}
