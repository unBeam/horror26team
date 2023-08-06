using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanicLevel : MonoBehaviour
{
    public TextMeshProUGUI panicText;

    public GameObject panic;

    private float _maxPanicLevel = 100f;
    private float _panicIncreaseRate = 1f;
    private float _panicDecreaseAmount = 10f;
    private float _panicTimerRate = 3f;

    private float _currentPanicLevel;

    void Start()
    {
        panic.SetActive(true);
        _currentPanicLevel = 0f;
        InvokeRepeating("IncreasePanicLevel", _panicTimerRate, _panicTimerRate);
    }

    void IncreasePanicLevel()
    {
        if (_currentPanicLevel < _maxPanicLevel)
        {
            _currentPanicLevel += _panicIncreaseRate;
            panicText.text = "Panic lvl" + " " + _currentPanicLevel + "%";
        }
    }

    public void DecreasePanicLevel()
    {
        if (_currentPanicLevel > 0)
        {
            _currentPanicLevel -= _panicDecreaseAmount;
        }
    }
}