using System;
using System.Collections.Generic;
using UI;
using UnityEngine;

namespace BaseModels
{
    public class Player : Character
    {
        private List<Item> _inventory = new List<Item>();

        public override void TakeItem(Item item)
        {
            Debug.Log($"Player took item {item.Name}");
            _inventory.Add(item);
            if (CanUseItem(item))
            {
                //TODO: show use dialogue. (Player can use item or give it to department)
            }
        }

        protected override void HandleEffect(Effect effect)
        {
            throw new System.NotImplementedException();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Department department))
            {
                UiController.Instance.OpenDepartmentDialogue(this, department);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out Department department))
            {
                UiController.Instance.CloseDepartmentDialogue();
            }
        }
    }
}