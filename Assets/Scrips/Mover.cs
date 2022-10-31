using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private float speed = 5;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            MovePlayer(Vector3.forward);

        if (Input.GetKey(KeyCode.A))
            MovePlayer(Vector3.left);

        if (Input.GetKey(KeyCode.S))
            MovePlayer(Vector3.back);

        if (Input.GetKey(KeyCode.D))
            MovePlayer(Vector3.right);
    }

    private void MovePlayer(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
