namespace CadastroFundos_api.Models
{
    public class Usuario: BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
