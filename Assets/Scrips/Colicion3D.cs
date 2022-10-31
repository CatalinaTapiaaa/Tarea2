using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colicion3D : MonoBehaviour
{
    public GameObject Bola;

    private void OnCollisionEnter(Collision target)
    {
        Debug.Log("Collision Enter");
    }

    private void OnCollisionStay(Collision target)
    {
        Debug.Log("Collision Stay");
        Bola.SetActive(true);
    }

    private void OnCollisionExit(Collision target)
    {
        Debug.Log("Collision Exit");
    }
}
