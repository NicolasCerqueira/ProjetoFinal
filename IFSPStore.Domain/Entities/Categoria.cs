using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Categoria : BaseEntity<int>
    {
        public Categoria()
        {
            
        }
        public Categoria(string nome, string descricao) : base()
        {
            Nome = nome;
            Descricao = descricao;
        }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
    }
}
