using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carfan : MonoBehaviour
{
    public Rigidbody2D Fcar = null;
    public float Fsport = -3.0f;
    //public Rigidbody2D rig;
    public bool Rigidbody2D = false;
    public bool fanrun = false;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        Fcar = GetComponent<Rigidbody2D>();


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
            fanrun = true;


        }






        //if (collision.gameObject.CompareTag("reverse"))

        //{
        //    Fsport = -Fsport;
        //}

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //    if (collision.gameObject.CompareTag("Black Cat"))
        //    {
        //        fanrun = true;
        //        //anim.

        //    }
        if (collision.gameObject.CompareTag("Black Cat"))
        {
            fanrun = true;


        }

        if (collision.gameObject.CompareTag("reverse"))

        {
            Fsport = -Fsport;
        }

        if (collision.gameObject.CompareTag("Black Cat"))
        {
            fanrun = true;
            //anim.

        }
        if (gameObject.CompareTag("reverse"))

        {

            fanrun = true;
            //anim.



        }

    }


        void FixedUpdate()
        {
            if (fanrun == true)
            {
                Fcar.velocity = new Vector2(Fsport, Fcar.velocity.y);

            }


        }
    }


