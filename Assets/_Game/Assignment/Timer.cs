using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.ScriptableEvents;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private ScriptableEventBase timerEvent;
    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= 1)
        {
            timerEvent.Raise();
            _timer = 0;
        }
    }
}
