namespace TaskFlow;

public class AssignmentTaskHandler : BaseTaskHandler
{
    public override void Handle(TaskItem task)
    {
        if (task.AssignedUser == null)
        {
            throw new InvalidOperationException("Task must be assigned to a user.");
        }
        base.Handle(task);
    }
}