using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyController : MonoBehaviour
{
    public float disableDelay = 10;

    public void OnEnable()
    {
        Invoke("Disable", disableDelay);
    }

    public void Disable()
    {
        this.gameObject.SetActive(false);
    }
}