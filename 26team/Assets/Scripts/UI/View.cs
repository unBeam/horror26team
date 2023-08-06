using UnityEngine;

namespace UI
{
    public abstract class View : MonoBehaviour
    {
        public bool IsOpened => gameObject.activeInHierarchy;
        
        public virtual void Open()
        {
            this.gameObject.SetActive(true);
        }
        public virtual void Close()
        {
            this.gameObject.SetActive(false);
        }
    }
}