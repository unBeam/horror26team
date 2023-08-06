using BaseModels;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class DepartmentDialogue : View
    {
        [SerializeField] private TMP_Text _text;

        //TODO: add some dialogue manager to fetch correct dialogue
        public void Open(Player player, Department department)
        {
            base.Open();

            var items = player.GetItemsOfType(department.DepartmentType);
            foreach (var item in items)
            {
                department.TakeItem(item);
            }

            if (department.CanTalk())
            {
                if (department.CanTakeTasks())
                    _text.text = "Теперь вы друг друга понимаете.\n Но чтобы ставить задачки нужен еще один предмет";
                else
                    _text.text = "Теперь вы друг друга понимаете.\n Скоро можно бует ставить задачки(в следующей версии игры)";
            }
            else
            {
                _text.text =
                    "Вы ничего не понимаете из того что вам говорят. \nВозможно где-то в офисе есть предмет коорый поможет вам наладить коммуникацию";
            }

            //TODO: Check if player and department can talk
            //TODO: if can talk => Continue else cancel dialogue
            //TODO: take tasks and items from player
            //TODO: fetch correct dialogue
            //TODO: check what department is currently working on
        }

        public void OnGiveTaskButtonPressed()
        {
            //TODO: assign task to department
        }

        public void OnGiveItemButtonPressed()
        {
            //TODO: give item to to department
        }
    }
}