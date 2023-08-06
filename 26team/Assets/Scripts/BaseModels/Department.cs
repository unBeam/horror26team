using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace BaseModels
{
    public class Department : Character
    {
        [SerializeField] private Item _requiredToCommunicate;
        [SerializeField] private Item _requiredItem;

        private bool _canCommunicate = false;

        private Task _taskInProgress = null;

        public bool CanTalk()
        {
            return _inventory.Contains(_requiredToCommunicate);
        }

        public bool CanTakeTasks()
        {
            return _inventory.Contains(_requiredToCommunicate) && _inventory.Contains(_requiredItem);
        }
        
        public override void TakeItem(Item item)
        {
            if(item == _requiredToCommunicate || item == _requiredItem)
                _inventory.Add(item);
            
            foreach (var effect in item.Effects)
            {
                ApplyEffect(effect);
            }
        }

        public bool CanTakeTask(Task task)
        {
            if (task.AssigneeDepartment != _departmentType)
                return false;

            if (_taskInProgress != null && _taskInProgress.TaskStatus != Task.Status.Done)
                return false;

            if (task.RequiredTask != null)
                return task.RequiredTask.TaskStatus == Task.Status.Done;

            return true;
        }
        
        private void TakeTask(Task task)
        {
            if(!CanTakeTask(task))
                return;
            
            _taskInProgress = task;
            _taskInProgress.Start();
        }

        protected override void HandleEffect(Effect effect)
        {
        }
    }
}