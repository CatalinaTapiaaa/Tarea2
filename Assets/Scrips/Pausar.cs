using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausar : MonoBehaviour
{
    public GameObject Bola;

    private bool _isPaused;

    private void OnCollisionEnter(Collision target)
    {
        Debug.Log("Collision Stay");
        Bola.SetActive(true);

        _isPaused = !_isPaused;

        if (_isPaused)
        {
            Time.timeScale = 0;
        }
    }
}
