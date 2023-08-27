using DevFreela.Application.Commands.CreateProject;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(p => p.Description )
                .MaximumLength(255)
                .WithMessage("Tamanho máximo da Descrição e de 255 caracteres");
            
            RuleFor(p => p.Title)
                .MaximumLength(30)
                .WithMessage("Tamanho máximo do Titulo e de 30 caracteres");
        }
    }
}