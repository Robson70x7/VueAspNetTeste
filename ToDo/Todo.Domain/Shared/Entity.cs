using FluentValidation.Results;

namespace Todo.Domain.Shared
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public ValidationResult ValidationResult{ get; set; }
    }
}