using Taskflow.Models;
using Taskflow.Observers;

namespace Taskflow;

public class TaskItem : TaskItemModel
{
    private readonly List<ITaskObserver> _observers = new();

    public void AttachObserver(ITaskObserver observer)
    {
        _observers.Add(observer);
    }

    public void DetachObserver(ITaskObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Notify(this);
        }
    }

    // Вызывается при изменении статуса
    public void ChangeStatus(TaskItemStatus newStatus)
    {
        ItemStatus = newStatus;
        NotifyObservers();
    }
}
