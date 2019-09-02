using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    public float force = 50.0f;
    private Rigidbody2D rd;
    //public Vector3 dir;

    // Start is called before the first frame update
    public int Count = 0;
    public AudioClip pick_gem;
    private bool isDead = false;
    void Start()
    {

        rd = this.GetComponent<Rigidbody2D>();
        //di = GameObject.FindGameObjectsWithTag("Che");
        //dir = di.position.y - transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rd.AddForce(new Vector3(0, force, 0));
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
        if (collision.gameObject.CompareTag("frame"))
        {
            isDead = true;
            collision.gameObject.GetComponent<AudioSource>().Play();
            //anim.SetBool("Dead", isDead);
            //anim.SetTrigger("DiedOnce");
            Time.timeScale = 0;
            Debug.Log("cat is dead");
        }
    }
}
