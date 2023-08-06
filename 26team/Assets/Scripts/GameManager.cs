using System;
using BaseModels;
using Enums;
using ScriptableObjects;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public TechnicalAssignment TechnicalAssignment { get; private set; }
    [SerializeField]
    private TaskPoolSO _taskPool;

    public static GameManager Instance;
    
    private void Awake()
    {
        if (!(_taskPool.Tasks?.Count > 0))
            return;
        
        var gameType = GetRandomGameType();

        var tasksByGameType = _taskPool.Tasks.FindAll(task => task.GetGameType() == gameType);
        TechnicalAssignment = new TechnicalAssignment(tasksByGameType);

        Instance = this;
    }

    private static GameType GetRandomGameType()
    {
        var gameTypeValues = Enum.GetValues(typeof(GameType));
        return (GameType)gameTypeValues.GetValue(Random.Range(0, gameTypeValues.Length));
    }
}