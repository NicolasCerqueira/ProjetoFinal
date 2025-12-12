using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validator
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome)
               .NotEmpty().NotNull()
               .WithMessage("Por favor informe o nome.");
            RuleFor(c => c.CNH)
                .NotEmpty().NotNull()
                .WithMessage("Por favor informe a CNH.");
            RuleFor(c => c.Endereco)
                .NotEmpty().NotNull()
                .WithMessage("Por favor informe o endereço.");
            RuleFor(c => c.Documento)
                .NotEmpty().NotNull()
                .WithMessage("Por favor informe o documento.");
            RuleFor(c => c.Bairro)
                .NotEmpty().NotNull()
                .WithMessage("Por favor informe o bairro.");
            RuleFor(c => c.CidadeId)
                .GreaterThan(0)
                .WithMessage("Por favor informe a cidade.");

        }
    }
}

