using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    public float force = 50.0f;
    private Rigidbody2D rd;
    //public Vector3 dir;
    private bool isDead = false;
    private bool isJump = false;
    public bool ground;

    // Start is called before the first frame update
    public int Count = 0;
    public AudioClip pick_gem;
    private Animator anim = null;

    private bool grounded = true;


    void Start()
    {

        rd = this.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //di = GameObject.FindGameObjectsWithTag("Che");
        //dir = di.position.y - transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rd.AddForce(new Vector3(0, force, 0));
            isJump = true;
            anim.SetBool("jump",isJump);
        }
         

        //private void OnCollisionEnter2D(Collision2D collision)
        //{

        //}

    }
     private void OnCollisionEnter2D(Collision2D collision)
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("diamond"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("diamond"))
        {
            AudioSource.PlayClipAtPoint(pick_gem, collision.transform.position);
            Destroy(collision.gameObject);
            Count++;
        }


        if(collision.gameObject.CompareTag("missile"))
        {
            isDead = true;
            anim.SetBool("Dead", isDead);
            anim.SetTrigger("DeadOnce");
            //Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("bat"))
        {
            isDead = true;
            anim.SetBool("Dead", isDead);
            anim.SetTrigger("DeadOnce");
            //Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("frame"))
        {
            isDead = true;
            anim.SetBool("Dead", isDead);
            anim.SetTrigger("DeadOnce");
            //Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("ball"))
        {
            isDead = true;
            anim.SetBool("Dead", isDead);
            anim.SetTrigger("DeadOnce");
            //Time.timeScale = 0;
        }
        //if (collision.gameObject.CompareTag("Death level"))
        //{

        //}
        //if (collision.gameObject.CompareTag("ball"))
        //{

        //}


    }
}
