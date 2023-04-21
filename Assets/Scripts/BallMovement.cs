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
        //rb.velocity = new Vector2(Speed.x, Speed.y);
    }

    private void Update()
    {
        //transform.position += Vector3.right * Speed * Time.deltaTime;
        rb.velocity = new Vector2(Speed.x, Speed.y);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Wall"))
        {
            Speed.y *= -1f;
        }else 
        {
            Speed.y = Random.Range(-5f, 5f);
            Speed.x *= -1f;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Gol!");
        transform.position = new Vector3(0f, 0f ,0f);
        
    }
}
