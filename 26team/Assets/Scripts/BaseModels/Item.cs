using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace BaseModels
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private string _name;
        public string Name => _name;

        [SerializeField] private List<DepartmentType> _affectedDepartments;
        public List<DepartmentType> AffectedDepartments => _affectedDepartments;

        [SerializeField] private List<Effect> _effects;
        public List<Effect> Effects => _effects;

    }
}