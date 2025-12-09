using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validator
{
    public class FuncionarioValidator : AbstractValidator<Funcionario>
    {
        public FuncionarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().NotNull()
                .WithMessage("Nome do ususario obrigatório");
            RuleFor(c => c.Login)
                .NotEmpty().NotNull()
                .WithMessage("Login obrigatório");
            RuleFor(c => c.Senha)
                .NotEmpty().NotNull()
                .WithMessage("Senha obrigatória");
            RuleFor (c => c.Email)
                .EmailAddress().WithMessage("E-mail inválido")
                .NotEmpty().NotNull().WithMessage("E-mail obrigatório");
            RuleFor(c => c.DataRegistro)
                .NotEmpty().NotNull()
                .WithMessage("Data de registro obrigatória");
            RuleFor(c => c.UltimoLogin)
                .NotEmpty().NotNull();
            RuleFor(c => c.Ativo)
                .NotEmpty().NotNull()
                .WithMessage("Status do usuário obrigatório");
        }
    }
}
