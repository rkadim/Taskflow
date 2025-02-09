using Taskflow.Models;

namespace Taskflow.Observers;

public class EmailNotification : ITaskObserver
{
    public void Notify(TaskItemModel task)
    {
        Console.WriteLine($"Email sent to {task.AssignedUser.Email}: Task {task.Title} is now {task.ItemStatus}.");
    }
}
