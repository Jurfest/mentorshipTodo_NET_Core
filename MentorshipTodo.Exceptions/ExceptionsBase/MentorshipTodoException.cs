using System.Net;

namespace MentorshipTodo.Exceptions.ExceptionsBase;

public abstract class MentorshipTodoException : SystemException
{
    public MentorshipTodoException(string errorMessage) : base(errorMessage)
    {
            
    }

    public abstract List<string> GetErrors();
        
    public abstract HttpStatusCode GetHttpStatusCode();
}