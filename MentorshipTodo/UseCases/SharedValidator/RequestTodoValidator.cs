using FluentValidation;
using MentorshipTodo.Communication.Requests;

namespace MentorshipTodo.UseCases.SharedValidator;

public class RequestTodoValidator : AbstractValidator<RequestTodoJson>
{
        public RequestTodoValidator()
        {
            RuleFor(todo => todo.Title)
                .NotEmpty().WithMessage("Todo title is required.")
                .MaximumLength(100).WithMessage("Todo title must not exceed 100 characters.");
        }
}
