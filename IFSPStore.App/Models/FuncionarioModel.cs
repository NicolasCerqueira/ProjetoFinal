namespace IFSPStore.App.Models
{
    public class FuncionarioModel
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public string? Email { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime UltimoLogin { get; set; }
        public bool Ativo { get; set; }
    }
}
