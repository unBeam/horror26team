using System.Collections.Generic;
using BaseModels;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu]
    public class ItemsSO : ScriptableObject
    {
        public List<Item> Items;
    }
}