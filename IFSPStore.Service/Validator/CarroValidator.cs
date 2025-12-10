using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validator
{
    public class CarroValidator : AbstractValidator<Carro>
    {
        public CarroValidator() 
        {
            RuleFor(p => p.Nome)
                .NotEmpty().NotNull()
                .WithMessage("Nome do produto obrigatório");
            RuleFor(p => p.Diaria) 
                .NotEmpty().NotNull()
                .WithMessage("Diária deve ser informado");
            RuleFor(p => p.Placa)
                .NotEmpty().NotNull()
                .WithMessage("Placa deve ser informada");
            RuleFor(p => p.Modelo)
                .NotEmpty().NotNull()
                .WithMessage("Modelo deve ser informado");
            RuleFor(p => p.Marca)
                .NotEmpty().NotNull()
                .WithMessage("Marca deve ser informado");
            RuleFor(p => p.Ano)
                .NotEmpty().NotNull()
                .WithMessage("Ano deve ser informado");
            RuleFor(p => p.Cor)
                .NotEmpty().NotNull()
                .WithMessage("Cor deve ser informada");
            RuleFor(p => p.DataAquisicao)
                .NotEmpty().NotNull()
                .WithMessage("Data de aquisição deve ser maior que zero");
            RuleFor(p => p.Disponivel)
                .NotEmpty().NotNull()
                .WithMessage("Disponibilidade deve ser informada");
            RuleFor(p => p.Status)
                .NotEmpty().NotNull()
                .WithMessage("Status deve ser informado");
        }
    }
}
