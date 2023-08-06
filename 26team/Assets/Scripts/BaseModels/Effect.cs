using System;
using Enums;
using UnityEngine;

namespace BaseModels
{
    [Serializable]
    public class Effect
    {
        [SerializeField] private EffectType _type;
        public EffectType Type => _type;

        [SerializeField] private float _value;
        public float Value => _value;

        [SerializeField] private int _timeSeconds;
        public int TimeSeconds => _timeSeconds;

        public event Action OnEffectEnded;

        private System.Threading.Tasks.Task _effectLifetime = null;

        public void Activate()
        {
            if (_effectLifetime == null || _effectLifetime.IsCompleted)
                _effectLifetime = EffectLifetimeTask();
        }

        private async System.Threading.Tasks.Task EffectLifetimeTask()
        {
            for (int i = 0; i < _timeSeconds; i++)
            {
                await System.Threading.Tasks.Task.Delay(1000);
            }
            
            OnEffectEnded?.Invoke();
        }
    }
}