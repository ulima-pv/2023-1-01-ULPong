using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float Speed = 1f;

    // Update is called once per frame
    void Update()
    {
        float movVertical = Input.GetAxis("Vertical");

        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(
                transform.position.y + movVertical * Speed * Time.deltaTime,
                -4f,
                4f
            ),
            transform.position.z
        );

        //transform.position += Vector3.up * movVertical * Speed * Time.deltaTime;
    }
}
