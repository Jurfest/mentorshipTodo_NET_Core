using MentorshipTodo.Communication.Responses;
using MentorshipTodo.Infrastructure;
using MentorshipTodo.Exceptions.ExceptionsBase;

namespace MentorshipTodo.UseCases.GetById;

public class GetTodoByIdUseCase
{
    public ResponseTodoJson Execute(int id)
    {
        using var dbContext = new MentorshipTodoDbContext();

        var entity = dbContext
            .Todos
            .FirstOrDefault(todo => todo.Id == id);
        
        if (entity is null)
            throw new NotFoundException("Todo not found.");

        return new ResponseTodoJson
        {
            Id = id,
            Title = entity.Title,
            IsCompleted = entity.IsCompleted,
        };
    }
}