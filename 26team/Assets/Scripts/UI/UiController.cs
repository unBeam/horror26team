using System;
using BaseModels;
using UnityEngine;

namespace UI
{
    public class UiController : MonoBehaviour
    {
        [SerializeField] private DepartmentDialogue _departmentDialogue;
        public static UiController Instance;

        private View _currentlyOpened;

        private void Awake()
        {
            Instance = this;
        }

        public void OpenDepartmentDialogue(Player player, Department department)
        {
            _currentlyOpened?.Close();
            _currentlyOpened = _departmentDialogue;
            _departmentDialogue.Open(player, department);
        }
        public void CloseDepartmentDialogue()
        {
            if (_currentlyOpened == _departmentDialogue)
                _currentlyOpened = null;
            _departmentDialogue.Close();
        }

        public void Return()
        {
            _currentlyOpened?.Close();
        }
    }
}