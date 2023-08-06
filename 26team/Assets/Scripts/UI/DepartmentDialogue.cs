using BaseModels;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class DepartmentDialogue : View
    {
        //TODO: add some dialogue manager to fetch correct dialogue
        public void Open(Player player, Department department)
        {
            base.Open();
            
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