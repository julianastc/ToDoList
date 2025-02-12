namespace Domain.Entities;

public record ToDoItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description  { get; set; }
    public DateTime Date { get; set; }
    public bool Done { get; set; }
}