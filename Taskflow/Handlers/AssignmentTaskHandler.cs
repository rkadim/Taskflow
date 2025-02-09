using Taskflow.Models;

namespace Taskflow.Handlers;

public class AssignmentTaskHandler : BaseTaskHandler
{
    public override void Handle(TaskItemModel task)
    {
        if (task.AssignedUser == null)
        {
            throw new InvalidOperationException("Task must be assigned to a user.");
        }
        base.Handle(task);
    }
}