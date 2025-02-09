using Taskflow.Models;

namespace Taskflow.Handlers;

public abstract class BaseTaskHandler : ITaskHandler
{
    protected ITaskHandler? NextHandler;

    public void SetNext(ITaskHandler next)
    {
        NextHandler = next;
    }

    public virtual void Handle(TaskItemModel task)
    {
        NextHandler?.Handle(task);
    }    
}