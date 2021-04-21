using FluentValidation;

namespace Todo.Domain.EntitiesValidators
{
    public class TaskValidator : AbstractValidator<Task>
    {
        public TaskValidator()
        {
            RuleFor(s => s.Descricao)
            .NotEmpty()
            .WithMessage("O nome da tarefa não pode estar vazio")
            .MaximumLength(50)
            .WithMessage("A descrição deve conter no máximo 50 caracteres");
        }
    }
}