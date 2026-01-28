using MentorshipTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace MentorshipTodo.Infrastructure;

public class MentorshipTodoDbContext : DbContext
{
    public DbSet<Todo> Todos { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=/Volumes/KINGSTON/Developer/dotnet/TodoListDb/TodoList_NET.db");
    }
}