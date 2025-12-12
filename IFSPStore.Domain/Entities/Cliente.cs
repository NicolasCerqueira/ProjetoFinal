using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente()
        {
            
        }
        public Cliente(int id, string nome, int cnh, string endereco, string documento, string bairro, 
            Cidade cidade) : base(id)
        {
            Nome = nome;
            CNH = cnh;
            Endereco = endereco;
            Documento = documento;
            Bairro = bairro;
            Cidade = cidade;
        }

        public string? Nome { get; set; }
        public int CNH { get; set; }
        public string? Endereco { get; set; }
        public string? Documento { get; set; }
        public string? Bairro { get; set; }
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; } //relacionamento

    }
}
