using System;
using UnityEngine;

namespace BaseModels
{
    [Serializable]
    public class Task
    {
        [SerializeField]
        private bool _isDone;

        [SerializeField]
        private int _timeToCompleteInSeconds;

        [SerializeField]
        private string _description;

        [SerializeField]
        private Task _requiredTask;

        [SerializeField]
        private GameType _gameType;

        [SerializeField]
        private DepartmentType _departmentType;

        public void Complete()
        {
            _isDone = true;
        }

        public string GetDescription()
        {
            return _description;
        }
    }
}
