using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public  class Carro : BaseEntity<int>
    {
        public Carro()
        {
            
        }
        public Carro(int id, string nome, decimal diaria, string placa, 
            string modelo, string marca, int ano, string cor, DateTime dataAquisicao, 
            bool disponivel, string status, Categoria category) : base(id)
        {
            Nome = nome;
            Diaria = diaria;
            Placa = placa;
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            Cor = cor;
            DataAquisicao = dataAquisicao;
            Disponivel = disponivel;
            Status = status;
        }

        public string Nome { get; set; }
        public decimal Diaria { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public DateTime DataAquisicao { get; set; }
        public bool Disponivel { get; set; }
        public string Status { get; set; }
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}