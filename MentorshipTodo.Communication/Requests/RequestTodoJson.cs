namespace MentorshipTodo.Communication.Requests;

public class RequestTodoJson
{
    public string Title { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
}