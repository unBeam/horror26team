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
    }
}