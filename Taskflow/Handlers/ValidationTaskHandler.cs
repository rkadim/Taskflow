using Taskflow.Models;

namespace Taskflow.Handlers;

// Task validation handler
public class ValidationTaskHandler : BaseTaskHandler
{
    public override void Handle(TaskItemModel task)
    {
        if (string.IsNullOrWhiteSpace(task.Title))
        {
            throw new ArgumentException("Task title cannot be empty.");
        }
        base.Handle(task);
    }
}