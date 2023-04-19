using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Vector3 Speed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Speed.x, Speed.y);
    }

    private void Update()
    {
        //transform.position += Vector3.right * Speed * Time.deltaTime;
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Speed *= -1f;
    }
}
