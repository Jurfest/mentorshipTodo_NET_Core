using MentorshipTodo.Models;
using MentorshipTodo.Infrastructure;
using MentorshipTodo.Communication.Requests;
using MentorshipTodo.Communication.Responses;
using MentorshipTodo.Exceptions.ExceptionsBase;
using MentorshipTodo.UseCases.SharedValidator;

namespace MentorshipTodo.UseCases.Register;

public class RegisterTodoUseCase
{
        public ResponseTodoJson Execute(RequestTodoJson request)
        {
            Validate(request);

            using var dbContext = new MentorshipTodoDbContext();
            var entity = new Todo {
                Title = request.Title,
                IsCompleted = request.IsCompleted
            };
            dbContext.Todos.Add(entity);
            dbContext.SaveChanges();

            return new ResponseTodoJson
            {
                Id = entity.Id,
                Title = entity.Title,
                IsCompleted = entity.IsCompleted,
            };
        }

        private void Validate(RequestTodoJson request)
        {
            var validator = new RequestTodoValidator();
            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errors = result.Errors.Select(e => e.ErrorMessage).ToList();
                throw new ErrorOnValidationException(errors);
            }
        }
    
}