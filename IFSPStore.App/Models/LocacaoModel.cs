using IFSPStore.Domain.Entities;

namespace IFSPStore.App.Models
{
    public class LocacaoModel
    {
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public decimal ValorTotal { get; set; }
        public int NumDiarias { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario? Funcionario { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public List<CarrosAlugadosModel> CarrosAlugados { get; set; }

    }
    public class CarrosAlugadosModel
    {
        public int LocacaoId { get; set; }
        public virtual Locacao? Locacao_ { get; set; }
        public int CarroId { get; set; }
        public virtual Carro? Carro { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal ValorTotalLoc { get; set; }
        public decimal Quantidade { get; set; }
    }
}
