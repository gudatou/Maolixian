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

    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody2D>();
        //rig = GetComponent<Rigidbody2D>();
        //EC = GetComponent<EdgeCollider2D>();
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

        }
        //if(collision.gameObject .CompareTag("tractup"))
        //{
        //    GameObject.Find("chezhengxiang (1)").GetComponent<CircleCollider2D>().enabled = false;
        //}
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