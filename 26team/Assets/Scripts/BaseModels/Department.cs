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

        private Task _taskInProgress;

        
        
        public override void TakeItem(Item item)
        {
            throw new System.NotImplementedException();
        }

        protected override void HandleEffect(Effect effect)
        {
            throw new System.NotImplementedException();
        }
    }
}