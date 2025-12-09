using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Funcionario : BaseEntity<int>
    {
        public Funcionario()
        {
            
        }
        public Funcionario(int id, string nome, string login, string senha, 
            string email, DateTime dataRegistro,  DateTime ultimoLogin, bool ativo) 
            : base(id)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
            Email = email;
            DataRegistro = dataRegistro;
            UltimoLogin = ultimoLogin;
            Ativo = ativo;
        }
        //public int? Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime UltimoLogin { get; set; }
        public bool Ativo { get; set; }
    }
}
