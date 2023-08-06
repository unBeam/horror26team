using System;
using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace BaseModels
{
    [RequireComponent(typeof(Collider))]
    public class Item : MonoBehaviour
    {
        [SerializeField] private string _name;
        public string Name => _name;

        [SerializeField] private List<DepartmentType> _affectedDepartments;
        public List<DepartmentType> AffectedDepartments => _affectedDepartments;

        [SerializeField] private List<Effect> _effects;
        public List<Effect> Effects => _effects;
        
        private void Awake()
        {
            var collider = GetComponent<Collider>();
            collider.isTrigger = true;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.transform.TryGetComponent(out Character character))
            {
                character.TakeItem(this);
                //TODO: play disappear animation
                this.gameObject.SetActive(false);
            }
        }

    }
}