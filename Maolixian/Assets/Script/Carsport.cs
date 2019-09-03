using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carsport : MonoBehaviour
{
    
    public float speed = 2.0f;
    public Rigidbody2D rig;
    public  bool run = false;
  

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Black Cat"))
        {
            run = true;
           
        }
    }
    
    public void FixedUpdate()
    {
        if(run)
        {
            rig.velocity = new Vector2(speed, 0);
        }
        
    }
}
