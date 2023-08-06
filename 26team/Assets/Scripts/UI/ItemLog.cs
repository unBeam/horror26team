using BaseModels;
using TMPro;
using UnityEngine;

namespace UI
{
    public class ItemLog : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        public void LogItem(string text)
        {
            _text.text += "\n" + text;
        }
    }
}