using Taskflow.Models;

namespace Taskflow.Handlers;

public class ExecutionTaskHandler : BaseTaskHandler
{
    public override void Handle(TaskItemModel task)
    {
        if (task.ItemStatus == TaskItemStatus.Assigned)
        {
            task.ItemStatus = TaskItemStatus.InProgress;
            Console.WriteLine($"Task {task.Title} is now in progress.");
        }
        else
        {
            Console.WriteLine($"Task {task.Title} cannot be started because it's not assigned.");
        }

        base.Handle(task);
    }
}