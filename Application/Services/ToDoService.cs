using Domain.Entities;
using Infra;

namespace Application.Services;

public class ToDoService : IToDoServices
{
    private readonly ApplicationDbContext _applicationDbContext;
    
    public ToDoService(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public List<ToDoItem> GetToDos()
    {
        var result = _applicationDbContext.ToDoItems.ToList();
        return result;
    }

    public void CreateToDo(ToDoItem item)
    {
        _applicationDbContext.ToDoItems.Add(item);
        _applicationDbContext.SaveChanges();
    }

    public void DeleteToDo(ToDoItem item)
    {
        _applicationDbContext.ToDoItems.Remove(item);
        _applicationDbContext.SaveChanges();
    }
}