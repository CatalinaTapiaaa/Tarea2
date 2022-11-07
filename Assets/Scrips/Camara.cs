using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(new Vector3(-10f, 0f, 10f) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(new Vector3(10f, 0f, -10f) * Time.deltaTime, Space.Self);
        }
    }
}
