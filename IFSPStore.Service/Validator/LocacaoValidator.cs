using FluentValidation;
using IFSPStore.Domain.Entities;
namespace IFSPStore.Service.Validator
{
    public class LocacaoValidator : AbstractValidator<Locacao>
    {
        public LocacaoValidator()
        {
            RuleFor(s => s.DataLocacao)
                .NotEmpty().NotNull()
                .WithMessage("Data de locação é obrigatório");
            RuleFor(s => s.DataDevolucao)
                .NotEmpty().NotNull()
                .WithMessage("Data de devolução é obrigatório");
            RuleFor(s => s.ValorTotal)
                .NotEmpty().NotNull()
                .WithMessage("Valor total é obrigatório");
            RuleFor(s => s.NumDiarias)
                .NotEmpty().NotNull()
                .WithMessage("Numero de diarias é obrigatório");
            RuleFor(s => s.ClienteId)
                .GreaterThan(0)
                .WithMessage("Cliente é obrigatório");
            RuleFor(s => s.FuncionarioId)
                .GreaterThan(0)
                .WithMessage("Vendedor é obrigatório");
        }
    }
}
