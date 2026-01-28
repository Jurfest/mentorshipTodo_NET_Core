using MentorshipTodo.Communication.Responses;
using MentorshipTodo.Infrastructure;

namespace MentorshipTodo.UseCases.GetAll;

public class GetAllTodosUseCase
{
    public ResponseAllTodosJson Execute()
    {
        using var dbContext = new MentorshipTodoDbContext();
    
        return new ResponseAllTodosJson
        {
            // Convertemos cada 'Todo' em um novo 'ResponseTodoJson'
            Todos = dbContext.Todos.Select(t => new ResponseTodoJson
            {
                Id = t.Id,
                Title = t.Title,
                IsCompleted = t.IsCompleted
            }).ToList()
        };
    }
}