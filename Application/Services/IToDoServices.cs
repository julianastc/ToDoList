using Domain.Entities;
using Infra;

namespace Application.Services;

public interface IToDoServices
{
    public List<ToDoItem> GetToDos();
    public void CreateToDo(ToDoItem item);
    public void DeleteToDo(ToDoItem item);
}