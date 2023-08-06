using System;
using System.Collections.Generic;
using Enums;
using UI;
using UnityEngine;

namespace BaseModels
{
    public class Player : Character
    {
        public override void TakeItem(Item item)
        {
            Debug.Log($"Player took item {item.Name}");
            _inventory.Add(item);
            if (CanUseItem(item))
            {
                //TODO: show use dialogue. (Player can use item or give it to department)
            }
        }

        public List<Item> GetItemsOfType(DepartmentType type)
        {
            return _inventory.FindAll(x => x.AffectedDepartments.Contains(type));
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