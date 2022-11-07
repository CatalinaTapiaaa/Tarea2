using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estatico : MonoBehaviour
{
    private Mover mover;

    private void Start()
    {
        mover = GetComponent<Mover>();  
    }

    private void OnCollisionEnter(Collision target)
    {
        Debug.Log("Collision Enter");
    }

    private void OnCollisionStay(Collision target)
    {
        Debug.Log("Collision Stay");
        mover.enabled = false;
    }

    private void OnCollisionExit(Collision target)
    {
        Debug.Log("Collision Exit");
        mover.enabled = true;

    }
}
