using System.Collections.Generic;
using BaseModels;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu]
    public class TaskPoolSO : ScriptableObject
    {
        public List<Task> Tasks;
    }
}