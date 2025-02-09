namespace Taskflow.Models;

// Domain entity
public class TaskItemModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public TaskItemStatus ItemStatus { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public User? AssignedUser { get; set; }
}