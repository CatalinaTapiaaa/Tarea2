using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausar2 : MonoBehaviour
{
    private bool _isPaused;

    private void Start()
    {
        _isPaused = !_isPaused;

        if (_isPaused)
        {
            Time.timeScale = 1;
        }
    }
}
