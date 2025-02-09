using Taskflow.Models;

namespace Taskflow.Handlers;

public interface ITaskHandler
{
    void SetNext(ITaskHandler next);
    void Handle(TaskItemModel task);
}