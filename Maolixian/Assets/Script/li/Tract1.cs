using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tract1 : MonoBehaviour
{
    public Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("car"))
        {
            Destroy(collision.gameObject.GetComponent<Collider2D>());
        }
    }
}
