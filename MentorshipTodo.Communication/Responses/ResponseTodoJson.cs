namespace MentorshipTodo.Communication.Responses;

public class ResponseTodoJson
{
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
}