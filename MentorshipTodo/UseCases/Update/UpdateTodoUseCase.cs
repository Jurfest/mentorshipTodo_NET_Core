using Microsoft.Extensions.Options;
using MentorshipTodo.Infrastructure;
using MentorshipTodo.UseCases.SharedValidator;
using MentorshipTodo.Communication.Requests;
using MentorshipTodo.Exceptions.ExceptionsBase;

namespace MentorshipTodo.UseCases.Update;

public class UpdateTodoUseCase
{
    public void Execute(int clientId, RequestTodoJson request)
    {
        Validate(request);
        using var dbContext = new MentorshipTodoDbContext();

        // NOTE: first quando garantimos que o id existe, firstOrDefault se nao
        var entity = dbContext.Todos.FirstOrDefault(todo => todo.Id == clientId);

        if (entity is null)
            throw new NotFoundException("Client not found.");

        entity.Title = request.Title;
        entity.IsCompleted = request.IsCompleted;

        dbContext.Todos.Update(entity);
        dbContext.SaveChanges();
    }

    private void Validate(RequestTodoJson request)
    {
        var validator = new RequestTodoValidator();
        var result = validator.Validate(request);
        if (!result.IsValid)
        {
            var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();
            throw new ErrorOnValidationException(errors);
        }
    }
}