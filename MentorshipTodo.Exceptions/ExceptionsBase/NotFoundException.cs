using System.Net;

namespace MentorshipTodo.Exceptions.ExceptionsBase;

public class NotFoundException : MentorshipTodoException
{
    public NotFoundException(string errorMessage) : base(errorMessage)
    {
        
    }

    public override List<string> GetErrors() => [Message];
    
    public override HttpStatusCode GetHttpStatusCode() => HttpStatusCode.NotFound;
}