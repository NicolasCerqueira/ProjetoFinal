using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validator
{
    public class CidadeValidator : AbstractValidator<Cidade>
    {
        public CidadeValidator() 
        {
            RuleFor(c => c.Nome)
                .NotEmpty().NotNull()
                .WithMessage("Nome da cidade obrigatório");
            RuleFor(c => c.Estado)
                .NotEmpty().NotNull()
                .WithMessage("Nome do estado obrigatótio")
                .Length(2)
                .WithMessage("Estado deve conter 2 caracteres");
        }
    }
}
