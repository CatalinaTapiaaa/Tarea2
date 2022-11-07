using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 15f, 0f, 0f);
        transform.Translate(0f, 0f, Input.GetAxis("Vertical") * Time.deltaTime * 15f);
    }
}
