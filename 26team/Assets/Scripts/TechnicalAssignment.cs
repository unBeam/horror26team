using System.Collections.Generic;
using BaseModels;

public class TechnicalAssignment
{
    private List<Task> _tasks;

    public List<Task> GetTasks()
        => _tasks;

    public TechnicalAssignment(List<Task> tasks)
    {
        _tasks = tasks;
    }
}
