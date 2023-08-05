using System;
using BaseModels;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    private TechnicalAssignment _technicalAssignment;
    [SerializeField]
    private TaskPoolSO _taskPool;

    private void Awake()
    {
        if (!(_taskPool.Tasks?.Count > 0))
            return;
        
        var gameType = GetRandomGameType();

        var tasksByGameType = _taskPool.Tasks.FindAll(task => task.GetGameType() == gameType);
        _technicalAssignment = new TechnicalAssignment(tasksByGameType);
    }

    private static GameType GetRandomGameType()
    {
        var gameTypeValues = Enum.GetValues(typeof(GameType));
        return (GameType)gameTypeValues.GetValue(Random.Range(0, gameTypeValues.Length));
    }
}