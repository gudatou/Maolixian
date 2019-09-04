using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killbat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GG = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /* private void OnTriggerEnter2D(Collider2D collision)
     {
         Debug.Log("111");
         // gameObject.transform.parent.GetComponent<Rigidbody2D>().simulated = true;
         if (collision.gameObject.CompareTag("demond"))
         {
             gameObject.transform.parent.GetComponent<Rigidbody2D>().simulated = true;
         }
     }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.transform.parent.Find("red bat").GetComponent<Rigidbody2D>().simulated = true;
    }
}
