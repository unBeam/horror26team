using System.Collections.Generic;
using BaseModels;

public class TechnicalAssignment
{
    private List<Task> _tasks;

    public List<Task> Tasks => _tasks;

    public TechnicalAssignment(List<Task> tasks)
    {
        _tasks = tasks;
    }

    public void StartTask(Task task)
    {
        var index = _tasks.FindIndex(x => x == task);
        if(index != -1)
            _tasks[index].Start();
    }
}
