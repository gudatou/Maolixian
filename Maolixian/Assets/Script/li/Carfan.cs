using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carfan : MonoBehaviour
{
    public Rigidbody2D carfan = null;
    public float chua = -2.0f;
    //public Rigidbody2D rig;
    public bool Rigidbody2D = false;
    public bool runfan = false;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        carfan = GetComponent<Rigidbody2D>();


    }
    //private
    // Update is called once per frame
    void Update()
    {


    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Black Cat"))
        {
            runfan = true;
            //anim.

        }


        if (collision.gameObject.CompareTag("reverse"))

        {
            chua = -chua;
        }
        if (collision.gameObject.CompareTag("tractup"))
        {
            GameObject.Find("chezhengxiang (1)").GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("reverse"))
        {
            chua = -chua;
        }
    }

    public void FixedUpdate()
    {
        if (runfan == true)
        {
            carfan.velocity = new Vector2(chua, carfan.velocity.y);
            //    rig.velocity = new Vector2(speed,car.velocity.y);
        }
        //else
        //{
        //    car.velocity = new Vector2(-speed, car.velocity.y);
        //}

    }

}