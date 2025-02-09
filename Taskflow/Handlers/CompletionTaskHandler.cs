using Taskflow.Models;

namespace Taskflow.Handlers;

public class CompletionTaskHandler : BaseTaskHandler
{
    public override void Handle(TaskItemModel task)
    {
        if (task.ItemStatus == TaskItemStatus.InProgress)
        {
            task.ItemStatus = TaskItemStatus.Completed;
            Console.WriteLine($"Task {task.Title} has been completed.");
        }
        else
        {
            Console.WriteLine($"Task {task.Title} cannot be completed because it's not in progress.");
        }

        base.Handle(task);
    }
}