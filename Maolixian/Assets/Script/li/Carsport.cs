using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carsport : MonoBehaviour
{
    public Rigidbody2D car = null;
    public float speed = 2.0f;
    //public Rigidbody2D rig;
    public bool Rigidbody2D = false;
    public bool run = false;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Black Cat"))
        {
            run = true;
            //anim.

        }
        

        if (collision.gameObject.CompareTag("reverse"))

        {
            speed = -speed;
        }
        if(collision.gameObject .CompareTag("tractup"))
        {
           GameObject.Find("chezhengxiang (1)").GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("reverse"))
        {
            speed = -speed;
        }
    }

    public void FixedUpdate()
    {
        if (run == true)
        {
            car.velocity = new Vector2(speed, car.velocity.y);
            //    rig.velocity = new Vector2(speed,car.velocity.y);
        }
        //else
        //{
        //    car.velocity = new Vector2(-speed, car.velocity.y);
        //}

    }

}