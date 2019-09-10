using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallWallLeft : MonoBehaviour
{
    
    

    private Rigidbody2D cat;
    void Start()
    {

    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetButton("Fire1"))
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            collision.GetComponent<Rigidbody2D>().AddForce(new Vector2(-40, 80));
            collision.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}