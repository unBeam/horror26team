using System;
using Enums;
using UnityEngine;
using UnityEngine.Serialization;

namespace BaseModels
{
    [Serializable]
    public class Task
    {
        [SerializeField]
        private int _timeToCompleteInSeconds;

        [SerializeField]
        private string _description;

        [SerializeField]
        private Task _requiredTask;

        public Task RequiredTask => _requiredTask;

        [SerializeField]
        private GameType _gameType;

        [SerializeField]
        private DepartmentType _assigneeDepartment;

        public DepartmentType AssigneeDepartment;

        public enum Status
        {
            NotStarted,
            InProgress,
            Done
        }

        private Status _status = Status.NotStarted;
        public Status TaskStatus => _status;

        public string GetDescription()
            => _description;
        
        public GameType GetGameType()
            => _gameType;

        public event Action OnCompleted;
        public event Action<float> OnProgressChanged; 

        private System.Threading.Tasks.Task _progressTask;

        public void Start()
        {
            if(!CanBeStarted())
                return;

            if (_progressTask == null || _progressTask.IsCompleted)
            {
                _status = Status.InProgress;
                _progressTask = ProgressTask();
            }
            
        }
        
        private async System.Threading.Tasks.Task ProgressTask()
        {
            OnProgressChanged?.Invoke(0);
            for (int i = 0; i < _timeToCompleteInSeconds; i++)
            {
                if(i != 0)
                    OnProgressChanged?.Invoke(_timeToCompleteInSeconds/i);
                await System.Threading.Tasks.Task.Delay(1000);
            }
            
            OnCompleted?.Invoke();
        }

        public bool CanBeStarted()
        {
            if (_requiredTask != null)
                return _requiredTask.TaskStatus == Status.Done;
            
            return true;
        }
    }
}
