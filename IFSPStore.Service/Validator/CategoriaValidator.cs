using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validator
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().NotNull()
                .WithMessage("Nome da categoria é obrigatório")
                .MaximumLength(50)
                .WithMessage("Nome da categoria deve conter no máximo 50 caracteres");
            RuleFor(c => c.Descricao)
                .MaximumLength(200)
                .WithMessage("Descrição da categoria deve conter no máximo 200 caracteres");
        }
    }
}
