using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colicion3D1 : MonoBehaviour
{
    public GameObject Bola;

    private void OnCollisionEnter(Collision target)
    {
        Debug.Log("Collision Enter");
        Bola.SetActive(true);
    }

    private void OnCollisionStay(Collision target)
    {
        Debug.Log("Collision Stay");
    }

    private void OnCollisionExit(Collision target)
    {
        Debug.Log("Collision Exit");
    }
}
