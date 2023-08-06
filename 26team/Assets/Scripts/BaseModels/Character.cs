using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace BaseModels
{
    public abstract class Character : MonoBehaviour
    {
        [SerializeField] protected DepartmentType _departmentType;
        protected List<Effect> _appliedEffects = new List<Effect>();
        [SerializeField] protected int _speed;

        public virtual bool CanUseItem(Item item)
        {
            return item.AffectedDepartments.Contains(this._departmentType);
        }

        public abstract void TakeItem(Item item);

        protected virtual void UseItem(Item item)
        {
            foreach (var effect in item.Effects)
            {
                ApplyEffect(effect);
            }

        }

        protected virtual void ApplyEffect(Effect effect)
        {
            _appliedEffects.Add(effect);
            HandleEffect(effect);
        }

        protected abstract void HandleEffect(Effect effect);
    }
}