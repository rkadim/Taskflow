namespace TaskFlow;

public abstract class BaseTaskHandler : ITaskHandler
{
    protected ITaskHandler? NextHandler;

    public void SetNext(ITaskHandler next)
    {
        NextHandler = next;
    }

    public virtual void Handle(TaskItem task)
    {
        NextHandler?.Handle(task);
    }    
}