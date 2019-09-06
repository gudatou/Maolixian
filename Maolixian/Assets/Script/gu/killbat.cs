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
    public GameObject GG;
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
        if (collision.gameObject.CompareTag("Black Cat"))
        {
            gameObject.transform.parent.Find("red bat").GetComponent<Rigidbody2D>().simulated = true;
           gameObject.transform.parent.gameObject.transform.eulerAngles = new Vector3(0, 0, 60.0f);
        }
    }
}
