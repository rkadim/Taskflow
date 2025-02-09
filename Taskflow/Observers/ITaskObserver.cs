using Taskflow.Models;

namespace Taskflow.Observers;

public interface ITaskObserver
{
    void Notify(TaskItemModel task);
}
