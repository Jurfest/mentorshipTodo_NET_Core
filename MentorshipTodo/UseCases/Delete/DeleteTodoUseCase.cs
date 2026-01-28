using MentorshipTodo.Infrastructure;
using MentorshipTodo.Exceptions.ExceptionsBase;

namespace MentorshipTodo.UseCases.Delete;

public class DeleteTodoUseCase
{
    public void Execute(int id)
    {
        using var dbContext = new MentorshipTodoDbContext();
        var entity = dbContext.Todos.FirstOrDefault(todo => todo.Id == id);
        
        if (entity is null)
        {
            throw new NotFoundException("Todo not found.");
        }

        dbContext.Todos.Remove(entity);
        dbContext.SaveChanges();
    }
}