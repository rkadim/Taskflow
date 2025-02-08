namespace TaskFlow;

public interface ITaskHandler
{
    void SetNext(ITaskHandler next);
    void Handle(TaskItem task);
}