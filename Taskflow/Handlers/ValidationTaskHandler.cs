namespace TaskFlow;

// Task validation handler
public class ValidationTaskHandler : BaseTaskHandler
{
    public override void Handle(TaskItem task)
    {
        if (string.IsNullOrWhiteSpace(task.Title))
        {
            throw new ArgumentException("Task title cannot be empty.");
        }
        base.Handle(task);
    }
}