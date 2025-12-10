using IFSPStore.Domain.Entities;

namespace IFSPStore.App.Models
{
    public class CarroModel
    {
        public string? Nome { get; set; }
        public decimal Diaria { get; set; }
        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public int Ano { get; set; }
        public string? Cor { get; set; }
        public DateTime DataAquisicao { get; set; }
        public bool Disponivel { get; set; }
        public string? Status { get; set; }
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

    }
}
